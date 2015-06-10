using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NoiseWin
{  
    /// <summary>
    /// Карта 
    /// </summary>
    [Serializable]
    public class Map
    {
        private int _tableType;

        /// <summary>
        /// Тип таблицы (2.1 или 2.3)
        /// </summary>
        public int TableType { get { return _tableType; } set { _tableType = value; } }
        /// <summary>
        /// Дополнительные характеристики
        /// </summary>
        public AdditionalNoiseCharacteristic AdditionalNoiseCharacteristic { get; set; }
        /// <summary>
        /// Список элементов карты (источников шума и перегородок)
        /// </summary>
        public BindingList<MapElement> MapElements { get; set; }
        /// <summary>
        /// Размер комнаты
        /// </summary>
        public SizeF RoomSize { get; set; }

        public Map()
        {
            AdditionalNoiseCharacteristic = new AdditionalNoiseCharacteristic();
            TableType = 1;
        }

        /// <summary>
        ///  Сохранение информации в файл
        /// </summary>
        /// <param name="filePath">путь к файлу</param>
        /// <param name="map">карта</param>
        public static void SaveToFile(string filePath, Map map)
        {
            using (var outFile = File.Create(filePath))
            {
                var formatter = new XmlSerializer(typeof (Map),
                    new[]
                    {
                        typeof (BindingList<MapElement>), typeof (MapElement), typeof (NoiseMapElement),
                        typeof (PartitionMapElement)
                    });
                formatter.Serialize(outFile, map);
            }
        }

        /// <summary>
        /// Загрузка карты из файла
        /// </summary>
        /// <param name="filePath">путь к файлу</param>
        /// <returns>Карта-схема</returns>
        public static Map LoadFromFile(string filePath)
        {
            var deserializer = new XmlSerializer(typeof(Map));
            var reader = new StreamReader(filePath);
            object obj = deserializer.Deserialize(reader);
            var map = (Map)obj;
            reader.Close();
            return map;
        }

        public static double CalcDistance(MapElement mapElement1, MapElement mapElement2, SizeF roomSize, Size pixelSize)
        {
            var x1 = (mapElement1.Location.X * roomSize.Width) / pixelSize.Width;
            var y1 = (mapElement1.Location.Y * roomSize.Height) / pixelSize.Height;
            var x2 = (mapElement2.Location.X * roomSize.Width) / pixelSize.Width;
            var y2 = (mapElement2.Location.Y * roomSize.Height) / pixelSize.Height;
            return
                Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) +
                                     Math.Pow(y2 - y1, 2)), 2);
        }
    }
}
