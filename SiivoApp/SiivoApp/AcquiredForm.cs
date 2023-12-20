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
        }
    }
}
