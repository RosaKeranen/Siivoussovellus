using SiivoApp.DTO;
using SiivoApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SiivoApp
{
    public partial class MainForm : Form
    {
        private List<ItemListRow> thrownAway = new List<ItemListRow>();
        private List<ItemListRow> charity = new List<ItemListRow>();
        private List<ItemListRow> sold = new List<ItemListRow>();
        private List<ItemListRow> newPurchase = new List<ItemListRow>();
        private List<ItemListRow> free = new List<ItemListRow>();
        private List<ItemListRow> secondhand = new List<ItemListRow>();
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

            tossedTypeGroupBox.Enabled = false;
            acquiredTypeGroupBox.Enabled = false;
            addButton.Enabled = false;

            // TODO: Täytä listat tiedostoista
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

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

        private void thrownAwayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void charityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void soldRadioButton_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void newPurchaseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void freeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void secondhandPurchaseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (thrownAwayRadioButton.Checked)
            {
                //tähän asian lisäys Heitetty pois -listalle
                thrownAway.Add(new ItemListRow(textBox1.Text));
                MessageBox.Show("Lisäsit asian Heitetty pois -listalle!");
                textBox1.Clear();
            }
            else if (charityRadioButton.Checked)
            {
                //tähän asian lisäys Annettu pois -listalle
                charity.Add(new ItemListRow(textBox1.Text));
                MessageBox.Show("Lisäsit asian Annettu pois -listalle!");
                textBox1.Clear();
            }
            else if (soldRadioButton.Checked)
            {
                //tähän asian lisäys Myyty -listalle
                sold.Add(new ItemListRow(textBox1.Text));
                MessageBox.Show("Lisäsit asian Myyty -listalle!");
                textBox1.Clear();
            }
            else if (newPurchaseRadioButton.Checked)
            {
                //tähän asian lisäys Ostettu uutena -listalle
                newPurchase.Add(new ItemListRow(textBox1.Text));
                MessageBox.Show("Lisäsit asian Ostettu uutena -listalle!");
                textBox1.Clear();
            }
            else if (freeRadioButton.Checked)
            {
                //tähän asian lisäys Saatu ilmaiseksi -listalle
                free.Add(new ItemListRow(textBox1.Text));
                MessageBox.Show("Lisäsit asian Saatu ilmaiseksi -listalle!");
                textBox1.Clear();
            }
            else if (secondhandPurchaseRadioButton.Checked)
            {
                //tähän asian lisäys Ostettu käytettynä -listalle
                secondhand.Add(new ItemListRow(textBox1.Text));
                MessageBox.Show("Lisäsit asian Ostettu käytettynä -listalle!");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Valitse joku vaihtoehto.");
            }
  
            //pois.Add(new ItemListRow(textBox1.Text));

            //var x = new FileHelper();

            //var y = new List<ItemListRow>();

            //x.WriteToFile("lista1.json", y);

        }

        private void viewAcquiredListRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void viewTossedListRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            // Tarkista kumpi radiobutton on valittuna
            if (viewAcquiredListRadioButton.Checked)
            {
                //Tähän kohtaan tietojen tallennus tiedostoon -hommaa?

                // Avaa AcquiredForm, jos viewAcquiredListRadioButton on valittuna
                AcquiredForm form1 = new AcquiredForm();
                form1.Show();
            }
            else if (viewTossedListRadioButton.Checked)
            {
                //Tähän kohtaan tietojen tallennus -hommaa?

                // Avaa TossedForm, jos viewTossedListRadioButton on valittuna
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
