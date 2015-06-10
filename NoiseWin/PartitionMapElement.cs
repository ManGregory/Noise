using System;
using System.ComponentModel;

namespace NoiseWin
{
    /// <summary>
    /// Перегородка
    /// </summary>
    [Serializable]
    public class PartitionMapElement : MapElement
    {
        private double _isolationPower;
        private int _layerCount;

        [DisplayName("Количество слоев")]
        [Category("2. Характеристики ограждающей конструкции")]
        [Description("Количество слоев в ограждающей конструкции")]
        public int LayerCount
        {
            get { return _layerCount; }
            set
            {
                if (value == 1 || value == 2)
                {
                    _layerCount = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("_layerCount", "Количество слоев в ограждающей конструкции должно находиться в диапазоне от 1 до 2");
                }                
            }
        }

        [DisplayName("Звукоизолирующая способность, дБ")]
        [Category("2. Характеристики ограждающей конструкции")]
        [Description("Звукоизолирующая способность, дБ")]
        public double IsolationPower
        {
            get { return _isolationPower; }
            set
            {
                if ((value < -50) || (value > 50))
                {
                    throw new ArgumentOutOfRangeException(
                        "Значение звукоизолирующей способности должно быть в пределах от -50 до 50");
                }
                _isolationPower = value;
            }
        }

        public PartitionMapElement()
        {
            MapElementType = MapElementType.Partition;
            LayerCount = 1;
        }

        /// <summary>
        /// Получение изолирующей способности перегородки с учетом количества слоев
        /// </summary>
        [Browsable(false)]
        public double GetPartitionFullIsolationPower
        {
            get { return IsolationPower*LayerCount; }
        }

        public override string ToString()
        {
            return string.Format("Перегородка № {0} ({1})", Number, Name);
        }
    }
}
