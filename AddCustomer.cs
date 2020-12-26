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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {

            Customers customers = new Customers();
            customers.ShowDialog();
            this.Hide();
           
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

        private void DashboardPageButton_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.ShowDialog();
            this.Hide();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void CustomersPageButton_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
            this.Hide();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            CustomerAddedMessageBox customerAddedMessageBox = new CustomerAddedMessageBox();
            customerAddedMessageBox.ShowDialog();
            this.Hide();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
