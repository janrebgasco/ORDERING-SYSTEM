namespace ORDERING_SYSTEM
{
    partial class cashier_database
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashier_database));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.TextBox();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.add_panel = new System.Windows.Forms.Panel();
            this.confirm = new System.Windows.Forms.PictureBox();
            this.add_confirmpassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cashier_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.add_username = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.add_password = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.add_cancel = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.update_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.search_name = new System.Windows.Forms.Button();
            this.update_pic = new System.Windows.Forms.PictureBox();
            this.update_confirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.update_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.update_username = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Update_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.update_cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.add_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirm)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.update_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_pic)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ORDERING_SYSTEM.Properties.Resources.icons8_search_24;
            this.pictureBox1.Location = new System.Drawing.Point(8, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Gray;
            this.search.Location = new System.Drawing.Point(38, 71);
            this.search.MaximumSize = new System.Drawing.Size(400, 26);
            this.search.MinimumSize = new System.Drawing.Size(400, 26);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(400, 26);
            this.search.TabIndex = 16;
            this.search.Text = "Search Username";
            this.search.Enter += new System.EventHandler(this.search_Enter);
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_KeyPress);
            this.search.Leave += new System.EventHandler(this.search_Leave);
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.AllowUserToResizeColumns = false;
            this.datagrid.AllowUserToResizeRows = false;
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid.EnableHeadersVisualStyles = false;
            this.datagrid.GridColor = System.Drawing.Color.White;
            this.datagrid.Location = new System.Drawing.Point(12, 103);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.RowHeadersWidth = 40;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.datagrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.datagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.datagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.datagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagrid.RowTemplate.Height = 25;
            this.datagrid.Size = new System.Drawing.Size(797, 298);
            this.datagrid.TabIndex = 18;
            this.datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellClick);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(588, 432);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 25);
            this.update.TabIndex = 21;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.delete.Enabled = false;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(694, 432);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 25);
            this.delete.TabIndex = 20;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.Location = new System.Drawing.Point(29, 432);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(170, 25);
            this.add.TabIndex = 19;
            this.add.Text = "CREATE ACCOUNT";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // add_panel
            // 
            this.add_panel.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.menubg;
            this.add_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_panel.Controls.Add(this.confirm);
            this.add_panel.Controls.Add(this.add_confirmpassword);
            this.add_panel.Controls.Add(this.label10);
            this.add_panel.Controls.Add(this.cashier_name);
            this.add_panel.Controls.Add(this.label9);
            this.add_panel.Controls.Add(this.add_username);
            this.add_panel.Controls.Add(this.panel5);
            this.add_panel.Controls.Add(this.add_password);
            this.add_panel.Controls.Add(this.label11);
            this.add_panel.Controls.Add(this.label13);
            this.add_panel.Controls.Add(this.add_cancel);
            this.add_panel.Controls.Add(this.create);
            this.add_panel.Location = new System.Drawing.Point(298, 119);
            this.add_panel.Name = "add_panel";
            this.add_panel.Size = new System.Drawing.Size(327, 265);
            this.add_panel.TabIndex = 22;
            this.add_panel.Visible = false;
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Transparent;
            this.confirm.Location = new System.Drawing.Point(290, 178);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(30, 30);
            this.confirm.TabIndex = 33;
            this.confirm.TabStop = false;
            // 
            // add_confirmpassword
            // 
            this.add_confirmpassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_confirmpassword.ForeColor = System.Drawing.Color.Gray;
            this.add_confirmpassword.Location = new System.Drawing.Point(88, 180);
            this.add_confirmpassword.Name = "add_confirmpassword";
            this.add_confirmpassword.Size = new System.Drawing.Size(200, 26);
            this.add_confirmpassword.TabIndex = 6;
            this.add_confirmpassword.Text = "CONFIRM PASSWORD";
            this.add_confirmpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.add_confirmpassword.TextChanged += new System.EventHandler(this.add_confirmpassword_TextChanged);
            this.add_confirmpassword.Enter += new System.EventHandler(this.add_confirmpassword_Enter);
            this.add_confirmpassword.Leave += new System.EventHandler(this.add_confirmpassword_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "PASSWORD";
            // 
            // cashier_name
            // 
            this.cashier_name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashier_name.ForeColor = System.Drawing.Color.Gray;
            this.cashier_name.Location = new System.Drawing.Point(12, 62);
            this.cashier_name.Name = "cashier_name";
            this.cashier_name.Size = new System.Drawing.Size(303, 26);
            this.cashier_name.TabIndex = 2;
            this.cashier_name.Text = "ENTER CASHIER NAME";
            this.cashier_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cashier_name.Enter += new System.EventHandler(this.cashier_name_Enter);
            this.cashier_name.Leave += new System.EventHandler(this.cashier_name_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "CASHIER NAME";
            // 
            // add_username
            // 
            this.add_username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_username.ForeColor = System.Drawing.Color.Gray;
            this.add_username.Location = new System.Drawing.Point(88, 118);
            this.add_username.Name = "add_username";
            this.add_username.Size = new System.Drawing.Size(200, 26);
            this.add_username.TabIndex = 4;
            this.add_username.Text = "ENTER USERNAME";
            this.add_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.add_username.TextChanged += new System.EventHandler(this.add_username_TextChanged);
            this.add_username.Enter += new System.EventHandler(this.add_username_Enter);
            this.add_username.Leave += new System.EventHandler(this.add_username_Leave);
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
            this.label7.Location = new System.Drawing.Point(93, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "CREATE ACCOUNT";
            // 
            // add_password
            // 
            this.add_password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_password.ForeColor = System.Drawing.Color.Gray;
            this.add_password.Location = new System.Drawing.Point(88, 150);
            this.add_password.Name = "add_password";
            this.add_password.Size = new System.Drawing.Size(200, 26);
            this.add_password.TabIndex = 5;
            this.add_password.Text = "ENTER PASSWORD";
            this.add_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.add_password.TextChanged += new System.EventHandler(this.add_password_TextChanged);
            this.add_password.Enter += new System.EventHandler(this.add_password_Enter);
            this.add_password.Leave += new System.EventHandler(this.add_password_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 153);
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
            this.label13.Location = new System.Drawing.Point(8, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "USERNAME";
            // 
            // add_cancel
            // 
            this.add_cancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.add_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_cancel.FlatAppearance.BorderSize = 0;
            this.add_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cancel.ForeColor = System.Drawing.Color.White;
            this.add_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_cancel.Location = new System.Drawing.Point(215, 226);
            this.add_cancel.Name = "add_cancel";
            this.add_cancel.Size = new System.Drawing.Size(100, 25);
            this.add_cancel.TabIndex = 1;
            this.add_cancel.Text = "CANCEL";
            this.add_cancel.UseVisualStyleBackColor = false;
            this.add_cancel.Click += new System.EventHandler(this.add_cancel_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.CornflowerBlue;
            this.create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.create.FlatAppearance.BorderSize = 0;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.create.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.White;
            this.create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create.Location = new System.Drawing.Point(13, 226);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(100, 25);
            this.create.TabIndex = 10;
            this.create.Text = "CREATE";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 50);
            this.panel1.TabIndex = 23;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.close;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Location = new System.Drawing.Point(787, 10);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 30);
            this.exit.TabIndex = 7;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "CASHIER ACCOUNT";
            // 
            // update_panel
            // 
            this.update_panel.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.menubg;
            this.update_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_panel.Controls.Add(this.panel2);
            this.update_panel.Controls.Add(this.search_name);
            this.update_panel.Controls.Add(this.update_pic);
            this.update_panel.Controls.Add(this.update_confirm);
            this.update_panel.Controls.Add(this.label2);
            this.update_panel.Controls.Add(this.update_name);
            this.update_panel.Controls.Add(this.label3);
            this.update_panel.Controls.Add(this.update_username);
            this.update_panel.Controls.Add(this.panel3);
            this.update_panel.Controls.Add(this.Update_password);
            this.update_panel.Controls.Add(this.label5);
            this.update_panel.Controls.Add(this.label6);
            this.update_panel.Controls.Add(this.update_cancel);
            this.update_panel.Controls.Add(this.save);
            this.update_panel.Location = new System.Drawing.Point(298, 79);
            this.update_panel.Name = "update_panel";
            this.update_panel.Size = new System.Drawing.Size(327, 336);
            this.update_panel.TabIndex = 24;
            this.update_panel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 37);
            this.panel2.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "CHANGE USERNAME OR PASSWORD";
            // 
            // search_name
            // 
            this.search_name.BackColor = System.Drawing.Color.CornflowerBlue;
            this.search_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.search_name.FlatAppearance.BorderSize = 0;
            this.search_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_name.ForeColor = System.Drawing.Color.White;
            this.search_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_name.Location = new System.Drawing.Point(95, 103);
            this.search_name.Name = "search_name";
            this.search_name.Size = new System.Drawing.Size(139, 25);
            this.search_name.TabIndex = 34;
            this.search_name.Text = "FIND ACCOUNT";
            this.search_name.UseVisualStyleBackColor = false;
            this.search_name.Click += new System.EventHandler(this.search_name_Click);
            // 
            // update_pic
            // 
            this.update_pic.BackColor = System.Drawing.Color.Transparent;
            this.update_pic.Location = new System.Drawing.Point(290, 250);
            this.update_pic.Name = "update_pic";
            this.update_pic.Size = new System.Drawing.Size(30, 30);
            this.update_pic.TabIndex = 33;
            this.update_pic.TabStop = false;
            // 
            // update_confirm
            // 
            this.update_confirm.Enabled = false;
            this.update_confirm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_confirm.ForeColor = System.Drawing.Color.Gray;
            this.update_confirm.Location = new System.Drawing.Point(88, 252);
            this.update_confirm.Name = "update_confirm";
            this.update_confirm.Size = new System.Drawing.Size(200, 26);
            this.update_confirm.TabIndex = 6;
            this.update_confirm.Text = "CONFIRM PASSWORD";
            this.update_confirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.update_confirm.TextChanged += new System.EventHandler(this.update_confirm_TextChanged);
            this.update_confirm.Enter += new System.EventHandler(this.update_confirm_Enter);
            this.update_confirm.Leave += new System.EventHandler(this.update_confirm_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "PASSWORD";
            // 
            // update_name
            // 
            this.update_name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_name.ForeColor = System.Drawing.Color.Gray;
            this.update_name.Location = new System.Drawing.Point(12, 62);
            this.update_name.Name = "update_name";
            this.update_name.Size = new System.Drawing.Size(303, 26);
            this.update_name.TabIndex = 2;
            this.update_name.Text = "ENTER CASHIER NAME";
            this.update_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.update_name.Enter += new System.EventHandler(this.update_name_Enter);
            this.update_name.Leave += new System.EventHandler(this.update_name_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "CASHIER NAME";
            // 
            // update_username
            // 
            this.update_username.Enabled = false;
            this.update_username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_username.ForeColor = System.Drawing.Color.Gray;
            this.update_username.Location = new System.Drawing.Point(88, 190);
            this.update_username.Name = "update_username";
            this.update_username.Size = new System.Drawing.Size(200, 26);
            this.update_username.TabIndex = 4;
            this.update_username.Text = "ENTER USERNAME";
            this.update_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.update_username.TextChanged += new System.EventHandler(this.update_username_TextChanged);
            this.update_username.Enter += new System.EventHandler(this.update_username_Enter);
            this.update_username.Leave += new System.EventHandler(this.update_username_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 37);
            this.panel3.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(93, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "UPDATE ACCOUNT";
            // 
            // Update_password
            // 
            this.Update_password.Enabled = false;
            this.Update_password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_password.ForeColor = System.Drawing.Color.Gray;
            this.Update_password.Location = new System.Drawing.Point(88, 222);
            this.Update_password.Name = "Update_password";
            this.Update_password.Size = new System.Drawing.Size(200, 26);
            this.Update_password.TabIndex = 5;
            this.Update_password.Text = "ENTER PASSWORD";
            this.Update_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Update_password.TextChanged += new System.EventHandler(this.Update_password_TextChanged);
            this.Update_password.Enter += new System.EventHandler(this.Update_password_Enter);
            this.Update_password.Leave += new System.EventHandler(this.Update_password_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "PASSWORD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "USERNAME";
            // 
            // update_cancel
            // 
            this.update_cancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.update_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.update_cancel.FlatAppearance.BorderSize = 0;
            this.update_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_cancel.ForeColor = System.Drawing.Color.White;
            this.update_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_cancel.Location = new System.Drawing.Point(215, 298);
            this.update_cancel.Name = "update_cancel";
            this.update_cancel.Size = new System.Drawing.Size(100, 25);
            this.update_cancel.TabIndex = 1;
            this.update_cancel.Text = "CANCEL";
            this.update_cancel.UseVisualStyleBackColor = false;
            this.update_cancel.Click += new System.EventHandler(this.update_cancel_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.CornflowerBlue;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save.Enabled = false;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(13, 298);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 25);
            this.save.TabIndex = 10;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cashier_database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.menubg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 498);
            this.Controls.Add(this.update_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_panel);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cashier_database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cashier_database";
            this.Load += new System.EventHandler(this.cashier_database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.add_panel.ResumeLayout(false);
            this.add_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirm)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.update_panel.ResumeLayout(false);
            this.update_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_pic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox search;
        public System.Windows.Forms.DataGridView datagrid;
        public System.Windows.Forms.Button update;
        public System.Windows.Forms.Button delete;
        public System.Windows.Forms.Button add;
        public System.Windows.Forms.Panel add_panel;
        public System.Windows.Forms.PictureBox confirm;
        public System.Windows.Forms.TextBox add_confirmpassword;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox cashier_name;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox add_username;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox add_password;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button add_cancel;
        public System.Windows.Forms.Button create;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        public System.Windows.Forms.Panel update_panel;
        public System.Windows.Forms.PictureBox update_pic;
        public System.Windows.Forms.TextBox update_confirm;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox update_name;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox update_username;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Update_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button update_cancel;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button search_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
    }
}