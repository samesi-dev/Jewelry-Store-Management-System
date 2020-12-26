using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace JS
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            StockAddedMessageBox stockAddedMessageBox = new StockAddedMessageBox();
            stockAddedMessageBox.ShowDialog();
            this.Hide();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
            this.Hide();
        }

        private void MakeOrderBtnOnAddCust_Click(object sender, EventArgs e)
        {
            StockOrder stockOrder = new StockOrder();
            stockOrder.ShowDialog();
            this.Hide();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UpdateStock updateStock = new UpdateStock();
            updateStock.ShowDialog();
            this.Hide();
        }

        private void DeleteStockBtn_Click(object sender, EventArgs e)
        {
            DeletedStockRecord deletedStockRecord = new DeletedStockRecord();
            deletedStockRecord.ShowDialog();
            this.Hide();
        }
    }
}
