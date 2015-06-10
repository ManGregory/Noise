using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoiseWin
{
    public partial class LinkMapElementsForm : Form
    {
        private MapElement _mapElement;

        public LinkMapElementsForm()
        {
            InitializeComponent();
            lstLinkedElements.SelectionMode = SelectionMode.MultiExtended;
        }

        public LinkMapElementsForm(Map map, MapElement mapElement) : this()
        {            
            _mapElement = mapElement;
            // добавляем в список все элементы, кроме тех, которые уже есть
            var elements = map.MapElements.Where(m => m.MapElementType != mapElement.MapElementType && mapElement.LinkedMapElements.All(m1 => m1.Number != m.Number)).ToList();
            lstLinkedElements.DataSource = elements;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lstLinkedElements.SelectedItems.Count > 2)
            {
                MessageBox.Show("Максимальное количество связанных элементов равно двум");
                return;
            }
            // добавляем источники шума к перегородке
            _mapElement.LinkedMapElements.Clear();
            foreach (var item in lstLinkedElements.SelectedItems)
            {
                _mapElement.LinkedMapElements.Add(item as MapElement);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mapElement.LinkedMapElements.Clear();
            Close();
        }
    }
}
