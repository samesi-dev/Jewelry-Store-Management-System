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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
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

        private void CrossButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            this.Hide();
        }

        private void CustomerGridView_Click(object sender, EventArgs e)
        {
            CustomerData customerData = new CustomerData();
            customerData.ShowDialog();
            this.Hide();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss"); // for showing date on form.

           
          

            
        }
     


        private void CustomersPageButton_Click(object sender, EventArgs e)
        {
          
        }

        private void DashboardPageButton_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.ShowDialog();
            this.Hide();
        }

        private void StoresPageButton_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
            this.Hide();
        }
    }
}
