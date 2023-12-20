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
        }
    }
}
