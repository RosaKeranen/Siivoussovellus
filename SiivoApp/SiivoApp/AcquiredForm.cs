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
            //Klikkauksen jälkeen ohjelma näyttää viestin: "Haluatko varmasti poistaa?" Viestilaatikoista voi valita kyllä tai ei.
            //Jos käyttäjä klikkaa viestilaatikossa kyllä, valittu asia poistetaan listBoxista ja tiedostosta. Jos klikkaa ei, mitään ei poisteta.

            //If newPurchaseListBox on aktiivisena, silloin tee näin bla bla... else if freeListBox on aktiivisena, tee näin bla...
            //else tee viimeiselle listBoxille myös samat hommat.

            int selectedIndex = newPurchaseListBox.SelectedIndex;

            if (selectedIndex >= 0)
            {
                //Poistaa newPurchase-boxin valitusta indeksistä
                newPurchaseListBox.Items.RemoveAt(selectedIndex);
                //Muuttaa listBoxista tulevan ObjectCollectionin list-muotoon
                List<ItemListRow> newPurchase = new List<ItemListRow>();
                ItemListRow[] array = new ItemListRow[newPurchaseListBox.Items.Count];
                newPurchaseListBox.Items.CopyTo(array, 0);
                newPurchase.AddRange(array);
                //päivittää tiedoston
                fileHelper.WriteToFile(newPurchaseListFileName, newPurchase);
                ////Tyhjennä listBoxin sisältö
                //newPurchaseListBox.Items.Clear();
                ////Päivitä listBoxin sisältö
                //newPurchaseListBox.Items.AddRange(newPurchase.ToArray());
                //päivitä laskuri
                UpdateLabelCount();
                
            }

        }

        //private void Save()

        //{
            //Tietojen tallennus tiedostoon, jokaiselle listalle on oma tiedosto
            //fileHelper.WriteToFile(newPurchaseListFileName, newPurchase);
            //fileHelper.WriteToFile(freeListFileName, free);
            //fileHelper.WriteToFile(secondhandListFileName, secondhand);
        //}

        //private void UpdateListBox()
       // {
            //
            //freeListBox.Items.AddRange(free.ToArray());
            //secondhandListBox.Items.AddRange(secondhand.ToArray());
        //}
    }
}
