using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using NoiseWin.Helper;

namespace NoiseWin
{
    public partial class MainForm : Form
    {
        // карта-схема и все дополнительные характеристики
        private readonly Map _map = new Map();
        // флга для корректного добавления характеристик
        private bool _isGetAdditionalNoise = true;

        /// <summary>
        /// Добавление нового элемента в карту-схему
        /// </summary>
        /// <param name="item">Элемент карты (источник шума или перегородка)</param>
        private void AddMapControl(MapElement item)
        {
            // новый элемент, определяем местоположение
            if (item.Location.X == 0 && item.Location.Y == 0)
            {
                item.Location = new Point((_map.MapElements.Count - 1)*50, 0);
            }
            // создаем новую кнопку для добавления на панель
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
            // привязываем обработчики событий
            newMapControl.MouseDown += newMapControl_MouseDown;
            newMapControl.Click += newMapControl_Click;
            // добавляем в обработчик перемещения
            ControlMover.Init(newMapControl, item);
            // обновляем информацию в таблице источиков шума
            BindNoiseList();
        }

        /// <summary>
        /// Обновление информации в таблице источников шума
        /// </summary>
        private void BindNoiseList()
        {
            // получаем все источники шума
            var noiseMapElements = _map.MapElements.Where(m => m.MapElementType == MapElementType.NoiseSource).ToList();
            lstNoiseSources.DataSource = noiseMapElements;            
            // обновляем таблицу в браузере
            wbInputTable.DocumentText = NoiseHelper.CreateInputDataTable(noiseMapElements);
        }

        /// <summary>
        /// Отображение свойств элемента карты в таблице в правой части экрана
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Отображение контекстного меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            pnlMap.Paint += pnlMap_Paint;
            wbInputTable.Navigate("about:blank");
            wbCalc.Navigate("about:blank");
        }

        /// <summary>
        /// Прорисовка связей между элементами карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlMap_Paint(object sender, PaintEventArgs e)
        {            
            var p = sender as Panel;
            var g = e.Graphics;
            g.Clear(p.BackColor);
            foreach (Control control in p.Controls)
            {
                var mapElement = control.Tag as MapElement;
                // обрабатываем только перегородки
                if ((mapElement != null) && (mapElement.MapElementType == MapElementType.Partition))
                {
                    // получаем все кнопки связанные с этой перегородкой
                    var linkedButtons = FindAllLinkedButtons(p, mapElement.LinkedMapElements);
                    foreach (var btn in linkedButtons)
                    {
                        // рисуем линию от середины одной кнопки к середине другой
                        var fromPoint = new Point(control.Left + control.Width/2, control.Top + control.Height/2);
                        var toPoint = new Point(btn.Left + btn.Width/2, btn.Top + btn.Height/2);
                        var pen = new Pen(Color.Black, 2)
                        {
                            CustomEndCap = new AdjustableArrowCap(3, 5),
                            StartCap = LineCap.RoundAnchor
                        };
                        g.DrawLine(pen, fromPoint, toPoint);
                    }
                }
            }
        }

        /// <summary>
        /// Поиск всех связанных кнопок для данного элемента карты
        /// </summary>
        /// <param name="panel">Панель с кнопками</param>
        /// <param name="linkedMapElements">Связанные элементы</param>
        /// <returns>Список связанных кнопок</returns>
        private IEnumerable<Button> FindAllLinkedButtons(Panel panel, List<MapElement> linkedMapElements)
        {
            return (from Control c in panel.Controls
                let element = c.Tag as MapElement
                from mapElement in linkedMapElements
                where
                    element != null && element.MapElementType == MapElementType.NoiseSource &&
                    mapElement.Number == element.Number
                select c as Button).ToList();
        }

