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
    public partial class DeletedProductlistRecordMessageBox : Form
    {
        public DeletedProductlistRecordMessageBox()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            StockProductList stockProductList = new StockProductList();
            stockProductList.ShowDialog();
            this.Hide();
        }

        private void AddedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
