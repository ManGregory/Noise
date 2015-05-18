using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace NoiseWin
{
    /// <summary>
    /// Источник шума
    /// </summary>
    [Serializable]
    public class NoiseMapElement : MapElement
    {
        private double[] _powerLevels;
        [Category("2. Характеристики источника шума")]
        [DisplayName("Уровни звуковой мощности")]
        [Description("Уровни звуковой мощности при среднегеометрической частоте, дБ")]
        public double[] PowerLevels
        {
            get { return _powerLevels; }
            set
            {
                _powerLevels = value;
                OnPropertyChanged();
            }
        }

        [Category("2. Характеристики источника шума")]
        [DisplayName("Расстояние до расчетной точки")]
        [Description("Расстояние до расчетной точки, м")]
        public double Distance { get; set; }

        [Category("2. Характеристики источника шума")]
        [DisplayName("Защитный экран")]        
        [Description("Защитный экран")]
        public bool HasProtection { get; set; }

        public NoiseMapElement()
        {
            MapElementType = MapElementType.NoiseSource;
            _powerLevels = new double[8];
        }

        public override string ToString()
        {
            return string.Format("Источник шума № {0} ({1}), расстояние до РТ {2}", Number, Name, Distance);
        }

        // общий уровень источника шума
        [Browsable(false)]
        public double CommonPower 
        {
            // формула 1.19
            get { return NoiseHelper.GetAggregatePower(PowerLevels); }
        }
    }
}
