using SiivoApp.DTO;
using SiivoApp.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SiivoApp
{
    public partial class TossedForm : Form
    {
        private List<ItemListRow> thrownAway;
        private List<ItemListRow> charity;
        private List<ItemListRow> sold;

        private FileHelper fileHelper = new FileHelper();

        private const string thrownAwayListFileName = "thrownAway.json";
        private const string charityListFileName = "charity.json";
        private const string soldListFileName = "sold.json";

        public TossedForm()
        {
            InitializeComponent();

            thrownAway = fileHelper.ReadFromFile(thrownAwayListFileName);
            charity = fileHelper.ReadFromFile(charityListFileName);
            sold = fileHelper.ReadFromFile(soldListFileName);
        }

        private void TossedForm_Load(object sender, EventArgs e)
        {
            thrownAwayListBox.Items.AddRange(thrownAway.ToArray());
            charityListBox.Items.AddRange(charity.ToArray());
            soldListBox.Items.AddRange(sold.ToArray());

            UpdateLabelCount();
        }

        public void UpdateLabelCount()
        {
            thrownAwayCountLabel.Text = $"Pois heitettyjä yhteensä: {thrownAway.Count} kpl";
            charityCountLabel.Text = $"Pois annettuja yhteensä: {charity.Count} kpl";
            soldCountLabel.Text = $"Myytyjä yhteensä: {sold.Count} kpl";
        }

        private void deleteTossedButton_Click(object sender, EventArgs e)
        {
            //Tässä käyttäjä voisi valita listBoxissa olevia asioita klikkaamalla ja poistaa ne delete-napilla.
            //Käyttäjä voi valita vain yhden asian kerrallaan.
            //Klikkauksen jälkeen ohjelma näyttää viestin: "Haluatko varmasti poistaa?" Viestilaatikoista voi valita kyllä tai ei.
            //Jos käyttäjä klikkaa viestilaatikossa kyllä, valittu asia poistetaan listBoxista ja tiedostosta. Jos klikkaa ei, mitään ei poisteta.
        }
    }
}
