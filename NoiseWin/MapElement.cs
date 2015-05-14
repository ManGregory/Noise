using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseWin
{
    public enum MapElementType
    {
        NoiseSource,
        Partition
    }

    internal abstract class MapElement
    {
        public MapElementType MapElementType { get; set; }
    }
}
