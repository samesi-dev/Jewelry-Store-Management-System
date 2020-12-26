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
    public partial class UpdateStockMessageBox : Form
    {
        public UpdateStockMessageBox()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            UpdateStock updateStock = new UpdateStock();
            updateStock.ShowDialog();
            this.Hide();
        }

        private void AddedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
