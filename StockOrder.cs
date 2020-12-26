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
    public partial class StockOrder : Form
    {
        public StockOrder()
        {
            InitializeComponent();
        }

        private void SignupEmailTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LinkforProductList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockProductList stockproductList = new StockProductList();
            stockproductList.ShowDialog();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 50)
            {
                //Expand the panel , width = 250 
                //Show logo

                panel1.Visible = false;
                panel1.Width = 260;
                PanelTransition.ShowSync(panel1);
                Logo1Transition.ShowSync(logo);

            }
            else
            {
                PanelTransition.Hide(logo);
                panel1.Visible = false;
                panel1.Width = 50;
                PanelTransition.ShowSync(panel1);
            }
        }

        private void DoneBtnForStkOdr_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
            this.Hide();
        }
    }
}
