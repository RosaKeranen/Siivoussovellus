using SiivoApp.DTO;
using SiivoApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiivoApp
{
    public partial class AcquiredForm : Form
    {


        private FileHelper fileHelper = new FileHelper();

        private const string newPurchaseListFileName = "newPurchase.json";
        private const string freeListFileName = "free.json";
        private const string secondhandListFileName = "secondhand.json";

        public AcquiredForm()
        {
            InitializeComponent();

            //Lukee fileHelperin avulla datan tiedostosta, muuntaa sen listBoxia varten ToArray-metodilla arrayksi ja lisää AddRange-metodilla listBoxiin
            newPurchaseListBox.Items.AddRange(fileHelper.ReadFromFile(newPurchaseListFileName).ToArray());
            freeListBox.Items.AddRange(fileHelper.ReadFromFile(freeListFileName).ToArray());
            secondhandListBox.Items.AddRange(fileHelper.ReadFromFile(secondhandListFileName).ToArray());

            // Lisää tapahtumankäsittelijät listboxeille
            newPurchaseListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            freeListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            secondhandListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
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

        private void AcquiredForm_Load(object sender, EventArgs e)
        {
            //newPurchaseListBox.Items.AddRange(newPurchase.ToArray());
            //freeListBox.Items.AddRange(free.ToArray());
            //secondhandListBox.Items.AddRange(secondhand.ToArray());

            UpdateLabelCount();
        }

        public void UpdateLabelCount()
        {
            newPurchaseCountLabel.Text = $"Uutena ostettuja yhteensä: {newPurchaseListBox.Items.Count} kpl";
            freeCountLabel.Text = $"Ilmaiseksi saatuja yhteensä: {freeListBox.Items.Count} kpl";
            secondhandCountLabel.Text = $"Käytettynä ostettuja yhteensä: {secondhandListBox.Items.Count} kpl";
        }

        private void newPurchaseCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void acquiredDeleteButton_Click(object sender, EventArgs e)
        {
            //Tässä käyttäjä voisi valita listBoxissa olevia asioita klikkaamalla ja poistaa ne delete-napilla.
            //Käyttäjä voi valita vain yhden asian kerrallaan.
            //Klikkauksen jälkeen ohjelma näyttää viestin: "Haluatko varmasti poistaa?" Viestilaatikoista voi valita kyllä tai ei. No tätä ei ole vielä...
            //Jos käyttäjä klikkaa viestilaatikossa kyllä, valittu asia poistetaan listBoxista ja tiedostosta. Jos klikkaa ei, mitään ei poisteta.

            //If newPurchaseListBox on aktiivisena, silloin tee näin bla bla... else if freeListBox on aktiivisena, tee näin bla...
            //else tee viimeiselle listBoxille myös samat hommat.


            int newPurchaseSelectedIndex = newPurchaseListBox.SelectedIndex;
            int freeSelectedIndex = freeListBox.SelectedIndex;
            int secondhandSelectedIndex = secondhandListBox.SelectedIndex;

            if (newPurchaseSelectedIndex > -1)
            {
                //Poistaa newPurchase-boxin valitusta indeksistä
                newPurchaseListBox.Items.RemoveAt(newPurchaseSelectedIndex);
                //Muuttaa listBoxista tulevan ObjectCollectionin list-muotoon
                List<ItemListRow> newPurchase = new List<ItemListRow>();
                ItemListRow[] array = new ItemListRow[newPurchaseListBox.Items.Count];
                newPurchaseListBox.Items.CopyTo(array, 0);
                newPurchase.AddRange(array);
                //päivittää tiedoston
                fileHelper.WriteToFile(newPurchaseListFileName, newPurchase);
                //päivitä laskuri
                UpdateLabelCount();
            }
            else if (freeSelectedIndex > -1)
            {
                //Poistaa free-boxin valitusta indeksistä
                freeListBox.Items.RemoveAt(freeSelectedIndex);
                //Muuttaa listBoxista tulevan ObjectCollectionin list-muotoon
                List<ItemListRow> free = new List<ItemListRow>();
                ItemListRow[] array = new ItemListRow[freeListBox.Items.Count];
                freeListBox.Items.CopyTo(array, 0);
                free.AddRange(array);
                //päivittää tiedoston
                fileHelper.WriteToFile(freeListFileName, free);
                //päivitä laskuri
                UpdateLabelCount();
            }
            else if (secondhandSelectedIndex > -1)
            {
                //Poistaa secondhand-boxin valitusta indeksistä
                secondhandListBox.Items.RemoveAt(secondhandSelectedIndex);
                //Muuttaa listBoxista tulevan ObjectCollectionin list-muotoon
                List<ItemListRow> secondhand = new List<ItemListRow>();
                ItemListRow[] array = new ItemListRow[secondhandListBox.Items.Count];
                secondhandListBox.Items.CopyTo(array, 0);
                secondhand.AddRange(array);
                //päivittää tiedoston
                fileHelper.WriteToFile(secondhandListFileName, secondhand);
                //päivitä laskuri
                UpdateLabelCount();
            }

        }
    }
}
