using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoiseWin
{
    internal static class NoiseHelper
    {
        /// <summary>
        /// table 2.1
        /// </summary>
        public static Dictionary<string, double[]> NormalNoiseLevels21 =
            new Dictionary<string, double[]>
            {
                {"", new []{0.0}},
                {"������ ������� � ����������, ������������ �������", new[] {51.0, 39, 31, 24, 2, 17, 14, 13, 25}},
                {"����� ������� �������, �������� ��������� � ������� ���������� ����������� � ������-����������, ����� ��������� ����� ������ � �����������", new[] {55.0, 44, 35, 29, 25, 22, 20, 18, 30}},
                {"�������� ������ ������� ���������� � ����������, ���������� ���� ���������� �����, ������ ���������, ����� ������� � ����������", new[] {59.0, 48, 40, 34, 20, 27, 25, 23, 35}},
                {"���������� �������, ����������, ��������������� ����������� � �������", new[] {59.0, 48.0, 40, 34, 30, 27, 25, 23, 35}},
                {"������ � ��������� � ������ � ������� ����������, ���������-����, ��������� ���� � ���������� ���� �������, ������ � �����������", new[] {63.0, 52, 45, 39, 24, 32, 30, 28, 40}},
                {"���������� ����� ���������, ��������������� ����������� � ����� ����� (� 2 � �� ����������� �����������), �������� ������ ������������ � ����� ���������, �������� ������� ���������� ����������", new[] {67.0, 57, 49, 44, 40, 37, 35, 33, 45}},
                {"������� ��������� ���������� � ��������� ��������������� ���� � ���������������� �������", new[] {71, 61, 54, 49, 45, 42, 40, 38, 50.0}},
                {"���� ���� � ����������, ��������, ���� ������� � �����������", new[] {75, 66, 59, 54, 40, 47, 45, 43, 55.0}},
                {"�������� ���� ���������, ���������, ������������ ���� ���������� � ��������, �������� ������ ����������� �������� ������������, ��������������", new[] {79.0, 70, 63, 58, 55, 52, 50, 49, 60}}
            };

        /// <summary>
        /// table 2.3
        /// </summary>
        public static Dictionary<string, double[]> NormalNoiseLevels23 =
            new Dictionary<string, double[]>
            {
                {"��������������� ����, ������� ����������� � ������������� ������-����������� �����, ��������� ����������� ��� ������������� ����� � ��������� ����������������� ������, ��������� ������ �������, ������������", new[] {71.0, 61, 54, 49, 45, 42, 40 ,28, 50}},
                {"��������� ���������� (������� �������)", new[] {79.0, 50, 63, 58, 55, 52, 50, 49, 60}},
                {"�������� ���������� � �������������� ����������", new[] {94.0, 87, 82, 78, 75, 73, 71, 70, 80}},
                {"�������� ���������� � �������������� ���������� � ������� ������ �� ��������", new[] {83.0, 74, 68, 63, 60, 57, 55, 54, 65}},
                {"��������� � ������� ����� ������, ������������ ����", new[] {83.0, 74, 68, 63, 60, 57, 55, 54, 65}},
                {"��������� �����������, ��������� ��� ���������� ������ ��������� �������-�������������� ����� (�����������, ������������, ��������� ��������� � �.�.)", new[] {94.0, 87, 82, 78, 75, 73, 71, 70, 80}},
                {"���������� ������� ����� � ���������������� ���������� �� ���������� �����������", new[] {103.0, 96, 91, 88, 85, 83, 81, 80, 90}}                
            };

        // �������� � ����������� � �������� 2.2
        /// <summary>
        /// �������� ����
        /// </summary>
        public static Dictionary<string, double> NoiseCharacter = new Dictionary<string, double>
        {
            {"", 0},
            {"��������������", 0},
            {"��������� ��� ����������", -5}
        }; 

        /// <summary>
        /// �������������� �������
        /// </summary>
        public static Dictionary<string, double> ObjectPlace = new Dictionary<string, double>
        {
            {"", 0},
            {"��������� �����", -5},
            {"����� ������������� ��������� ����� �����", 0},
            {"����� �������� � ������������ ���������", 5}
        }; 

        /// <summary>
        /// ����� �����
        /// </summary>
        public static Dictionary<string, double> TimeOfTheDay = new Dictionary<string, double>
        {
            {"", 0},
            {"���� - � 7 �� 23 �", 10},
            {"���� - � 23 �� 7 �", 0}
        }; 

        /// <summary>
        /// ������������ ����������� ������������ ���� � ������� ����� �� �������� ������ 0.5
        /// </summary>
        public static Dictionary<string, double> DurationOfExposure = new Dictionary<string, double>
        {
            {"", 0},
            {"56-100 %", 0},
            {"18-56 %", 5},
            {"6-18 %", 10},
            {"����� 6", 15}
        };

        /// <summary>
        /// �������� � ������������ � �������� 2.4
        /// </summary>
        public static Dictionary<string, double> SummaryDurationOfExposure = new Dictionary<string, double>
        {
            {"", 0},
            {"�� 4 �� 8 � (�������������)", 0},
            {"�� 1 �� 4 � (�������������)", 6},
            {"�� 0.25 �� 1 � (�������������)", 12},
            {"�� 5 ��� �� 15 ��� (�������������)", 18},
            {"����� 5 ��� (�������������)", 24},
            {"�� 4 �� 8 � (��������� ��� ����������)", -5},
            {"�� 1 �� 4 � (��������� ��� ����������)", 1},
            {"�� 0.25 �� 1 � (��������� ��� ����������)", 7},
            {"�� 5 ��� �� 15 ��� (��������� ��� ����������)", 13},
            {"����� 5 ��� (��������� ��� ����������)", 19}
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableType"></param>
        /// <param name="level"></param>
        /// <param name="roomType"></param>
        /// <returns></returns>
        public static double GetNormalNoiseLevel(int tableType, int level, string roomType)
        {
            var baseLevel = 0.0;
            var normalNoiseLevel = tableType == 1 ? NormalNoiseLevels21 : NormalNoiseLevels23;
            if (normalNoiseLevel.ContainsKey(roomType))
            {
                if ((level >= 0) && (level <= 8))
                {
                    baseLevel = normalNoiseLevel[roomType][level];
                }
            }
            return baseLevel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="addNoise"></param>
        /// <param name="tableType"></param>
        /// <returns></returns>
        private static double GetDelta(AdditionalNoiseCharacteristic addNoise, int tableType)
        {
            return
                (addNoise.InRoom ? -5 : 10) +
                (tableType == 1
                    ? (string.IsNullOrEmpty(addNoise.NoiseCharacter) ? 0 : NoiseCharacter[addNoise.NoiseCharacter]) +
                      (string.IsNullOrEmpty(addNoise.ObjectPlace) ? 0 : ObjectPlace[addNoise.ObjectPlace]) +
                      (string.IsNullOrEmpty(addNoise.TimeOfTheDay) ? 0 : TimeOfTheDay[addNoise.TimeOfTheDay]) +
                      (string.IsNullOrEmpty(addNoise.DurationOfExposure)
                          ? 0
                          : DurationOfExposure[addNoise.DurationOfExposure])
                    : (string.IsNullOrEmpty(addNoise.SummaryDurationOfExposure)
                        ? 0
                        : SummaryDurationOfExposure[addNoise.SummaryDurationOfExposure]));
        }

        /// <summary>
        /// ���������� ���������� ������� � �������� 2.1 � ���������� �� ������� 2.2, ��� �������� 2.3 � ���������� �� ������� 2.4
        /// </summary>
        /// <param name="tableType">��� �������: 1 - 2.1, 2 - 2.3</param>
        /// <param name="level">������� ��������� �������� (�� 0 �� 7, 8 - ������� �����)</param>
        /// <param name="addNoise">�������������� �������������� � ������������ � �������� 2.2</param>
        /// <returns>������� ��������� ��������</returns>
        public static double GetAllowableNoiseLevel(int tableType, int level, AdditionalNoiseCharacteristic addNoise)
        {            
            // formula 2.2
            return GetNormalNoiseLevel(tableType, level, addNoise.RoomType) + GetDelta(addNoise, tableType);
        }

        public static double GetAggregatePower(IEnumerable<double> powerLevels)
        {
            return 10 * Math.Log10(powerLevels.Sum(p => Math.Pow(10, 0.1) * p));
        }

        public static double GetAtmosphericAttenuation(int level, double distance)
        {
            // table 2.5
            var values = new[] { 0, 0.7, 1.5, 3, 6, 12, 24, 48 };
            const int limitDistance = 50;
            return distance < limitDistance ? 0 : values[level];
        }

        // formula 2.3 
        public static double GetPowerInPoint(NoiseMapElement mapElement, int level)
        {
            return
                Math.Round(
                    mapElement.PowerLevels[level] -
                    20*Math.Log10(mapElement.Distance) +
                    10*Math.Log10(2/(4*Math.PI)) -
                    GetAtmosphericAttenuation(level, mapElement.Distance), 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <param name="power"></param>
        /// <param name="allowablePower"></param>
        /// <returns></returns>
        public static double GetRequired(int count, double power, double allowablePower)
        {
            return Math.Round(power - allowablePower + 10*Math.Log10(count), 0);
        }

        /// <summary>
        /// 
        /// </summary>
        public const int MaxDifference = 8;

        public static string Calc(Map map)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<html><body><table border='1'>");
            sb.AppendLine(
                "<tr><td rowspan='2' width='50'>� �.�.</td><td rowspan='2' width='100'>��������, <i>��</i></td><td colspan='8'>������ �������� �������� (��) ��� �������������������� �������, <i>��</i></td></tr><tr><td>65</td><td>125</td><td>250</td><td>500</td><td>1000</td><td>2000</td><td>4000</td><td>8000</td></tr>");
            var number = 1;
            var powerInAllPoints = new List<List<double>>();
            foreach (var elem in map.MapElements.Where(m => m.MapElementType == MapElementType.NoiseSource).Cast<NoiseMapElement>())
            {
                var powerInPoints =
                    Enumerable.Range(0, 8).Select(i => GetPowerInPoint(elem, i)).ToList();                        
                sb.AppendFormat(
                    "<tr><td>{0}</td><td><i>{1}<sub>{0}</sub></i></td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td>{8}</td><td>{9}</td></tr>",
                    number, "L",
                    powerInPoints[0],
                    powerInPoints[1],
                    powerInPoints[2],
                    powerInPoints[3],
                    powerInPoints[4],
                    powerInPoints[5],
                    powerInPoints[6],
                    powerInPoints[7]);
                powerInAllPoints.Add(powerInPoints);
                number++;
            }

            var normalNoiseLevels =
                Enumerable.Range(0, 8)
                    .Select(i => GetNormalNoiseLevel(map.TableType, i, map.AdditionalNoiseCharacteristic.RoomType)).ToList();
            var deltas =
                Enumerable.Range(0, 8).Select(i => GetDelta(map.AdditionalNoiseCharacteristic, map.TableType)).ToList();
            var allowableNoiseLevels =
                Enumerable.Range(0, 8)
                    .Select(i => GetAllowableNoiseLevel(map.TableType, i, map.AdditionalNoiseCharacteristic)).ToList();
            sb.AppendFormat(
                "<tr><td>{0}</td><td><i>{1}<sub>�</sub></i></td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td>{8}</td><td>{9}</td></tr>",
                number, "L", 
                normalNoiseLevels[0], 
                normalNoiseLevels[1], 
                normalNoiseLevels[2], 
                normalNoiseLevels[3], 
                normalNoiseLevels[4], 
                normalNoiseLevels[5], 
                normalNoiseLevels[6], 
                normalNoiseLevels[7]);
            number++;
            sb.AppendFormat(
                "<tr><td>{0}</td><td><i>{1}<sub>�</sub></i></td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td>{8}</td><td>{9}</td></tr>",
                number, "&#916",
                deltas[0],
                deltas[1],
                deltas[2],
                deltas[3],
                deltas[4],
                deltas[5],
                deltas[6],
                deltas[7]);
            number++;
            sb.AppendFormat(
                "<tr><td>{0}</td><td><i>{1}<sub>���</sub></i></td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td>{8}</td><td>{9}</td></tr>",
                number, "L",
                allowableNoiseLevels[0],
                allowableNoiseLevels[1],
                allowableNoiseLevels[2],
                allowableNoiseLevels[3],
                allowableNoiseLevels[4],
                allowableNoiseLevels[5],
                allowableNoiseLevels[6],
                allowableNoiseLevels[7]);
            number++;
            var countHasDiff =
                powerInAllPoints.Count(p => p.Where((p1, i) => allowableNoiseLevels[i] - p1 <= MaxDifference).Any());

            var hasDiff = new List<dynamic>();
            for (int index = 0; index < powerInAllPoints.Count; index++)
            {
                var powers = powerInAllPoints[index];
                if (powers.Where((p1, i) => allowableNoiseLevels[i] - p1 <= MaxDifference).Any())
                {
                    hasDiff.Add(new {Number = index + 1, Powers = powers.Select((p1, i) => GetRequired(countHasDiff, p1, allowableNoiseLevels[i])).ToList()});
                }
            }
            foreach (var elem in hasDiff)
            {
                sb.AppendFormat(
                    "<tr><td>{0}</td><td><i>{1}<sub>{10}</sub></i></td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td>{8}</td><td>{9}</td></tr>",
                    number++, "&#916 L ��.",
                    elem.Powers[0] <= 0 ? "-" : elem.Powers[0],
                    elem.Powers[1] <= 0 ? "-" : elem.Powers[1],
                    elem.Powers[2] <= 0 ? "-" : elem.Powers[1],
                    elem.Powers[3] <= 0 ? "-" : elem.Powers[3],
                    elem.Powers[4] <= 0 ? "-" : elem.Powers[4],
                    elem.Powers[5] <= 0 ? "-" : elem.Powers[5],
                    elem.Powers[6] <= 0 ? "-" : elem.Powers[6],
                    elem.Powers[7] <= 0 ? "-" : elem.Powers[7],
                    elem.Number);
            }
            sb.AppendLine("</table></body></html>");
            return sb.ToString();
        }

        public static string CreateInputDataTable(IEnumerable<MapElement> mapElements)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<html><body><table border='1'>");
            sb.AppendLine(
                "<tr><td rowspan='2' width='50'>� ��������� ����</td><td rowspan='2' width='100'>���������� �� ��������� �� ��������� �����, �</td><td colspan='8'>������ �������� �������� (��) ��� �������������������� �������, <i>��</i></td></tr><tr><td>65</td><td>125</td><td>250</td><td>500</td><td>1000</td><td>2000</td><td>4000</td><td>8000</td></tr>");
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