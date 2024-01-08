using SiivoApp.DTO;
using SiivoApp.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SiivoApp
{
    public partial class TossedForm : Form
    {
        private FileHelper fileHelper = new FileHelper();

        private const string thrownAwayListFileName = "thrownAway.json";
        private const string charityListFileName = "charity.json";
        private const string soldListFileName = "sold.json";

        public TossedForm()
        {
            InitializeComponent();

            //Lukee fileHelperin avulla datan tiedostosta, muuntaa sen listBoxia varten ToArray-metodilla arrayksi ja lisää AddRange-metodilla listBoxiin
            thrownAwayListBox.Items.AddRange(fileHelper.ReadFromFile(thrownAwayListFileName).ToArray());
            charityListBox.Items.AddRange(fileHelper.ReadFromFile(charityListFileName).ToArray());
            soldListBox.Items.AddRange(fileHelper.ReadFromFile(soldListFileName).ToArray());

            // Lisää tapahtumankäsittelijät listboxeille
            thrownAwayListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            charityListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            soldListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
        }

        //Updating tehtävä on blokata eventit joita seuraa clearSelected hommista
        bool updating = false;
        // Lisää luokkaan muuttuja, joka säilyttää aikaisemmin valitun indeksin
        private object previouslySelectedObject = null;
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updating) return;

            // Hae valitun listboxin viittaus
            ListBox selectedListBox = (ListBox)sender;

            // Tarkista, onko käyttäjä klikannut samaa kohdetta uudelleen
            if (selectedListBox.SelectedIndex != -1 && selectedListBox.SelectedItem == previouslySelectedObject)
            {
                // Jos kohdetta klikattiin uudelleen, poista valinta
                selectedListBox.ClearSelected();
                previouslySelectedObject = null; // Nollaa muuttuja
            }
            else
            {
                updating = true;
                // Käy läpi kaikki listboxit
                foreach (Control control in Controls)
                {
                    if (control is ListBox listBox && listBox != selectedListBox)
                    {
                        // Tyhjennä valinnat muista listboxeista
                        listBox.ClearSelected();
                    }
                }

                updating = false;
            }

            // Päivitä aikaisemmin valittu indeksi
            previouslySelectedObject = selectedListBox.SelectedItem;
        }

        private void TossedForm_Load(object sender, EventArgs e)
        {
            //thrownAwayListBox.Items.AddRange(thrownAway.ToArray());
            //charityListBox.Items.AddRange(charity.ToArray());
            //soldListBox.Items.AddRange(sold.ToArray());

            UpdateLabelCount();
        }

        public void UpdateLabelCount()
        {
            thrownAwayCountLabel.Text = $"Pois heitettyjä yhteensä: {thrownAwayListBox.Items.Count} kpl";
            charityCountLabel.Text = $"Pois annettuja yhteensä: {charityListBox.Items.Count} kpl";
            soldCountLabel.Text = $"Myytyjä yhteensä: {soldListBox.Items.Count} kpl";
        }

        //Poisto-nappia klikkaamalla käyttäjä voi poistaa yhden asian kerrallaan haluamaltaan listalta.
        //Poistettavia asioita voi valita kerrallaan vain yhden.
        //Valinnan voi tehdä tekemättömäksi klikkaamalla samaa sanaa uudestaan (tai klikkaamalla muualle listboxien alueelle)
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
            else if (charitySelectedIndex > -1)
            {
                //Poistaa charity-boxin valitusta indeksistä
                charityListBox.Items.RemoveAt(charitySelectedIndex);
                //Muuttaa listBoxista tulevan ObjectCollectionin list-muotoon
                List<ItemListRow> charity = new List<ItemListRow>();
                ItemListRow[] array = new ItemListRow[charityListBox.Items.Count];
                charityListBox.Items.CopyTo(array, 0);
                charity.AddRange(array);
                //päivittää tiedoston
                fileHelper.WriteToFile(charityListFileName, charity);
                //päivitä laskuri
                UpdateLabelCount();
            }
            else if (soldSelectedIndex > -1)
            {
                //Poistaa sold-boxin valitusta indeksistä
                soldListBox.Items.RemoveAt(soldSelectedIndex);
                //Muuttaa listBoxista tulevan ObjectCollectionin list-muotoon
                List<ItemListRow> sold = new List<ItemListRow>();
                ItemListRow[] array = new ItemListRow[soldListBox.Items.Count];
                soldListBox.Items.CopyTo(array, 0);
                sold.AddRange(array);
                //päivittää tiedoston
                fileHelper.WriteToFile(soldListFileName, sold);
                //päivitä laskuri
                UpdateLabelCount();
            }

        }
    }
}
