using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NoiseWin
{
    [Serializable]
    public class Map
    {
        public BindingList<MapElement> MapElements { get; set; }

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

        public static Map LoadFromFile(string filePath)
        {
            var deserializer = new XmlSerializer(typeof(Map));
            var reader = new StreamReader(filePath);
            object obj = deserializer.Deserialize(reader);
            var map = (Map)obj;
            reader.Close();
            return map;
        }
    }
}
