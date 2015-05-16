using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseWin
{
    class PartitionMapElement : MapElement
    {
        public PartitionMapElement()
        {
            MapElementType = MapElementType.Partition;
        }

        public override string ToString()
        {
            return string.Format("Перегородка № {0} ({1})", Number, Name);
        }
    }
}
