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
    [Serializable]
    public enum MapElementType
    {
        NoiseSource,
        Partition
    }

    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(NoiseMapElement))]
    [System.Xml.Serialization.XmlInclude(typeof(PartitionMapElement))]
    public abstract class MapElement : INotifyPropertyChanged
    {
        [Browsable(false)]
        public MapElementType MapElementType { get; set; }

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
    }
}
