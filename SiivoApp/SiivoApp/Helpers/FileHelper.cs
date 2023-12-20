using Newtonsoft.Json;
using SiivoApp.DTO;
using System.Collections.Generic;
using System.IO;

namespace SiivoApp.Helpers
{
    /// <summary>
    /// FileHelper on luokka, joka kirjoittaa 
    /// ja lukee ItemListRow-tyyppisiä listoja tiedostoon ja tiedostosta.
    /// Listat kirjoitetaan json-formaattiin serialisoituna.
    /// </summary>
    internal class FileHelper
    {
        public FileHelper() { }

        /// <summary>
        /// Tämä ottaa parametrina tiedoston nimen, johon tiedot kirjoitetaan, ja toisena
        /// parametrina tiedoston sisällön. 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="itemListRows"></param>
        public void WriteToFile(string filename, List<ItemListRow> itemListRows) 
        {
            // Tässä avataan filestream tiedostoon, johon lista kirjoitetaan.
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                var writer = new StreamWriter(stream);
                writer.AutoFlush = true;

                // Tässä kohdassa ItemListRow serialisoidaan json-stringiksi ja kirjoitetaan tiedostoon.
                var serializer = new JsonSerializer();
                serializer.Serialize(writer, itemListRows);

            }
        }
        
        /// <summary>
        /// Tämä ottaa parametrina luettavan tiedoston nimen. Tiedosto luetaan ja 
        /// deserialisoidaan listaksi.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public List<ItemListRow> ReadFromFile(string filename)
        {
            List<ItemListRow> thingsList = new List<ItemListRow>();
            
            // Tarkistetaan, löytyykö tiedosto. Jos ei löydy, palautetaan tyhjä lista.
            if (File.Exists(filename) == false)
            {
                return thingsList;
            }

            // Tässä aloitetaan tiedoston luku avaamalla filestream tiedostoon.
            using (var stream = File.OpenRead(filename)) 
            { 
                var reader = new StreamReader(stream);
                var jReader = new JsonTextReader(reader);

                // Tässä deserialisoidaan tiedostosta luettu json-stringi listaksi.
                var serializer = new JsonSerializer();
                thingsList = serializer.Deserialize<List<ItemListRow>>(jReader);
            }

            return thingsList;
        }
    }
}
