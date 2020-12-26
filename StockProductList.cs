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
    public partial class StockProductList : Form
    {
        public StockProductList()
        {
            InitializeComponent();
        }

     

        private void DoneBtnOnPdtList_Click(object sender, EventArgs e)
        {
            ProductListAddedMessagebox productListAddedMessagebox = new ProductListAddedMessagebox();
            productListAddedMessagebox.ShowDialog();
            this.Hide();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            StockOrder stockOrder = new StockOrder();
            stockOrder.ShowDialog();
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DoneBtnOnStkPdtList_Click(object sender, EventArgs e)
        {
            StockOrder stockorder = new StockOrder();
            stockorder.ShowDialog();
            this.Hide();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            UpdateProductList updateProductList = new UpdateProductList();
            updateProductList.ShowDialog();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DeletedProductlistRecordMessageBox deletedProductlistRecordMessageBox = new DeletedProductlistRecordMessageBox();
            deletedProductlistRecordMessageBox.ShowDialog();
            this.Hide();
        }
    }
}
