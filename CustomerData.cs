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
    public partial class CustomerData : Form
    {
        public CustomerData()
        {
            InitializeComponent();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DeletePermission  deletePermission = new DeletePermission();
            deletePermission.ShowDialog();
            this.Hide();

        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.ShowDialog();
            this.Hide();
        }
    }
}
