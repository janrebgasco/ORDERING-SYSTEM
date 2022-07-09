namespace ORDERING_SYSTEM
{
    partial class cashier_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashier_form));
            this.forgot = new System.Windows.Forms.LinkLabel();
            this.show_pass = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.forgot_panel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.record = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel5.SuspendLayout();
            this.forgot_panel.SuspendLayout();
            this.SuspendLayout();
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
            this.forgot.Location = new System.Drawing.Point(551, 330);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(174, 16);
            this.forgot.TabIndex = 12;
            this.forgot.TabStop = true;
            this.forgot.Text = "Forgot Username or Password?";
            this.forgot.VisitedLinkColor = System.Drawing.Color.White;
            this.forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgot_LinkClicked);
            // 
            // show_pass
            // 
            this.show_pass.Appearance = System.Windows.Forms.Appearance.Button;
            this.show_pass.AutoSize = true;
            this.show_pass.BackColor = System.Drawing.Color.Transparent;
            this.show_pass.FlatAppearance.BorderSize = 0;
            this.show_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_pass.Image = global::ORDERING_SYSTEM.Properties.Resources.icons8_eye_20__1_;
            this.show_pass.Location = new System.Drawing.Point(804, 249);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(26, 26);
            this.show_pass.TabIndex = 11;
            this.show_pass.UseVisualStyleBackColor = false;
            this.show_pass.CheckedChanged += new System.EventHandler(this.show_pass_CheckedChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(553, 250);
            this.password.MaximumSize = new System.Drawing.Size(250, 26);
            this.password.MinimumSize = new System.Drawing.Size(250, 26);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(250, 26);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
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
            this.login.Location = new System.Drawing.Point(553, 295);
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
            this.username.Location = new System.Drawing.Point(553, 215);
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(479, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "CASHIER LOG IN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.close;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Location = new System.Drawing.Point(815, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 30);
            this.exit.TabIndex = 1;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.CornflowerBlue;
            this.create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.create.FlatAppearance.BorderSize = 0;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.create.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.White;
            this.create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create.Location = new System.Drawing.Point(573, 361);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(213, 25);
            this.create.TabIndex = 16;
            this.create.Text = "CREATE ACCOUNT";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.back_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 37);
            this.panel5.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.close;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(294, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(69, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "LOG IN ADMIN ACCOUNT";
            // 
            // forgot_panel
            // 
            this.forgot_panel.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.menubg;
            this.forgot_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forgot_panel.Controls.Add(this.checkBox1);
            this.forgot_panel.Controls.Add(this.panel5);
            this.forgot_panel.Controls.Add(this.textBox1);
            this.forgot_panel.Controls.Add(this.button1);
            this.forgot_panel.Controls.Add(this.textBox2);
            this.forgot_panel.Location = new System.Drawing.Point(69, 98);
            this.forgot_panel.Name = "forgot_panel";
            this.forgot_panel.Size = new System.Drawing.Size(327, 177);
            this.forgot_panel.TabIndex = 19;
            this.forgot_panel.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Image = global::ORDERING_SYSTEM.Properties.Resources.icons8_eye_20__1_;
            this.checkBox1.Location = new System.Drawing.Point(284, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(26, 26);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(33, 87);
            this.textBox1.MaximumSize = new System.Drawing.Size(250, 26);
            this.textBox1.MinimumSize = new System.Drawing.Size(250, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Password";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::ORDERING_SYSTEM.Properties.Resources.login;
            this.button1.Location = new System.Drawing.Point(33, 132);
            this.button1.MaximumSize = new System.Drawing.Size(250, 30);
            this.button1.MinimumSize = new System.Drawing.Size(250, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 30);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(33, 54);
            this.textBox2.MaximumSize = new System.Drawing.Size(250, 26);
            this.textBox2.MinimumSize = new System.Drawing.Size(250, 26);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Username";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // record
            // 
            this.record.BackColor = System.Drawing.Color.CornflowerBlue;
            this.record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.record.FlatAppearance.BorderSize = 0;
            this.record.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.record.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record.ForeColor = System.Drawing.Color.White;
            this.record.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.record.Location = new System.Drawing.Point(573, 392);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(213, 25);
            this.record.TabIndex = 20;
            this.record.Text = "CASHIER LOG IN RECORD";
            this.record.UseVisualStyleBackColor = false;
            this.record.Click += new System.EventHandler(this.record_Click);
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.time.Location = new System.Drawing.Point(607, 33);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(232, 28);
            this.time.TabIndex = 65;
            this.time.Text = "TIME";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.date.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.date.Location = new System.Drawing.Point(607, 65);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(232, 28);
            this.date.TabIndex = 64;
            this.date.Text = "DATE";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cashier_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.home2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 478);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.record);
            this.Controls.Add(this.forgot_panel);
            this.Controls.Add(this.create);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forgot);
            this.Controls.Add(this.show_pass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cashier_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cashier_form";
            this.Load += new System.EventHandler(this.cashier_form_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.forgot_panel.ResumeLayout(false);
            this.forgot_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel forgot;
        private System.Windows.Forms.CheckBox show_pass;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        public System.Windows.Forms.Button create;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Panel forgot_panel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button record;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer timer;
    }
}