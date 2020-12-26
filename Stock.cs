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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
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

        private void CustomersPageButton_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
            this.Hide();
        }

        private void DashboardPageButton_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.ShowDialog();
            this.Hide();
        }

        private void AddStockButton_Click(object sender, EventArgs e)
        {
            AddStock addStock = new AddStock();
            addStock.ShowDialog();
            this.Hide();
        }

        private void MakeOrderBtnOnAddCust_Click(object sender, EventArgs e)
        {
            StockOrder stockOrder = new StockOrder();
            stockOrder.ShowDialog();
            this.Hide();
        }
    }
}
