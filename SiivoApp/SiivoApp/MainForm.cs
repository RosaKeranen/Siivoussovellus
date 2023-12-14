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

        public MainForm()
        {
            InitializeComponent();

            tossedTypeGroupBox.Enabled = false;
            acquiredTypeGroupBox.Enabled = false;
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
            var x = new FileHelper();

            var y = new List<ItemListRow>();
            y.Add(new ItemListRow("roska1"));
            y.Add(new ItemListRow("roska2"));

            x.WriteToFile("lista1.json", y);
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
                // Avaa AcquiredForm, jos viewAcquiredListRadioButton on valittuna
                AcquiredForm form1 = new AcquiredForm();
                form1.Show();
            }
            else if (viewTossedListRadioButton.Checked)
            {
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
    }
}
