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
    public partial class CustomerAddedMessageBox : Form
    {
        public CustomerAddedMessageBox()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            this.Hide();
        }

        private void CustomerAddedMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void AddedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
