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
    public partial class UpdateStock : Form
    {
        public UpdateStock()
        {
            InitializeComponent();
        }

        private void UpdateStockBtn_Click(object sender, EventArgs e)
        {
            UpdateStockMessageBox updatedMessageBox = new UpdateStockMessageBox();
            updatedMessageBox.ShowDialog();
            this.Hide();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            AddStock addStock = new AddStock();
            addStock.ShowDialog();
            this.Hide();
        }
    }
}
