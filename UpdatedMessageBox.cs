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
    public partial class UpdatedMessageBox : Form
    {
        public UpdatedMessageBox()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            CustomerData Customerdata = new CustomerData();
            Customerdata.ShowDialog();
            this.Hide();
        }

        private void UpdatedMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
