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
    public partial class DeletePermission : Form
    {
        public DeletePermission()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CustomerData customerData = new CustomerData();
            customerData.ShowDialog();
            this.Hide(); 

        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            DeletedLabel deletedLabel = new DeletedLabel();
            deletedLabel.ShowDialog();
            this.Hide();
        }
    }
}
