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
        private List<ItemListRow> newPurchase;
        private List<ItemListRow> free;
        private List<ItemListRow> secondhand;

        private FileHelper fileHelper = new FileHelper();

        private const string newPurchaseListFileName = "newPurchase.json";
        private const string freeListFileName = "free.json";
        private const string secondhandListFileName = "secondhand.json";

        public AcquiredForm()
        {
            InitializeComponent();

            newPurchase = fileHelper.ReadFromFile(newPurchaseListFileName);
            free = fileHelper.ReadFromFile(freeListFileName);
            secondhand = fileHelper.ReadFromFile(secondhandListFileName);
        }

        private void AcquiredForm_Load(object sender, EventArgs e)
        {
            newPurchaseListBox.Items.AddRange(newPurchase.ToArray());
            freeListBox.Items.AddRange(free.ToArray());
            secondhandListBox.Items.AddRange(secondhand.ToArray());

            UpdateLabelCount();
        }

        public void UpdateLabelCount()
        {
            newPurchaseCountLabel.Text = $"Uutena ostettuja yhteensä: {newPurchase.Count} kpl";
            freeCountLabel.Text = $"Ilmaiseksi saatuja yhteensä: {free.Count} kpl";
            secondhandCountLabel.Text = $"Käytettynä ostettuja yhteensä: {secondhand.Count} kpl";
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
                newPurchase.RemoveAt(selectedIndex);
                //päivitä tiedosto
                fileHelper.WriteToFile(newPurchaseListFileName, newPurchase);
                //Tyhjennä listBoxin sisältö
                newPurchaseListBox.Items.Clear();
                //Päivitä listBoxin sisältö
                newPurchaseListBox.Items.AddRange(newPurchase.ToArray());
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
