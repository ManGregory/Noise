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

    public class AdditionalNoiseCharacteristic
    {
        public string NoiseCharacter { get; set; }
        public string ObjectPlace { get; set; }
        public string TimeOfTheDay { get; set; }
        public string DurationOfExposure { get; set; }
        public string SummaryDurationOfExposure { get; set; }
    }

    internal static class NoiseHelper
    {
        /// <summary>
        /// table 2.1
        /// </summary>
        public static Dictionary<string, double[]> NormalNoiseLevels21 =
            new Dictionary<string, double[]>
            {
                {"Палаты больниц и санаториев, операционные больниц", new[] {51.0, 39, 31, 24, 2, 17, 14, 13, 25}},
                {"Жилые комнаты квартир, спальные помещения в детских дошкольных учреждениях и школах-интернатах, жилые помещения домов отдыха и пансионатов", new[] {55.0, 44, 35, 29, 25, 22, 20, 18, 30}},
                {"Кабинеты врачей больниц санаториев и поликлиник, зрительные залы концертных залов, номера гостинниц, жилые комнаты в общежитиях", new[] {59.0, 48, 40, 34, 20, 27, 25, 23, 35}},
                {"Территории больниц, санаториев, непосредственно прилегающие к зданиям", new[] {59.0, 48.0, 40, 34, 30, 27, 25, 23, 35}},
                {"Классы и аудитории в школах и учебных заведениях, конференц-залы, читальные залы и зрительные залы театров, клубов и кинотеатров", new[] {63.0, 52, 45, 39, 24, 32, 30, 28, 40}},
                {"Территории жилой застройки, непосредственно прилегающие к жилым домам (в 2 м от ограждающих конструкций), площадки отдыха микрорайонов и жилых кварталов, площадки детских дошкольных учреждений", new[] {67.0, 57, 49, 44, 40, 37, 35, 33, 45}},
                {"Рабочие помещения управлений и помещения конструкторских бюро в административных зданиях", new[] {71, 61, 54, 49, 45, 42, 40, 38, 50.0}},
                {"Залы кафе и ресторанов, столовые, фойе театров и кинотеатров", new[] {75, 66, 59, 54, 40, 47, 45, 43, 55.0}},
                {"Торговые залы магазинов, спортзалы, пассажирские залы аэропортов и вокзалов, приемные пункты предприятий бытового обслуживания, парикмахерские", new[] {79.0, 70, 63, 58, 55, 52, 50, 49, 60}}
            };

        /// <summary>
        /// table 2.3
        /// </summary>
        public static Dictionary<string, double[]> NormalNoiseLevels23 =
            new Dictionary<string, double[]>
            {
                {"Конструкторские бюро, комнаты расчетчиков и программистов счетно-электронных машин, помещения лабораторий для теоретических работ и обработки экспериментальных данных, помещения приема больных, здравпунктов", new[] {71.0, 61, 54, 49, 45, 42, 40 ,28, 50}},
                {"Помещения управлений (рабочие комнаты)", new[] {79.0, 50, 63, 58, 55, 52, 50, 49, 60}},
                {"Кабинеты наблюдения и дистанционного управления", new[] {94.0, 87, 82, 78, 75, 73, 71, 70, 80}},
                {"Кабинеты наблюдения и дистанционного управления с речевой связью по телефону", new[] {83.0, 74, 68, 63, 60, 57, 55, 54, 65}},
                {"Помещения и участки точно сборки, машинописные бюро", new[] {83.0, 74, 68, 63, 60, 57, 55, 54, 65}},
                {"Помещения лабораторий, помещения для размещения шумных агрегатов счетноо-вычислительных машин (табуляторов, перфораторов, магнитных барабанов и т.п.)", new[] {94.0, 87, 82, 78, 75, 73, 71, 70, 80}},
                {"Постоянные рабочие места в производственных помещениях на территории предприятий", new[] {103.0, 96, 91, 88, 85, 83, 81, 80, 90}}                
            };

        // поправки в соотвествии с таблицей 2.2
        /// <summary>
        /// Характер шума
        /// </summary>
        public static Dictionary<string, double> NoiseCharacter = new Dictionary<string, double>
        {
            {"Широкополсный", 0},
            {"Таональный или импульсный", -5}
        }; 

        /// <summary>
        /// Местоположение объекта
        /// </summary>
        public static Dictionary<string, double> ObjectPlace = new Dictionary<string, double>
        {
            {"Курортный район", -5},
            {"Новый проектируемый городской жилой район", 0},
            {"Жилая застрйка в существующей застройке", 5}
        }; 

        /// <summary>
        /// Время суток
        /// </summary>
        public static Dictionary<string, double> TimeOfTheDay = new Dictionary<string, double>
        {
            {"День - с 7 до 23 ч", 10},
            {"Ночь - с 23 до 7 ч", 0}
        }; 

        /// <summary>
        /// Длительность воздействия прерывистого шума в дневное время за наиболее шумные 0.5
        /// </summary>
        public static Dictionary<string, double> DurationOfExposure = new Dictionary<string, double>
        {
            {"56-100 %", 0},
            {"18-56 %", 5},
            {"6-18 %", 10},
            {"Менее 6", 15}
        };

        /// <summary>
        /// Поправки в соответствии с таблицей 2.4
        /// </summary>
        public static Dictionary<string, double> SummaryTimeOfExposure = new Dictionary<string, double>
        {
            {"От 4 до 8 ч (широкополсный)", 0},
            {"От 1 до 4 ч (широкополсный)", 6},
            {"От 0.25 до 1 ч (широкополсный)", 12},
            {"От 5 мин до 15 мин (широкополсный)", 18},
            {"Менее 5 мин (широкополсный)", 24},
            {"От 4 до 8 ч (тональный или импульсный)", -5},
            {"От 1 до 4 ч (тональный или импульсный)", 1},
            {"От 0.25 до 1 ч (тональный или импульсный)", 7},
            {"От 5 мин до 15 мин (тональный или импульсный)", 13},
            {"Менее 5 мин (тональный или импульсный)", 19}
        };

        /// <summary>
        /// Возвращает допустимый уровень с таблицей 2.1 и поправками из таблицы 2.2, или таблицей 2.3 и поправками из таблицы 2.4
        /// </summary>
        /// <param name="tableType">Тип таблицы: 1 - 2.1, 2 - 2.3</param>
        /// <param name="roomType">Тип территории или помещения из таблицы 2.1</param>
        /// <param name="level">Уровень звукового давления (от 0 до 7, 8 - уровень звука)</param>
        /// <param name="inRoom">Примечание 1 к таблице 2.1, true - deltap = -5, false - deltap = +10</param>
        /// <param name="addNoise">Дополнительные характеристики в соответствии с таблицей 2.2</param>
        /// <returns>Уровень звукового давления</returns>
        public static double GetNormalNoiseLevel(int tableType, string roomType, int level, bool inRoom, AdditionalNoiseCharacteristic addNoise)
        {
            var baseLevel = 0.0;
            var delta = 0.0;
            if (tableType == 1)
            {
                if (NormalNoiseLevels21.ContainsKey(roomType))
                {
                    if ((level >= 0) && (level <= 8))
                    {
                        baseLevel = NormalNoiseLevels21[roomType][level];
                    }
                }
                delta =
                    (inRoom ? -5 : 10) +
                    (string.IsNullOrEmpty(addNoise.NoiseCharacter) ? 0 : NoiseCharacter[addNoise.NoiseCharacter]) +
                    (string.IsNullOrEmpty(addNoise.ObjectPlace) ? 0 : ObjectPlace[addNoise.ObjectPlace]) +
                    (string.IsNullOrEmpty(addNoise.TimeOfTheDay) ? 0 : TimeOfTheDay[addNoise.TimeOfTheDay]) +
                    (string.IsNullOrEmpty(addNoise.DurationOfExposure) ? 0 : DurationOfExposure[addNoise.DurationOfExposure]);
            }
            else if (tableType == 2)
            {
                if (NormalNoiseLevels23.ContainsKey(roomType))
                {
                    if ((level >= 0) && (level <= 8))
                    {
                        baseLevel = NormalNoiseLevels23[roomType][level];
                    }
                }
                delta =
                    (inRoom ? -5 : 10) +
                    (string.IsNullOrEmpty(addNoise.SummaryDurationOfExposure) ? 0 : SummaryTimeOfExposure[addNoise.SummaryDurationOfExposure]);
            }
            // formula 2.2
            return baseLevel + delta;
        }

        public static double GetAggregatePower(IEnumerable<double> powerLevels)
        {
            return 10 * Math.Log10(powerLevels.Sum(p => Math.Pow(10, 0.1) * p));
        }

        // formula 2.3 
        public static double GetPowerInPoint(NoiseMapElement mapElement, int level)
        {
            return
                mapElement.PowerLevels[level] -
                20*Math.Log10(mapElement.Distance) +
                10*Math.Log10(2/4*Math.PI) -
                GetAtmosphericAttenuation(level, mapElement.Distance);
        }

        public static double GetAtmosphericAttenuation(int level, double distance)
        {
            // table 2.5
            var values = new[] {0, 0.7, 1.5, 3, 6, 12, 24, 48};
            const int limitDistance = 50;
            return distance < limitDistance ? 0 : values[level];
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
