using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JS
{
    public partial class DeletedStockRecord : Form
    {
        public DeletedStockRecord()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            AddStock addStock = new AddStock();
            addStock.ShowDialog();
            this.Hide();
        }

        private void AddedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
