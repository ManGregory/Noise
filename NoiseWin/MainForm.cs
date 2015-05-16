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
        private BindingList<MapElement> _mapElements = new BindingList<MapElement>();

        private void AddMapControl(MapElement item)
        {
            var newMapControl = new Button
            {
                Parent = pnlMap,
                Width = 50,
                Height = 50,
                Text = item.Number.ToString(),
                Font = new Font("Microsoft Sans Serif", 25F),
                ForeColor = item.MapElementType == MapElementType.NoiseSource ? Color.Red : Color.Blue,
                Location = new Point(0, (_mapElements.Count - 1) * 50),
                Tag = item,
                ContextMenuStrip = msMapControl,
            };
            newMapControl.MouseDown += newMapControl_MouseDown;
            newMapControl.Click += newMapControl_Click;
            ControlMover.Init(newMapControl);
            BindNoiseList();
        }

        private void BindNoiseList()
        {
            lstNoiseSources.DataSource = _mapElements.Where(m => m.MapElementType == MapElementType.NoiseSource).ToList();
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
            _mapElements.RaiseListChangedEvents = true;
            _mapElements.ListChanged += (sender, args) =>
            {
                if (args.ListChangedType == ListChangedType.ItemAdded)
                {
                    AddMapControl(_mapElements[args.NewIndex]);
                }
            };
        }

        private void btnAddNoiseSource_Click(object sender, EventArgs e)
        {
            _mapElements.Add(new NoiseMapElement
            {
                Number = _mapElements.Count(m => m.MapElementType == MapElementType.NoiseSource) + 1
            });
        }

        private void btnAddPartition_Click(object sender, EventArgs e)
        {
            _mapElements.Add(new PartitionMapElement
            {
                Number = _mapElements.Count(m => m.MapElementType == MapElementType.Partition) + 1
            });
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

        private void pgMapControl_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            BindNoiseList();
        }
    }
}
