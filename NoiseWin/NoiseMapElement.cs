using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseWin
{
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

    internal static class NoiseHelper
    {
        public static double GetAggregatePower(IEnumerable<double> powerLevels)
        {
            return 10 * Math.Log10(powerLevels.Sum(p => Math.Pow(10, 0.1) * p));
        }

        public static string Calc(IEnumerable<MapElement> mapElements)
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format(""));
            return sb.ToString();
        }

        public static string CreateInputDataTable(IEnumerable<MapElement> mapElements)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<html><body><table border='1'>");
            sb.AppendLine(
                "<tr><td rowspan='2' width='50'>№ источника шума</td><td rowspan='2' width='100'>Расстояние от источника до расчетной точки, м</td><td colspan='8'>Уровни звуковой мощности (дБ) при среднегеометрической частоте, <i>Гц</i></td></tr><tr><td>65</td><td>125</td><td>250</td><td>500</td><td>1000</td><td>2000</td><td>4000</td><td>8000</td></tr>");
            foreach (var elem in mapElements.Cast<NoiseMapElement>())
            {
                sb.AppendLine(
                    string.Format(
                        "<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td>{8}</td><td>{9}</td></tr>",
                        elem.Number, elem.Distance, elem.PowerLevels[0], elem.PowerLevels[1], elem.PowerLevels[2],
                        elem.PowerLevels[3], elem.PowerLevels[4], elem.PowerLevels[5], elem.PowerLevels[6],
                        elem.PowerLevels[7]));
            }
            sb.AppendLine("</table></body></html>");
            return sb.ToString();
        } 
    }
}
