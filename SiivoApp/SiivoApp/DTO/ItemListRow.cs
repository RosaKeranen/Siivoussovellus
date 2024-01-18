using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiivoApp.DTO
{
    // DTO tarkoittaa tässä Data Transfer Object
    // Serializable tarkoittaa tässä että tämän luokan pystyy sarjoittamaan
    // ItemListRow on luokka, johon lisätään listarivin tiedot
    [Serializable]
    internal class ItemListRow
    {
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }

        public ItemListRow() { }

        public ItemListRow(string Text) {
            this.Text = Text;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
