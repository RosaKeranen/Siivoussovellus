using SiivoApp.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Newtonsoft.Json

namespace SiivoApp.Helpers
{
    internal class FileHelper
    {
        public FileHelper() { }

        public void WriteToFile(string filename,List<ItemListRow> itemListRows) 
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                var writer = new StreamWriter(stream);
                writer.AutoFlush = true;

                var serializer = new JsonSerializer();
                serializer.Serialize(writer, itemListRows);
                
                //var serializer = new DataContractJsonSerializer(typeof(List<InputItem>));
                //serializer.WriteObject(stream, data);
            }
        }

        //public List<ItemListRow> ReadFromFile()
        //{
        //}
    }
}
