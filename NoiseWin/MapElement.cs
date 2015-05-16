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
    public enum MapElementType
    {
        NoiseSource,
        Partition
    }

    internal abstract class MapElement : INotifyPropertyChanged
    {
        public MapElementType MapElementType { get; set; }
        public string Name { get; set; }
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
