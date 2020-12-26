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
    public partial class LogIn : Form
    {
        public LogIn()
        {
          
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

           
                       
            MAIN main = new MAIN();
            main.ShowDialog();
            this.Hide();
                       


        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            loginEmailTextbox.Text = "Email";
            loginPasswordTextBox.Text ="Password";

        }

        private void loginEmailTextbox_TextChanged(object sender, EventArgs e)
        {
         

            
        }

        private void loginPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        // The code written in leave and enter functions below is for Hint text 
        private void loginEmailTextbox_Leave(object sender, EventArgs e)
        {
            if (loginEmailTextbox.Text == "")
            {
                loginEmailTextbox.Text = "Email";
                loginEmailTextbox.ForeColor = Color.DimGray;
            }
        }

        private void loginPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (loginPasswordTextBox.Text == "")
            {
                loginPasswordTextBox.Text = "Password";
                loginPasswordTextBox.ForeColor = Color.DimGray;
            }
        }

        private void loginEmailTextbox_Enter(object sender, EventArgs e)
        { if(loginEmailTextbox.Text == "Email")
            {
                loginEmailTextbox.Text = null;
                loginEmailTextbox.ForeColor = Color.DimGray;
            }
        }

        private void loginPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if ( loginPasswordTextBox.Text == "Password")
            {
                loginPasswordTextBox.Text = null;
                loginPasswordTextBox.ForeColor = Color.DimGray;
            }
        }
        // till here.
        private void Signuplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Hide();
        }
    }
}
