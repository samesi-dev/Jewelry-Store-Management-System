namespace JS
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginEmailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Signuplinklabel = new System.Windows.Forms.Label();
            this.Signuplink = new System.Windows.Forms.LinkLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(-8, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 491);
            this.panel1.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Image = global::JS.Properties.Resources.madrion;
            this.Logo.Location = new System.Drawing.Point(-149, -23);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(741, 497);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(561, 22);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(98, 36);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Log in";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(486, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log in with your data that you entered  \r\nduring your registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginEmailTextbox
            // 
            this.loginEmailTextbox.BorderColor = System.Drawing.Color.White;
            this.loginEmailTextbox.BorderRadius = 25;
            this.loginEmailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginEmailTextbox.DefaultText = "  Email";
            this.loginEmailTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginEmailTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginEmailTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginEmailTextbox.DisabledState.Parent = this.loginEmailTextbox;
            this.loginEmailTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginEmailTextbox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.loginEmailTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginEmailTextbox.FocusedState.Parent = this.loginEmailTextbox;
            this.loginEmailTextbox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginEmailTextbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.loginEmailTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginEmailTextbox.HoverState.Parent = this.loginEmailTextbox;
            this.loginEmailTextbox.Location = new System.Drawing.Point(476, 162);
            this.loginEmailTextbox.Name = "loginEmailTextbox";
            this.loginEmailTextbox.PasswordChar = '\0';
            this.loginEmailTextbox.PlaceholderText = "";
            this.loginEmailTextbox.SelectedText = "";
            this.loginEmailTextbox.ShadowDecoration.Parent = this.loginEmailTextbox;
            this.loginEmailTextbox.Size = new System.Drawing.Size(275, 48);
            this.loginEmailTextbox.TabIndex = 5;
            this.loginEmailTextbox.TextChanged += new System.EventHandler(this.loginEmailTextbox_TextChanged);
            this.loginEmailTextbox.Enter += new System.EventHandler(this.loginEmailTextbox_Enter);
            this.loginEmailTextbox.Leave += new System.EventHandler(this.loginEmailTextbox_Leave);
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.BorderColor = System.Drawing.Color.White;
            this.loginPasswordTextBox.BorderRadius = 25;
            this.loginPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginPasswordTextBox.DefaultText = "  Password";
            this.loginPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginPasswordTextBox.DisabledState.Parent = this.loginPasswordTextBox;
            this.loginPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginPasswordTextBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.loginPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginPasswordTextBox.FocusedState.Parent = this.loginPasswordTextBox;
            this.loginPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.loginPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginPasswordTextBox.HoverState.Parent = this.loginPasswordTextBox;
            this.loginPasswordTextBox.Location = new System.Drawing.Point(476, 231);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '\0';
            this.loginPasswordTextBox.PlaceholderText = "";
            this.loginPasswordTextBox.SelectedText = "";
            this.loginPasswordTextBox.ShadowDecoration.Parent = this.loginPasswordTextBox;
            this.loginPasswordTextBox.Size = new System.Drawing.Size(275, 46);
            this.loginPasswordTextBox.TabIndex = 6;
            this.loginPasswordTextBox.TextChanged += new System.EventHandler(this.loginPasswordTextBox_TextChanged);
            this.loginPasswordTextBox.Enter += new System.EventHandler(this.loginPasswordTextBox_Enter);
            this.loginPasswordTextBox.Leave += new System.EventHandler(this.loginPasswordTextBox_Leave);
            // 
            // LoginButton
            // 
            this.LoginButton.AutoRoundedCorners = true;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderRadius = 21;
            this.LoginButton.CheckedState.Parent = this.LoginButton;
            this.LoginButton.CustomImages.Parent = this.LoginButton;
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HoverState.Parent = this.LoginButton;
            this.LoginButton.Location = new System.Drawing.Point(476, 336);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.LoginButton.ShadowDecoration.BorderRadius = 30;
            this.LoginButton.ShadowDecoration.Depth = 21;
            this.LoginButton.ShadowDecoration.Enabled = true;
            this.LoginButton.ShadowDecoration.Parent = this.LoginButton;
            this.LoginButton.Size = new System.Drawing.Size(275, 45);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Let\'s Start!";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.linkLabel1.Location = new System.Drawing.Point(658, 288);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password?";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(157)))), ((int)(((byte)(111)))));
            // 
            // Signuplinklabel
            // 
            this.Signuplinklabel.AutoSize = true;
            this.Signuplinklabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signuplinklabel.ForeColor = System.Drawing.Color.DarkGray;
            this.Signuplinklabel.Location = new System.Drawing.Point(491, 411);
            this.Signuplinklabel.Name = "Signuplinklabel";
            this.Signuplinklabel.Size = new System.Drawing.Size(168, 17);
            this.Signuplinklabel.TabIndex = 9;
            this.Signuplinklabel.Text = "Don\'t have an account?\r\n";
            this.Signuplinklabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Signuplink
            // 
            this.Signuplink.ActiveLinkColor = System.Drawing.Color.Black;
            this.Signuplink.AutoSize = true;
            this.Signuplink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signuplink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.Signuplink.Location = new System.Drawing.Point(658, 413);
            this.Signuplink.Name = "Signuplink";
            this.Signuplink.Size = new System.Drawing.Size(75, 13);
            this.Signuplink.TabIndex = 10;
            this.Signuplink.TabStop = true;
            this.Signuplink.Text = "Register Here!";
            this.Signuplink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(157)))), ((int)(((byte)(111)))));
            this.Signuplink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Signuplink_LinkClicked);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.Signuplink);
            this.Controls.Add(this.Signuplinklabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(this.loginEmailTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox loginPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox loginEmailTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private System.Windows.Forms.LinkLabel Signuplink;
        private System.Windows.Forms.Label Signuplinklabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}