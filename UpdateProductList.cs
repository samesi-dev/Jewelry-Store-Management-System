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
    public partial class UpdateProductList : Form
    {
        public UpdateProductList()
        {
            InitializeComponent();
        }

        private void guna2TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            StockProductList stockProductList = new StockProductList();
            stockProductList.ShowDialog();
            this.Hide();
        }

        private void UpdateCustomerBtn_Click(object sender, EventArgs e)
        {
            UpdateProductListMessageBox updateProductListMessageBox = new UpdateProductListMessageBox();
            updateProductListMessageBox.ShowDialog();
            this.Hide();

        }
    }
}
