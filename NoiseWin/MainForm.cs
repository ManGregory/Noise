using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoiseWin.Helper;

namespace NoiseWin
{
    public partial class MainForm : Form
    {
        private ObservableCollection<MapElement> _mapElements = new ObservableCollection<MapElement>();

        private void AddMapElement(IList newItems)
        {
            foreach (var item in newItems)
            {
                AddMapControl(item as MapElement);
            }
        }

        private void AddMapControl(MapElement item)
        {
            var newMapControl = new Button
            {
                Parent = pnlMap,
                Width = 50,
                Height = 50,
                Text = _mapElements.Count.ToString(),
                Font = new Font("Microsoft Sans Serif", 25F),
                ForeColor = Color.Red,
                Location = new Point(0, _mapElements.Count * 50),
                Tag = item,
                ContextMenuStrip = msMapControl,
            };
            newMapControl.MouseDown += newMapControl_MouseDown;
            newMapControl.Click += newMapControl_Click;
            ControlMover.Init(newMapControl);
        }

        private void newMapControl_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                var mapElement = btn.Tag as MapElement;
                if (mapElement != null)
                {
                    pgMapControl.SelectedObject = mapElement;
                }
            }
        }

        private void newMapControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                msMapControl.Show();
            }
        }

        public MainForm()
        {
            InitializeComponent();
            _mapElements.CollectionChanged += ((sender, args) =>
            {
                if (args.Action == NotifyCollectionChangedAction.Add)
                {
                    AddMapElement(args.NewItems);
                } 
                else if (args.Action == NotifyCollectionChangedAction.Remove)
                {
                    
                }
            });
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNoiseSource_Click(object sender, EventArgs e)
        {
            _mapElements.Add(new NoiseMapElement());
        }

        private void miRemove_Click(object sender, EventArgs e)
        {
            var item = (ToolStripItem)sender;
            var menu = (ContextMenuStrip)item.GetCurrentParent();
            var btn = (Button)menu.SourceControl;
            if (btn != null)
            {
                pnlMap.Controls.Remove(btn);
                _mapElements.Remove(btn.Tag as MapElement);
            }
        }
    }
}
