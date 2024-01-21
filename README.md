# Sovelluksen toiminta ja käyttötarkoitus
Tervetuloa tutustumaan Siivo-sovellukseeni! 

Sovellukseni on tarkoitettu auttamaan arjen tavarakaaoksen hallinnassa. Sovellukseni kannustaa käyttäjää hankkiutumaan eroon vanhoista tavaroista, joita hän ei enää tarvitse, ja samalla tekemään uusia hankintoja harkitsevaisemmin. 

Sovelluksessani on kolme näkymää: aloitusnäkymä, jossa käyttäjä voi syöttää sovellukseen tietoa, sekä kaksi tarkastelunäkymää, joissa käyttäjä voi tutkia ohjelmaan kirjaamiaan asioita. Sovellukseni luo käyttäjän antamien syötteiden ja valintojen perusteella listoja, joiden avulla käyttäjä voi tarkastella omaa siivous- ja kulutuskäyttäytymistään. Sovelluksesta voi esimerkiksi katsoa, mitä asioita on ostanut, ja tuleeko tavaraa hankittua enemmän uutena vai käytettynä. Omaa toimintaansa voi tarkastella myös sen suhteen, minne pois heitetyt tavarat päätyvät: onko ne heitetty roskiin, annettu pois vai myyty eteenpäin. 

# Vuokaaviot
![Vuokaavio sovelluksen toiminnasta](Screenshots/1_Vuokaavio.JPG)

Vuokaavio, joka näyttää sovelluksen toiminnan, kun käyttäjä lisää syötteen valitsemalleen listalle.

![Vuokaavio sovelluksen toiminnasta](Screenshots/2_Vuokaavio.JPG)

Vuokaavio, joka näyttää sovelluksen toiminnan, kun käyttäjä klikkaa Katso listaa -nappia päänäkymässä.

# Sovelluksen näkymien esittely
![Aloitusnäkymä](Screenshots/1_Aloitusnäkymä.png)

Sovelluksen aloitusnäkymä.


![Aloitusnäkymä, Siivottu-listalle lisäys valittuna](Screenshots/2_Aloitusnäkymä.png)

Käyttäjä valitsee radiobuttoneiden avulla listan, jolle haluaa lisätä jotakin.


![Siivottujen asioiden formin näkymä](Screenshots/3_Siivotut_asiat_formi.png)

Siivotut asiat -formilta pääsee katsomaan poistettujen tavaroiden listoja. 

Listalta voi myös valita asian klikkaamalla sitä ja poistaa sen.


![Hankittujen asioiden formin näkymä](Screenshots/4_Hankitut_asiat_formi.png)

Hankitut asiat -formilta pääsee katsomaan hankittujen tavaroiden listoja. 

Listalta voi myös valita asian klikkaamalla sitä ja poistaa sen.

# Koodin pääkohtien esittely
ItemListRow on luokka, johon lisätään listarivin tiedot:

```
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

```
Listalle tallentaminen:

```
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
```

Listalta lukeminen:

``` 
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
 
``` 
Lisää listalle -napin klikkaus (vain yhdelle listalle lisäys esitelty tässä):

```
  private void addButton_Click(object sender, EventArgs e)
  ...
              if (thrownAwayRadioButton.Checked)
            {
                // Tässä asia lisätään Heitetty pois -listalle
                thrownAway = fileHelper.ReadFromFile(thrownAwayListFileName);
                thrownAway.Add(new ItemListRow(textBox1.Text));
                fileHelper.WriteToFile(thrownAwayListFileName, thrownAway);
                MessageBox.Show("Lisäsit asian Heitetty pois -listalle!");
                textBox1.Clear();
            }
```

Poista listalta -napin klikkaus (vain yhdeltä listalta poistaminen esitelty tässä):

```
 private void deleteTossedButton_Click(object sender, EventArgs e)
 {
     int thrownAwaySelectedIndex = thrownAwayListBox.SelectedIndex;
     int charitySelectedIndex = charityListBox.SelectedIndex;
     int soldSelectedIndex = soldListBox.SelectedIndex;

     if (thrownAwaySelectedIndex > -1)
     {
         //Poistaa thrownAway-boxin valitusta indeksistä
         thrownAwayListBox.Items.RemoveAt(thrownAwaySelectedIndex);
         //Muuttaa listBoxista tulevan ObjectCollectionin list-muotoon
         List<ItemListRow> thrownAway = new List<ItemListRow>();
         ItemListRow[] array = new ItemListRow[thrownAwayListBox.Items.Count];
         thrownAwayListBox.Items.CopyTo(array, 0);
         thrownAway.AddRange(array);
         //päivittää tiedoston
         fileHelper.WriteToFile(thrownAwayListFileName, thrownAway);
         //päivitä laskuri
         UpdateLabelCount();
     }
	 ...
  }
  
``` 

Listojen alla olevien laskurien päivittämien:

```
public void UpdateLabelCount()
   {
      thrownAwayCountLabel.Text = $"Pois heitettyjä yhteensä: {thrownAwayListBox.Items.Count} kpl";
      charityCountLabel.Text = $"Pois annettuja yhteensä: {charityListBox.Items.Count} kpl";
      soldCountLabel.Text = $"Myytyjä yhteensä: {soldListBox.Items.Count} kpl";
   }
``` 
# Jatkokehitysideat
Sovellusta voisi kehittää eteenpäin monella tavalla. 

Sovellukseen voisi tehdä esimerkiksi ominaisuuden, joka kirjaa ylös, paljonko ostoksiin on kulunut rahaa ja paljonko myydyistä tavaroista on tullut rahaa. Kerättyään käyttäjältä nämä tiedot sovellus voisi näyttää kuluneen tai kertyneen rahamäärän listojen tarkastelun yhteydessä. 

Sovelluksesta voisi tehdä käyttäjälle informatiivisemman ja kiinnostavamman esittämällä listojen sisällön esimerkiksi viikko- tai kuukausinäkymissä. Sovellus voisi myös tehdä erilaisia kuvaajia siivous- ja kulutuskäyttäytymisestä eri kuukausina. Tällä hetkellä sovellus näyttää kaikki listoilla olevat asiat vain yhtenä pötkönä eikä ota käyttäjälle näyttäessä huomioon sitä, kuinka pitkän ajan kuluessa lista on kertynyt. 

Sovelluksen karu ulkonäkö vaatisi myös parantelemista.


