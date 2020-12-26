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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.ShowDialog();
            this.Hide(); 
        }
         // The code written in leave and enter functions below is for Hint text 
        private void SignUp_Load(object sender, EventArgs e)
        {
            SignupEmailTextbox.Text = "Email";
            SignupPasswordTextBox.Text = "Password";
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void SignupEmailTextbox_Enter(object sender, EventArgs e)
        {
            if (SignupEmailTextbox.Text == "Email")
            {
                SignupEmailTextbox.Text = null;
                SignupEmailTextbox.ForeColor = Color.Black;
            }
        }

        private void SignupEmailTextbox_Leave(object sender, EventArgs e)
        {
            if (SignupEmailTextbox.Text == "")
            {
                SignupEmailTextbox.Text = "Email";
                SignupEmailTextbox.ForeColor = Color.DimGray;
            }
        }

        private void SignupPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (SignupPasswordTextBox.Text == "Password")
            {
                SignupPasswordTextBox.Text = null;
                SignupPasswordTextBox.ForeColor = Color.Black;
            }
        }

        private void SignupPasswordTextBox_Leave(object sender, EventArgs e)
        {

            if (SignupPasswordTextBox.Text == "")
            {
                SignupPasswordTextBox.Text = "Password";
                SignupPasswordTextBox.ForeColor = Color.DimGray;
            }
        }
        // till here.
        private void Loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Hide();
        }
    }
}
