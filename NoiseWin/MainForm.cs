using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NoiseWin.Helper;

namespace NoiseWin
{
    public partial class MainForm : Form
    {
        private readonly Map _map = new Map();
        private bool IsGetAdditionalNoise = true;

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
            InitComboBox();
            wbInputTable.Navigate("about:blank");
            wbCalc.Navigate("about:blank");
        }

        private void InitComboBox()
        {
            cmbTableType.Items.Clear();
            cmbInRoom.Items.Clear();
            cmbTableType.Items.AddRange(new object[]{"Таблица 2.1", "Таблица 2.2"});
            cmbInRoom.Items.AddRange(new object[] { "Снаружи", "Внутри" });
            cmbTableType.SelectedIndex = 0;
            cmbInRoom.SelectedIndex = 0;
            cmbRoomType.DataSource = NoiseHelper.NormalNoiseLevels21.Keys.Concat(NoiseHelper.NormalNoiseLevels23.Keys).ToList();
            cmbNoiseCharacter.DataSource = NoiseHelper.NoiseCharacter.Keys.ToList();
            cmbObjectPlace.DataSource = NoiseHelper.ObjectPlace.Keys.ToList();
            cmbTimeOfTheDay.DataSource = NoiseHelper.TimeOfTheDay.Keys.ToList();
            cmbDurationOfExposure.DataSource = NoiseHelper.DurationOfExposure.Keys.ToList();
            cmbSummaryDurationOfExposure.DataSource = NoiseHelper.SummaryDurationOfExposure.Keys.ToList();            
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
            InitComboBox();
            foreach (var elem in map.MapElements)
            {
                _map.MapElements.Add(elem);
            }
            _map.TableType = map.TableType;
            _map.AdditionalNoiseCharacteristic = map.AdditionalNoiseCharacteristic;
            SelectAdditionalCharacteristic();
        }

        private void SelectAdditionalCharacteristic()
        {
            IsGetAdditionalNoise = false;
            cmbNoiseCharacter.SelectedIndex =
                cmbNoiseCharacter.Items.IndexOf(_map.AdditionalNoiseCharacteristic.NoiseCharacter);
            cmbObjectPlace.SelectedIndex = cmbObjectPlace.Items.IndexOf(_map.AdditionalNoiseCharacteristic.ObjectPlace);
            cmbTimeOfTheDay.SelectedIndex =
                cmbTimeOfTheDay.Items.IndexOf(_map.AdditionalNoiseCharacteristic.TimeOfTheDay);
            cmbRoomType.SelectedIndex =
                cmbRoomType.Items.IndexOf(_map.AdditionalNoiseCharacteristic.RoomType);
            cmbDurationOfExposure.SelectedIndex =
                cmbDurationOfExposure.Items.IndexOf(_map.AdditionalNoiseCharacteristic.DurationOfExposure);
            cmbSummaryDurationOfExposure.SelectedIndex =
                cmbSummaryDurationOfExposure.Items.IndexOf(_map.AdditionalNoiseCharacteristic.SummaryDurationOfExposure);
            cmbInRoom.SelectedIndex = _map.AdditionalNoiseCharacteristic.InRoom ? 1 : 0;
            cmbTableType.SelectedIndex = _map.TableType - 1;
            IsGetAdditionalNoise = true;
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
            InitComboBox();
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
            wbCalc.DocumentText = NoiseHelper.Calc(_map);
            tcMap.SelectTab(tpCalcTable);
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            using (var sd = new SaveFileDialog())
            {
                sd.DefaultExt = "xml";
                sd.Filter = @"Xml Files (*.xml)|*.xml|All Files (*.*)|*.*";
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
                od.Filter = @"Xml Files (*.xml)|*.xml|All Files (*.*)|*.*";
                if (od.ShowDialog(this) == DialogResult.OK)
                {
                    var map = Map.LoadFromFile(od.FileName);
                    InitMap(map);
                }
            }
        }

        private void cmbTableType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsGetAdditionalNoise)
            {
                _map.AdditionalNoiseCharacteristic = GetAdditionalNoiseCharacteristic();
                _map.TableType = cmbTableType.SelectedIndex + 1;
            }
        }

        private AdditionalNoiseCharacteristic GetAdditionalNoiseCharacteristic()
        {
            return new AdditionalNoiseCharacteristic
            {
                InRoom = cmbInRoom.SelectedIndex != 0,
                RoomType = cmbRoomType.SelectedIndex > -1 ? cmbRoomType.SelectedItem.ToString() : string.Empty,
                DurationOfExposure = cmbDurationOfExposure.SelectedIndex > -1 ? cmbDurationOfExposure.SelectedItem.ToString() : string.Empty,
                NoiseCharacter = cmbNoiseCharacter.SelectedIndex > -1 ? cmbNoiseCharacter.SelectedItem.ToString() : string.Empty,
                ObjectPlace = cmbObjectPlace.SelectedIndex > -1 ? cmbObjectPlace.SelectedItem.ToString() : string.Empty,
                SummaryDurationOfExposure = cmbSummaryDurationOfExposure.SelectedIndex > -1 ? cmbSummaryDurationOfExposure.SelectedItem.ToString() : string.Empty,
                TimeOfTheDay = cmbTimeOfTheDay.SelectedIndex > -1 ? cmbTimeOfTheDay.SelectedItem.ToString() : string.Empty
            };
        }
    }
}
