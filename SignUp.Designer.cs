namespace JS
{
    partial class SignUp
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
            this.Loginlink = new System.Windows.Forms.LinkLabel();
            this.Loginlinklabel = new System.Windows.Forms.Label();
            this.SignupButton = new Guna.UI2.WinForms.Guna2Button();
            this.SignupPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignupEmailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Signuptaglinelabel = new System.Windows.Forms.Label();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SignupAccountTypeCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(-6, -20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 491);
            this.panel1.TabIndex = 11;
            // 
            // Logo
            // 
            this.Logo.Image = global::JS.Properties.Resources.madrion;
            this.Logo.Location = new System.Drawing.Point(-137, -30);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(741, 497);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Loginlink
            // 
            this.Loginlink.ActiveLinkColor = System.Drawing.Color.Black;
            this.Loginlink.AutoSize = true;
            this.Loginlink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginlink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.Loginlink.Location = new System.Drawing.Point(674, 412);
            this.Loginlink.Name = "Loginlink";
            this.Loginlink.Size = new System.Drawing.Size(65, 13);
            this.Loginlink.TabIndex = 19;
            this.Loginlink.TabStop = true;
            this.Loginlink.Text = "Log in Here!";
            this.Loginlink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(157)))), ((int)(((byte)(111)))));
            this.Loginlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Loginlink_LinkClicked);
            // 
            // Loginlinklabel
            // 
            this.Loginlinklabel.AutoSize = true;
            this.Loginlinklabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginlinklabel.ForeColor = System.Drawing.Color.DarkGray;
            this.Loginlinklabel.Location = new System.Drawing.Point(491, 411);
            this.Loginlinklabel.Name = "Loginlinklabel";
            this.Loginlinklabel.Size = new System.Drawing.Size(181, 17);
            this.Loginlinklabel.TabIndex = 18;
            this.Loginlinklabel.Text = "Already have an account?\r\n";
            this.Loginlinklabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignupButton
            // 
            this.SignupButton.AutoRoundedCorners = true;
            this.SignupButton.BackColor = System.Drawing.Color.Transparent;
            this.SignupButton.BorderRadius = 21;
            this.SignupButton.CheckedState.Parent = this.SignupButton;
            this.SignupButton.CustomImages.Parent = this.SignupButton;
            this.SignupButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.SignupButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupButton.ForeColor = System.Drawing.Color.White;
            this.SignupButton.HoverState.Parent = this.SignupButton;
            this.SignupButton.Location = new System.Drawing.Point(476, 336);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.SignupButton.ShadowDecoration.BorderRadius = 30;
            this.SignupButton.ShadowDecoration.Depth = 21;
            this.SignupButton.ShadowDecoration.Enabled = true;
            this.SignupButton.ShadowDecoration.Parent = this.SignupButton;
            this.SignupButton.Size = new System.Drawing.Size(275, 45);
            this.SignupButton.TabIndex = 16;
            this.SignupButton.Text = "Register";
            this.SignupButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignupPasswordTextBox
            // 
            this.SignupPasswordTextBox.BorderColor = System.Drawing.Color.White;
            this.SignupPasswordTextBox.BorderRadius = 25;
            this.SignupPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignupPasswordTextBox.DefaultText = "  Password";
            this.SignupPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SignupPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SignupPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignupPasswordTextBox.DisabledState.Parent = this.SignupPasswordTextBox;
            this.SignupPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignupPasswordTextBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.SignupPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupPasswordTextBox.FocusedState.Parent = this.SignupPasswordTextBox;
            this.SignupPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupPasswordTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SignupPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupPasswordTextBox.HoverState.Parent = this.SignupPasswordTextBox;
            this.SignupPasswordTextBox.Location = new System.Drawing.Point(479, 260);
            this.SignupPasswordTextBox.Name = "SignupPasswordTextBox";
            this.SignupPasswordTextBox.PasswordChar = '\0';
            this.SignupPasswordTextBox.PlaceholderText = "";
            this.SignupPasswordTextBox.SelectedText = "";
            this.SignupPasswordTextBox.SelectionStart = 10;
            this.SignupPasswordTextBox.ShadowDecoration.Parent = this.SignupPasswordTextBox;
            this.SignupPasswordTextBox.Size = new System.Drawing.Size(275, 46);
            this.SignupPasswordTextBox.TabIndex = 15;
            this.SignupPasswordTextBox.Enter += new System.EventHandler(this.SignupPasswordTextBox_Enter);
            this.SignupPasswordTextBox.Leave += new System.EventHandler(this.SignupPasswordTextBox_Leave);
            // 
            // SignupEmailTextbox
            // 
            this.SignupEmailTextbox.BorderColor = System.Drawing.Color.White;
            this.SignupEmailTextbox.BorderRadius = 25;
            this.SignupEmailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignupEmailTextbox.DefaultText = "  Email";
            this.SignupEmailTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SignupEmailTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SignupEmailTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignupEmailTextbox.DisabledState.Parent = this.SignupEmailTextbox;
            this.SignupEmailTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignupEmailTextbox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.SignupEmailTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupEmailTextbox.FocusedState.Parent = this.SignupEmailTextbox;
            this.SignupEmailTextbox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupEmailTextbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SignupEmailTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupEmailTextbox.HoverState.Parent = this.SignupEmailTextbox;
            this.SignupEmailTextbox.Location = new System.Drawing.Point(479, 193);
            this.SignupEmailTextbox.Name = "SignupEmailTextbox";
            this.SignupEmailTextbox.PasswordChar = '\0';
            this.SignupEmailTextbox.PlaceholderText = "";
            this.SignupEmailTextbox.SelectedText = "";
            this.SignupEmailTextbox.SelectionStart = 7;
            this.SignupEmailTextbox.ShadowDecoration.Parent = this.SignupEmailTextbox;
            this.SignupEmailTextbox.Size = new System.Drawing.Size(275, 48);
            this.SignupEmailTextbox.TabIndex = 14;
            this.SignupEmailTextbox.Enter += new System.EventHandler(this.SignupEmailTextbox_Enter);
            this.SignupEmailTextbox.Leave += new System.EventHandler(this.SignupEmailTextbox_Leave);
            // 
            // Signuptaglinelabel
            // 
            this.Signuptaglinelabel.AutoSize = true;
            this.Signuptaglinelabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signuptaglinelabel.ForeColor = System.Drawing.Color.DarkGray;
            this.Signuptaglinelabel.Location = new System.Drawing.Point(520, 91);
            this.Signuptaglinelabel.Name = "Signuptaglinelabel";
            this.Signuptaglinelabel.Size = new System.Drawing.Size(194, 96);
            this.Signuptaglinelabel.TabIndex = 13;
            this.Signuptaglinelabel.Text = "Enter your information below\r\n \r\n\r\n\r\n\r\n\r\n";
            this.Signuptaglinelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.Location = new System.Drawing.Point(561, 22);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(117, 36);
            this.SignUpLabel.TabIndex = 12;
            this.SignUpLabel.Text = "Sign up";
            this.SignUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // SignupAccountTypeCombobox
            // 
            this.SignupAccountTypeCombobox.BackColor = System.Drawing.Color.White;
            this.SignupAccountTypeCombobox.BorderColor = System.Drawing.Color.White;
            this.SignupAccountTypeCombobox.BorderRadius = 21;
            this.SignupAccountTypeCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SignupAccountTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SignupAccountTypeCombobox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.SignupAccountTypeCombobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupAccountTypeCombobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignupAccountTypeCombobox.FocusedState.Parent = this.SignupAccountTypeCombobox;
            this.SignupAccountTypeCombobox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupAccountTypeCombobox.ForeColor = System.Drawing.Color.LightGray;
            this.SignupAccountTypeCombobox.HoverState.Parent = this.SignupAccountTypeCombobox;
            this.SignupAccountTypeCombobox.ItemHeight = 30;
            this.SignupAccountTypeCombobox.ItemsAppearance.Parent = this.SignupAccountTypeCombobox;
            this.SignupAccountTypeCombobox.Location = new System.Drawing.Point(480, 139);
            this.SignupAccountTypeCombobox.MinimumSize = new System.Drawing.Size(275, 0);
            this.SignupAccountTypeCombobox.Name = "SignupAccountTypeCombobox";
            this.SignupAccountTypeCombobox.ShadowDecoration.Parent = this.SignupAccountTypeCombobox;
            this.SignupAccountTypeCombobox.Size = new System.Drawing.Size(275, 36);
            this.SignupAccountTypeCombobox.TabIndex = 20;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.SignupAccountTypeCombobox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Loginlink);
            this.Controls.Add(this.Loginlinklabel);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.SignupPasswordTextBox);
            this.Controls.Add(this.SignupEmailTextbox);
            this.Controls.Add(this.Signuptaglinelabel);
            this.Controls.Add(this.SignUpLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.LinkLabel Loginlink;
        private System.Windows.Forms.Label Loginlinklabel;
        private Guna.UI2.WinForms.Guna2Button SignupButton;
        private Guna.UI2.WinForms.Guna2TextBox SignupPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox SignupEmailTextbox;
        private System.Windows.Forms.Label Signuptaglinelabel;
        private System.Windows.Forms.Label SignUpLabel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2ComboBox SignupAccountTypeCombobox;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}