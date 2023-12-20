using SiivoApp.DTO;
using SiivoApp.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SiivoApp
{
    public partial class MainForm : Form
    {
        private List<ItemListRow> thrownAway;
        private List<ItemListRow> charity;
        private List<ItemListRow> sold;
        private List<ItemListRow> newPurchase;
        private List<ItemListRow> free;
        private List<ItemListRow> secondhand;
        private FileHelper fileHelper = new FileHelper();

        private const string thrownAwayListFileName = "thrownAway.json";
        private const string charityListFileName = "charity.json";
        private const string soldListFileName = "sold.json";
        private const string newPurchaseListFileName = "newPurchase.json";
        private const string freeListFileName = "free.json";
        private const string secondhandListFileName = "secondhand.json";

        public MainForm()
        {
            InitializeComponent();

            // Lisää listalle- nappi ja groupBoxit eivät aluksi ole valittavissa
            tossedTypeGroupBox.Enabled = false;
            acquiredTypeGroupBox.Enabled = false;
            addButton.Enabled = false;

        
            thrownAway = fileHelper.ReadFromFile(thrownAwayListFileName);
            charity = fileHelper.ReadFromFile(charityListFileName);
            sold = fileHelper.ReadFromFile(soldListFileName);
            newPurchase = fileHelper.ReadFromFile(newPurchaseListFileName);
            free = fileHelper.ReadFromFile(freeListFileName);
            secondhand = fileHelper.ReadFromFile(secondhandListFileName);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // Jos käyttäjä valitsee Siivottu -radioButtonin, siivousvalintojen groupBox ja Lisää-nappi tulevat aktiivisiksi
        private void tossedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (tossedRadioButton.Checked)
            {
                newPurchaseRadioButton.Checked = false;
                freeRadioButton.Checked = false;
                secondhandPurchaseRadioButton.Checked = false;
                tossedTypeGroupBox.Enabled = true;
                acquiredTypeGroupBox.Enabled = false;
                addButton.Enabled = true;
            }
        }

        // Jos käyttäjä valitsee Hankittu -radioButtonin, ostosvalintojen groupBox ja Lisää-nappi tulevat aktiivisiksi
        private void acquiredRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (acquiredRadioButton.Checked)
            {
                thrownAwayRadioButton.Checked = false;
                charityRadioButton.Checked = false;
                soldRadioButton.Checked = false;
                acquiredTypeGroupBox.Enabled = true;
                tossedTypeGroupBox.Enabled = false;
                addButton.Enabled=true;
            }
        }

        // Tässä klikataan Lisää listalle -nappia
        private void addButton_Click(object sender, EventArgs e)
        {
            if (thrownAwayRadioButton.Checked)
            {
                // Tässä asia lisätään Heitetty pois -listalle
                thrownAway.Add(new ItemListRow(textBox1.Text));
                MessageBox.Show("Lisäsit asian Heitetty pois -listalle!");
                textBox1.Clear();
            }
            else if (charityRadioButton.Checked)
            {
                //Tässä asia lisätään Annettu pois -listalle
                charity.Add(new ItemListRow(textBox1.Text));
                MessageBox.Show("Lisäsit asian Annettu pois -listalle!");
                textBox1.Clear();
            }
            else if (soldRadioButton.Checked)
            {
                //Tässä asia lisätään Myyty -listalle
                sold.Add(new ItemListRow(textBox1.Text));
                MessageBox.Show("Lisäsit asian Myyty -listalle!");
                textBox1.Clear();
            }
            else if (newPurchaseRadioButton.Checked)
            {
                //Tässä asia lisätään Ostettu uutena -listalle
                newPurchase.Add(new ItemListRow(textBox1.Text));
                MessageBox.Show("Lisäsit asian Ostettu uutena -listalle!");
                textBox1.Clear();
            }
            else if (freeRadioButton.Checked)
            {
                //Tässä asia lisätään Saatu ilmaiseksi -listalle
                free.Add(new ItemListRow(textBox1.Text));
                MessageBox.Show("Lisäsit asian Saatu ilmaiseksi -listalle!");
                textBox1.Clear();
            }
            else if (secondhandPurchaseRadioButton.Checked)
            {
                //Tässä asia lisätään Ostettu käytettynä -listalle
                secondhand.Add(new ItemListRow(textBox1.Text));
                MessageBox.Show("Lisäsit asian Ostettu käytettynä -listalle!");
                textBox1.Clear();
            }
            else
            {
                // Jos käyttäjä unohti valita groupBoxista radioButtonin, viesti muistuttaa sitä
                MessageBox.Show("Valitse joku vaihtoehto.");
            }

        }

        private void viewAcquiredListRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void viewTossedListRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Tässä klikataan Katso listaa -nappia
        private void viewButton_Click(object sender, EventArgs e)
        {
            // Tarkistus, kumpi radiobutton on valittuna
            if (viewAcquiredListRadioButton.Checked)
            {
               // Tallentaa listat tässä vaiheessa, jotta käyttäjä näkee ajantasalla olevan tilanteen
                Save();

                // Avaa ormin, jos viewAcquiredListRadioButton on valittuna
                AcquiredForm form1 = new AcquiredForm();
                form1.Show();
            }
            else if (viewTossedListRadioButton.Checked)
            {
                // Tallentaa listat tässä vaiheessa, jotta käyttäjä näkee ajantasalla olevan tilanteen
                Save();

                // Avaa Siivottujen asioiden formin, jos viewTossedListRadioButton on valittuna
                TossedForm form2 = new TossedForm();
                form2.Show();
            }
            else
            {
                // Käyttäjä ei ole valinnut mitään radiobuttonia
                MessageBox.Show("Valitse jokin vaihtoehto ennen kuin jatkat.");
            }
        }

        private void tossedTypeGroupBox_Enter(object sender, EventArgs e)
        {
         
        }

        private void acquiredTypeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void Save()
        {
            //Tietojen tallennus tiedostoon, jokaiselle listalle on oma tiedosto
            fileHelper.WriteToFile(thrownAwayListFileName, thrownAway);
            fileHelper.WriteToFile(charityListFileName, charity);
            fileHelper.WriteToFile(soldListFileName, sold);
            fileHelper.WriteToFile(newPurchaseListFileName, newPurchase);
            fileHelper.WriteToFile(freeListFileName, free);
            fileHelper.WriteToFile(secondhandListFileName, secondhand);
        }
    }
}
