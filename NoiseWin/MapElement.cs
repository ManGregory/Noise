using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NoiseWin.Annotations;

namespace NoiseWin
{
    /// <summary>
    /// Тип элемента
    /// </summary>
    [Serializable]
    public enum MapElementType
    {
        // Источник шума
        NoiseSource,
        // Перегородка
        Partition,
        //
        Point
    }

    /// <summary>
    /// Базовый клас для элементов карты
    /// </summary>
    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(NoiseMapElement))]
    [System.Xml.Serialization.XmlInclude(typeof(PartitionMapElement))]
    [System.Xml.Serialization.XmlInclude(typeof(PointMapElement))]
    public abstract class MapElement : INotifyPropertyChanged
    {
        /// <summary>
        /// Тип элемента
        /// </summary>
        [Browsable(false)]
        public MapElementType MapElementType { get; set; }

        /// <summary>
        /// Расположение на карте
        /// </summary>
        [Browsable(false)]
        public Point Location { get; set; }

        [DisplayName("Название")]
        [Category("1. Общие")]
        public string Name { get; set; }
        [DisplayName("Номер")]
        [Category("1. Общие")]
        [ReadOnly(true)]
        public int Number { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Связанные элементы карты
        /// </summary>
        [Browsable(false)]
        public List<MapElement> LinkedMapElements { get; set; }

        [ReadOnly(true)]
        [Browsable(true)]
        [DisplayName("Связанные элементы")]
        [Category("1. Общие")]
        public string LinkedElements {
            get { return string.Join(", ", LinkedMapElements.Select(s => s.Number.ToString())); }
        }

        protected MapElement()
        {
            LinkedMapElements = new List<MapElement>();
        }
    }
}
