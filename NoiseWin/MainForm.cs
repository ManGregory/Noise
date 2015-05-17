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
        private readonly Map _map = new Map();

        private void AddMapControl(MapElement item)
        {
            if (item.Location.X == 0 && item.Location.Y == 0)
            {
                item.Location = new Point(0, (_map.MapElements.Count - 1)*50);
            }
            var newMapControl = new Button
            {
                Parent = pnlMap,
                Width = 50,
                Height = 50,
                Text = item.Number.ToString(),
                Font = new Font("Microsoft Sans Serif", 25F),
                ForeColor = item.MapElementType == MapElementType.NoiseSource ? Color.Red : Color.Blue,
                Location = item.Location,
                Tag = item,
                ContextMenuStrip = msMapControl,
            };
            newMapControl.MouseDown += newMapControl_MouseDown;
            newMapControl.Click += newMapControl_Click;
            ControlMover.Init(newMapControl, item);
            BindNoiseList();
        }

        private void BindNoiseList()
        {
            var noiseMapElements = _map.MapElements.Where(m => m.MapElementType == MapElementType.NoiseSource).ToList();
            lstNoiseSources.DataSource = noiseMapElements;            
            wbInputTable.DocumentText = NoiseHelper.CreateInputDataTable(noiseMapElements);
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
            InitMap();
            wbInputTable.Navigate("about:blank");
        }

        private void InitMap()
        {            
            _map.MapElements = new BindingList<MapElement> {RaiseListChangedEvents = true};
            _map.MapElements.ListChanged += (sender, args) =>
            {
                BindNoiseList();
                if (args.ListChangedType == ListChangedType.ItemAdded)
                {
                    AddMapControl(_map.MapElements[args.NewIndex]);
                }
            };            
        }

        private void InitMap(Map map)
        {
            ClearMap();
            InitMap();
            foreach (var elem in map.MapElements)
            {
                _map.MapElements.Add(elem);
            }
        }

        private void RemoveMapControl(MapElement mapElement)
        {
            for (int i = 0; i < pnlMap.Controls.Count; i++)
            {
                var control = pnlMap.Controls[i];
                var tag = (control.Tag as MapElement);
                if ((tag != null) && (tag == mapElement))
                {
                    pnlMap.Controls.Remove(control);
                }
            }
        }

        private void btnAddNoiseSource_Click(object sender, EventArgs e)
        {
            _map.MapElements.Add(new NoiseMapElement
            {
                Number = _map.MapElements.Count(m => m.MapElementType == MapElementType.NoiseSource) + 1
            });
        }

        private void btnAddPartition_Click(object sender, EventArgs e)
        {
            _map.MapElements.Add(new PartitionMapElement
            {
                Number = _map.MapElements.Count(m => m.MapElementType == MapElementType.Partition) + 1
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
                _map.MapElements.Remove(btn.Tag as MapElement);
            }
        }

        private void pgMapControl_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            BindNoiseList();
        }

        private void btnClearMap_Click(object sender, EventArgs e)
        {
            ClearMap();
        }

        private void ClearMap()
        {
            foreach (var mapElement in _map.MapElements)
            {
                RemoveMapControl(mapElement);
            }
            _map.MapElements.Clear();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtCalcResults.Text = NoiseHelper.Calc(_map.MapElements);
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            using (var sd = new SaveFileDialog())
            {
                if (sd.ShowDialog(this) == DialogResult.OK)
                {
                    Map.SaveToFile(sd.FileName, _map);
                }
            }
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            using (var od = new OpenFileDialog())
            {
                if (od.ShowDialog(this) == DialogResult.OK)
                {
                    var map = Map.LoadFromFile(od.FileName);
                    InitMap(map);
                }
            }
        }
    }
}
