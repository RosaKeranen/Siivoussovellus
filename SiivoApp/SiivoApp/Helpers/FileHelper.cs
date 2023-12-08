using SiivoApp.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Newtonsoft.Json

namespace SiivoApp.Helpers
{
    internal class FileHelper
    {
        public FileHelper() { }

        public void WriteToFile(List<ItemListRow> itemListRows) 
        {
            using (var stream = new FileStream("jipJap.json", FileMode.Create))
            {
                //var serializer = new DataContractJsonSerializer(typeof(List<InputItem>));
                //serializer.WriteObject(stream, data);
            }
        }

        //public List<ItemListRow> ReadFromFile()
        //{
        //}
    }
}
