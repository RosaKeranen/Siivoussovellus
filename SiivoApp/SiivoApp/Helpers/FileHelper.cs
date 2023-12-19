using Newtonsoft.Json;
using SiivoApp.DTO;
using System.Collections.Generic;
using System.IO;

namespace SiivoApp.Helpers
{
    internal class FileHelper
    {
        public FileHelper() { }

        public void WriteToFile(string filename, List<ItemListRow> itemListRows) 
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                var writer = new StreamWriter(stream);
                writer.AutoFlush = true;

                var serializer = new JsonSerializer();
                serializer.Serialize(writer, itemListRows);

            }
        }

        public List<ItemListRow> ReadFromFile(string filename)
        {
            List<ItemListRow> thingsList = new List<ItemListRow>();

            if (File.Exists(filename) == false)
            {
                return thingsList;
            }

            using (var stream = File.OpenRead(filename)) 
            { 
                var reader = new StreamReader(stream);
                var jReader = new JsonTextReader(reader);

                var serializer = new JsonSerializer();
                thingsList = serializer.Deserialize<List<ItemListRow>>(jReader);
            }

            return thingsList;
        }
    }
}
