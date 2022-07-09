namespace ORDERING_SYSTEM
{
    partial class admin_log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_log_in));
            this.login = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.show_pass = new System.Windows.Forms.CheckBox();
            this.forgot = new System.Windows.Forms.LinkLabel();
            this.forgot_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.find_account = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.PictureBox();
            this.forgot_confirmpass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.forgot_firstname = new System.Windows.Forms.TextBox();
            this.forgot_lastname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.forgot_username = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.forgot_password = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.forgot_cancel = new System.Windows.Forms.Button();
            this.forgot_save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.forgot_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirm)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login.ForeColor = System.Drawing.SystemColors.Control;
            this.login.Image = global::ORDERING_SYSTEM.Properties.Resources.login;
            this.login.Location = new System.Drawing.Point(491, 304);
            this.login.MaximumSize = new System.Drawing.Size(250, 30);
            this.login.MinimumSize = new System.Drawing.Size(250, 30);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(250, 30);
            this.login.TabIndex = 4;
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Gray;
            this.username.Location = new System.Drawing.Point(491, 224);
            this.username.MaximumSize = new System.Drawing.Size(250, 26);
            this.username.MinimumSize = new System.Drawing.Size(250, 26);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(250, 26);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(491, 259);
            this.password.MaximumSize = new System.Drawing.Size(250, 26);
            this.password.MinimumSize = new System.Drawing.Size(250, 26);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(250, 26);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // show_pass
            // 
            this.show_pass.Appearance = System.Windows.Forms.Appearance.Button;
            this.show_pass.AutoSize = true;
            this.show_pass.BackColor = System.Drawing.Color.Transparent;
            this.show_pass.FlatAppearance.BorderSize = 0;
            this.show_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_pass.Image = global::ORDERING_SYSTEM.Properties.Resources.icons8_eye_20__1_;
            this.show_pass.Location = new System.Drawing.Point(742, 258);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(26, 26);
            this.show_pass.TabIndex = 6;
            this.show_pass.UseVisualStyleBackColor = false;
            this.show_pass.CheckedChanged += new System.EventHandler(this.show_pass_CheckedChanged);
            // 
            // forgot
            // 
            this.forgot.ActiveLinkColor = System.Drawing.Color.Black;
            this.forgot.AutoSize = true;
            this.forgot.BackColor = System.Drawing.Color.Transparent;
            this.forgot.DisabledLinkColor = System.Drawing.Color.Black;
            this.forgot.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.forgot.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.forgot.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.forgot.Location = new System.Drawing.Point(489, 339);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(174, 16);
            this.forgot.TabIndex = 7;
            this.forgot.TabStop = true;
            this.forgot.Text = "Forgot Username or Password?";
            this.forgot.VisitedLinkColor = System.Drawing.Color.White;
            this.forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgot_LinkClicked);
            // 
            // forgot_panel
            // 
            this.forgot_panel.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.menubg;
            this.forgot_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forgot_panel.Controls.Add(this.panel2);
            this.forgot_panel.Controls.Add(this.find_account);
            this.forgot_panel.Controls.Add(this.confirm);
            this.forgot_panel.Controls.Add(this.forgot_confirmpass);
            this.forgot_panel.Controls.Add(this.label10);
            this.forgot_panel.Controls.Add(this.forgot_firstname);
            this.forgot_panel.Controls.Add(this.forgot_lastname);
            this.forgot_panel.Controls.Add(this.label6);
            this.forgot_panel.Controls.Add(this.label9);
            this.forgot_panel.Controls.Add(this.forgot_username);
            this.forgot_panel.Controls.Add(this.panel5);
            this.forgot_panel.Controls.Add(this.forgot_password);
            this.forgot_panel.Controls.Add(this.label11);
            this.forgot_panel.Controls.Add(this.label13);
            this.forgot_panel.Controls.Add(this.forgot_cancel);
            this.forgot_panel.Controls.Add(this.forgot_save);
            this.forgot_panel.Location = new System.Drawing.Point(61, 63);
            this.forgot_panel.Name = "forgot_panel";
            this.forgot_panel.Size = new System.Drawing.Size(327, 321);
            this.forgot_panel.TabIndex = 18;
            this.forgot_panel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 37);
            this.panel2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "CHANGE USERNAME OR PASSWORD";
            // 
            // find_account
            // 
            this.find_account.BackColor = System.Drawing.Color.CornflowerBlue;
            this.find_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.find_account.FlatAppearance.BorderSize = 0;
            this.find_account.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.find_account.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_account.ForeColor = System.Drawing.Color.White;
            this.find_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.find_account.Location = new System.Drawing.Point(117, 111);
            this.find_account.Name = "find_account";
            this.find_account.Size = new System.Drawing.Size(139, 25);
            this.find_account.TabIndex = 1;
            this.find_account.Text = "FIND ACCOUNT";
            this.find_account.UseVisualStyleBackColor = false;
            this.find_account.Click += new System.EventHandler(this.find_account_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Transparent;
            this.confirm.Location = new System.Drawing.Point(290, 247);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(30, 30);
            this.confirm.TabIndex = 33;
            this.confirm.TabStop = false;
            // 
            // forgot_confirmpass
            // 
            this.forgot_confirmpass.Enabled = false;
            this.forgot_confirmpass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_confirmpass.ForeColor = System.Drawing.Color.Gray;
            this.forgot_confirmpass.Location = new System.Drawing.Point(88, 249);
            this.forgot_confirmpass.Name = "forgot_confirmpass";
            this.forgot_confirmpass.Size = new System.Drawing.Size(200, 26);
            this.forgot_confirmpass.TabIndex = 6;
            this.forgot_confirmpass.Text = "CONFIRM PASSWORD";
            this.forgot_confirmpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.forgot_confirmpass.TextChanged += new System.EventHandler(this.forgot_confirmpass_TextChanged);
            this.forgot_confirmpass.Enter += new System.EventHandler(this.forgot_confirmpass_Enter);
            this.forgot_confirmpass.Leave += new System.EventHandler(this.forgot_confirmpass_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "PASSWORD";
            // 
            // forgot_firstname
            // 
            this.forgot_firstname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_firstname.ForeColor = System.Drawing.Color.Gray;
            this.forgot_firstname.Location = new System.Drawing.Point(89, 47);
            this.forgot_firstname.Name = "forgot_firstname";
            this.forgot_firstname.Size = new System.Drawing.Size(200, 26);
            this.forgot_firstname.TabIndex = 2;
            this.forgot_firstname.Text = "ENTER FIRST NAME";
            this.forgot_firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.forgot_firstname.Enter += new System.EventHandler(this.forgot_firstname_Enter);
            this.forgot_firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.forgot_firstname_KeyPress);
            this.forgot_firstname.Leave += new System.EventHandler(this.forgot_firstname_Leave);
            // 
            // forgot_lastname
            // 
            this.forgot_lastname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_lastname.ForeColor = System.Drawing.Color.Gray;
            this.forgot_lastname.Location = new System.Drawing.Point(89, 79);
            this.forgot_lastname.Name = "forgot_lastname";
            this.forgot_lastname.Size = new System.Drawing.Size(200, 26);
            this.forgot_lastname.TabIndex = 3;
            this.forgot_lastname.Text = "ENTER LAST NAME";
            this.forgot_lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.forgot_lastname.Enter += new System.EventHandler(this.forgot_lastname_Enter);
            this.forgot_lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.forgot_lastname_KeyPress);
            this.forgot_lastname.Leave += new System.EventHandler(this.forgot_lastname_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "LAST NAME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "FIRST NAME";
            // 
            // forgot_username
            // 
            this.forgot_username.Enabled = false;
            this.forgot_username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_username.ForeColor = System.Drawing.Color.Gray;
            this.forgot_username.Location = new System.Drawing.Point(88, 187);
            this.forgot_username.Name = "forgot_username";
            this.forgot_username.Size = new System.Drawing.Size(200, 26);
            this.forgot_username.TabIndex = 4;
            this.forgot_username.Text = "ENTER NEW USERNAME";
            this.forgot_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.forgot_username.Enter += new System.EventHandler(this.forgot_username_Enter);
            this.forgot_username.Leave += new System.EventHandler(this.forgot_username_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 37);
            this.panel5.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(58, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "RECOVER ADMIN ACCOUNT";
            // 
            // forgot_password
            // 
            this.forgot_password.Enabled = false;
            this.forgot_password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password.ForeColor = System.Drawing.Color.Gray;
            this.forgot_password.Location = new System.Drawing.Point(88, 219);
            this.forgot_password.Name = "forgot_password";
            this.forgot_password.Size = new System.Drawing.Size(200, 26);
            this.forgot_password.TabIndex = 5;
            this.forgot_password.Text = "ENTER NEW PASSWORD";
            this.forgot_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.forgot_password.TextChanged += new System.EventHandler(this.forgot_password_TextChanged);
            this.forgot_password.Enter += new System.EventHandler(this.forgot_password_Enter);
            this.forgot_password.Leave += new System.EventHandler(this.forgot_password_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "PASSWORD";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "USERNAME";
            // 
            // forgot_cancel
            // 
            this.forgot_cancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.forgot_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.forgot_cancel.FlatAppearance.BorderSize = 0;
            this.forgot_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forgot_cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_cancel.ForeColor = System.Drawing.Color.White;
            this.forgot_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.forgot_cancel.Location = new System.Drawing.Point(215, 288);
            this.forgot_cancel.Name = "forgot_cancel";
            this.forgot_cancel.Size = new System.Drawing.Size(100, 25);
            this.forgot_cancel.TabIndex = 1;
            this.forgot_cancel.Text = "CANCEL";
            this.forgot_cancel.UseVisualStyleBackColor = false;
            this.forgot_cancel.Click += new System.EventHandler(this.forgot_cancel_Click);
            // 
            // forgot_save
            // 
            this.forgot_save.BackColor = System.Drawing.Color.CornflowerBlue;
            this.forgot_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.forgot_save.Enabled = false;
            this.forgot_save.FlatAppearance.BorderSize = 0;
            this.forgot_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forgot_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_save.ForeColor = System.Drawing.Color.White;
            this.forgot_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.forgot_save.Location = new System.Drawing.Point(13, 288);
            this.forgot_save.Name = "forgot_save";
            this.forgot_save.Size = new System.Drawing.Size(100, 25);
            this.forgot_save.TabIndex = 10;
            this.forgot_save.Text = "SAVE";
            this.forgot_save.UseVisualStyleBackColor = false;
            this.forgot_save.Click += new System.EventHandler(this.forgot_save_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.CornflowerBlue;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(676, 445);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 25);
            this.back.TabIndex = 1;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(447, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "ADMIN LOG IN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // admin_log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.home2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 482);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.forgot_panel);
            this.Controls.Add(this.forgot);
            this.Controls.Add(this.show_pass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admin_log_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_log_in";
            this.forgot_panel.ResumeLayout(false);
            this.forgot_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirm)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox show_pass;
        private System.Windows.Forms.LinkLabel forgot;
        public System.Windows.Forms.Panel forgot_panel;
        public System.Windows.Forms.PictureBox confirm;
        public System.Windows.Forms.TextBox forgot_confirmpass;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox forgot_firstname;
        public System.Windows.Forms.TextBox forgot_lastname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox forgot_username;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox forgot_password;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button forgot_cancel;
        public System.Windows.Forms.Button forgot_save;
        public System.Windows.Forms.Button find_account;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;

    }
}

