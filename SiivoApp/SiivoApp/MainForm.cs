﻿using System;
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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tossedRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void acquiredRadioButton_CheckedChanged(object sender, EventArgs e)
        {

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

    }
}