        /// <summary>
        /// Инициализация выпадающих списков
        /// </summary>
        private void InitComboBox()
        {
            cmbTableType.Items.Clear();
            cmbInRoom.Items.Clear();
            cmbTableType.Items.AddRange(new object[]{"Таблица 2.1", "Таблица 2.3"});
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

        /// <summary>
        /// Начальная инициализация карты
        /// </summary>
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

        /// <summary>
        /// Инициализация карты при загрузке из файла
        /// </summary>
        /// <param name="map">Карта для загузки</param>
        private void InitMap(Map map)
        {
            // Очистка карты
            ClearMap();
            // Начальная инициализация
            InitMap();
            // Инциализация выпадающих списков
            InitComboBox();
            // Добавление элементов карты
            foreach (var elem in map.MapElements)
            {
                _map.MapElements.Add(elem);
            }
            _map.TableType = map.TableType;
            _map.AdditionalNoiseCharacteristic = map.AdditionalNoiseCharacteristic;
            // Выбор дополнительных характеристик
            SelectAdditionalCharacteristic();
        }

        /// <summary>
        /// Выбор дополнительных характристик необходимых для расчета шума
        /// </summary>
        private void SelectAdditionalCharacteristic()
        {
            _isGetAdditionalNoise = false;
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
            _isGetAdditionalNoise = true;
        }

        /// <summary>
        /// Удаление элемента с карты-схемы
        /// </summary>
        /// <param name="mapElement">Элемент который нужно удалить</param>
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

        /// <summary>
        /// Добавление источника шума
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNoiseSource_Click(object sender, EventArgs e)
        {
            _map.MapElements.Add(new NoiseMapElement
            {
                Number = GetMapElementNumber(MapElementType.NoiseSource)
            });
        }

        /// <summary>
        /// Получение свободного номера для элемента карты
        /// </summary>
        /// <param name="elementType">Тип элемента карты</param>
        /// <returns>Свободный номер</returns>
        private int GetMapElementNumber(MapElementType elementType)
        {
            var number = 1;
            while (true)
            {
                if (_map.MapElements.FirstOrDefault(m => m.Number == number && m.MapElementType == elementType) == null)
                {
                    return number;
                }
                number++;
            }
        }

        /// <summary>
        /// Добавление новой перегородки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPartition_Click(object sender, EventArgs e)
        {
            _map.MapElements.Add(new PartitionMapElement
            {
                Number = GetMapElementNumber(MapElementType.Partition)
            });
        }

        /// <summary>
        /// Удаление элемента с карты-схемы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Обновление информации в таблице "Источники шума"
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void pgMapControl_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            BindNoiseList();
        }

        /// <summary>
        /// Очистка карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearMap_Click(object sender, EventArgs e)
        {
            ClearMap();
            InitComboBox();
        }

        /// <summary>
        /// Очистка карты
        /// </summary>
        private void ClearMap()
        {
            // удаляем все кнопки с карты-схемы
            foreach (var mapElement in _map.MapElements)
            {
                RemoveMapControl(mapElement);
            }
            // очищаем список
            _map.MapElements.Clear();
        }

        /// <summary>
        /// запуск расчета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // расчитываем значения
            wbCalc.DocumentText = NoiseHelper.Calc(_map);
            // выбираем вкладку с расчетами
            tcMap.SelectTab(tpCalcTable);
        }

        /// <summary>
        /// Сохранение карты-схемы и характеристик помщения в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Загрузка карты-схемы и характеристик из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Обновление дополнительных характеристик
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTableType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isGetAdditionalNoise)
            {
                _map.AdditionalNoiseCharacteristic = GetAdditionalNoiseCharacteristic();
                _map.TableType = cmbTableType.SelectedIndex + 1;
            }
        }

        /// <summary>
        /// Формирование дополнительных характеристик из файла
        /// </summary>
        /// <returns></returns>
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

        private void miClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Отображение формы "О программе"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miAbout_Click(object sender, EventArgs e)
        {
            using (var aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog();
            }
        }

        /// <summary>
        /// Обработка контекстного меню перед отображением
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msMapControl_Opening(object sender, CancelEventArgs e)
        {
            var menu = (ContextMenuStrip) sender;
            var btn = (Button)menu.SourceControl;
            if (btn != null)
            {
                var mapElement = btn.Tag as MapElement;
                if (mapElement != null)
                {
                    miLinkElements.Visible = mapElement.MapElementType != MapElementType.NoiseSource;                
                    miLinkElements.Text = mapElement.MapElementType == MapElementType.NoiseSource ? "Связать с перегородками" : "Связать с источниками";
                }
            }
        }

        /// <summary>
        /// Связывание перегородки с источниками шума
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miLinkElements_Click(object sender, EventArgs e)
        {
            var item = (ToolStripItem)sender;
            var menu = (ContextMenuStrip)item.GetCurrentParent();
            var btn = (Button)menu.SourceControl;
            if (btn != null)
            {
                var mapElement = btn.Tag as MapElement;
                using (var linkMapElementsForm = new LinkMapElementsForm(_map, mapElement))
                {
                    linkMapElementsForm.ShowDialog();
                    newMapControl_Click(btn, null);
                }
            }
        }

        /// <summary>
        /// Перерисовка карты-схемы для корректного отображения связей между элементами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlMap.Refresh();
        }
    }
}
