namespace ORDERING_SYSTEM
{
    partial class menu_database
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_database));
            this.orderingsystemdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordering_system_databaseDataSet = new ORDERING_SYSTEM.ordering_system_databaseDataSet();
            this.search = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu_datagrid = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.soup = new System.Windows.Forms.Button();
            this.rice = new System.Windows.Forms.Button();
            this.porkchic = new System.Windows.Forms.Button();
            this.seafood = new System.Windows.Forms.Button();
            this.vegetables = new System.Windows.Forms.Button();
            this.noodles = new System.Windows.Forms.Button();
            this.drinks = new System.Windows.Forms.Button();
            this.categories = new System.Windows.Forms.Label();
            this.add_panel = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.menu_picture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.order_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.add_menu = new System.Windows.Forms.Label();
            this.update_panel = new System.Windows.Forms.Panel();
            this.update_price = new System.Windows.Forms.Label();
            this.update_quantity = new System.Windows.Forms.Label();
            this.update_ordername = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.new_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.new_quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.new_ordername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.new_browse = new System.Windows.Forms.Button();
            this.new_update_pic = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.update_cancel = new System.Windows.Forms.Button();
            this.new_update = new System.Windows.Forms.Button();
            this.update_pic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_update = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderingsystemdatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordering_system_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_datagrid)).BeginInit();
            this.add_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_picture)).BeginInit();
            this.panel5.SuspendLayout();
            this.update_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.new_update_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_pic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderingsystemdatabaseDataSetBindingSource
            // 
            this.orderingsystemdatabaseDataSetBindingSource.DataSource = this.ordering_system_databaseDataSet;
            this.orderingsystemdatabaseDataSetBindingSource.Position = 0;
            // 
            // ordering_system_databaseDataSet
            // 
            this.ordering_system_databaseDataSet.DataSetName = "ordering_system_databaseDataSet";
            this.ordering_system_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Gray;
            this.search.Location = new System.Drawing.Point(43, 53);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(766, 26);
            this.search.TabIndex = 30;
            this.search.Text = "Search MenuID or OrderName";
            this.search.Enter += new System.EventHandler(this.search_Enter);
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_KeyPress);
            this.search.Leave += new System.EventHandler(this.search_Leave);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.update.Enabled = false;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(709, 405);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 25);
            this.update.TabIndex = 29;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ORDERING_SYSTEM.Properties.Resources.icons8_search_24;
            this.pictureBox1.Location = new System.Drawing.Point(13, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // menu_datagrid
            // 
            this.menu_datagrid.AllowUserToAddRows = false;
            this.menu_datagrid.AllowUserToDeleteRows = false;
            this.menu_datagrid.AllowUserToResizeColumns = false;
            this.menu_datagrid.AllowUserToResizeRows = false;
            this.menu_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menu_datagrid.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.menu_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menu_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menu_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.menu_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menu_datagrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.menu_datagrid.EnableHeadersVisualStyles = false;
            this.menu_datagrid.GridColor = System.Drawing.Color.White;
            this.menu_datagrid.Location = new System.Drawing.Point(12, 84);
            this.menu_datagrid.Name = "menu_datagrid";
            this.menu_datagrid.ReadOnly = true;
            this.menu_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menu_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.menu_datagrid.RowHeadersVisible = false;
            this.menu_datagrid.RowHeadersWidth = 40;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.menu_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.menu_datagrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.menu_datagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menu_datagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_datagrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.menu_datagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.menu_datagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.menu_datagrid.RowTemplate.Height = 100;
            this.menu_datagrid.Size = new System.Drawing.Size(797, 276);
            this.menu_datagrid.TabIndex = 27;
            this.menu_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menu_datagrid_CellClick);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add.Enabled = false;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.Location = new System.Drawing.Point(709, 372);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 25);
            this.add.TabIndex = 31;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
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
            this.delete.Location = new System.Drawing.Point(709, 436);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 25);
            this.delete.TabIndex = 32;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // soup
            // 
            this.soup.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.soup;
            this.soup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soup.FlatAppearance.BorderSize = 0;
            this.soup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.soup.Location = new System.Drawing.Point(154, 388);
            this.soup.MaximumSize = new System.Drawing.Size(60, 60);
            this.soup.MinimumSize = new System.Drawing.Size(60, 60);
            this.soup.Name = "soup";
            this.soup.Size = new System.Drawing.Size(60, 60);
            this.soup.TabIndex = 33;
            this.soup.UseVisualStyleBackColor = true;
            this.soup.Click += new System.EventHandler(this.soup_Click);
            // 
            // rice
            // 
            this.rice.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.rice;
            this.rice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rice.FlatAppearance.BorderSize = 0;
            this.rice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rice.Location = new System.Drawing.Point(220, 388);
            this.rice.MaximumSize = new System.Drawing.Size(60, 60);
            this.rice.MinimumSize = new System.Drawing.Size(60, 60);
            this.rice.Name = "rice";
            this.rice.Size = new System.Drawing.Size(60, 60);
            this.rice.TabIndex = 34;
            this.rice.UseVisualStyleBackColor = true;
            this.rice.Click += new System.EventHandler(this.rice_Click);
            // 
            // porkchic
            // 
            this.porkchic.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.pork_chic;
            this.porkchic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.porkchic.FlatAppearance.BorderSize = 0;
            this.porkchic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.porkchic.Location = new System.Drawing.Point(286, 388);
            this.porkchic.MaximumSize = new System.Drawing.Size(60, 60);
            this.porkchic.MinimumSize = new System.Drawing.Size(60, 60);
            this.porkchic.Name = "porkchic";
            this.porkchic.Size = new System.Drawing.Size(60, 60);
            this.porkchic.TabIndex = 35;
            this.porkchic.UseVisualStyleBackColor = true;
            this.porkchic.Click += new System.EventHandler(this.porkchic_Click);
            // 
            // seafood
            // 
            this.seafood.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.seafood;
            this.seafood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seafood.FlatAppearance.BorderSize = 0;
            this.seafood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seafood.Location = new System.Drawing.Point(352, 388);
            this.seafood.MaximumSize = new System.Drawing.Size(60, 60);
            this.seafood.MinimumSize = new System.Drawing.Size(60, 60);
            this.seafood.Name = "seafood";
            this.seafood.Size = new System.Drawing.Size(60, 60);
            this.seafood.TabIndex = 36;
            this.seafood.UseVisualStyleBackColor = true;
            this.seafood.Click += new System.EventHandler(this.seafood_Click);
            // 
            // vegetables
            // 
            this.vegetables.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.vegetables;
            this.vegetables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vegetables.FlatAppearance.BorderSize = 0;
            this.vegetables.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vegetables.Location = new System.Drawing.Point(418, 388);
            this.vegetables.MaximumSize = new System.Drawing.Size(60, 60);
            this.vegetables.MinimumSize = new System.Drawing.Size(60, 60);
            this.vegetables.Name = "vegetables";
            this.vegetables.Size = new System.Drawing.Size(60, 60);
            this.vegetables.TabIndex = 37;
            this.vegetables.UseVisualStyleBackColor = true;
            this.vegetables.Click += new System.EventHandler(this.vegetables_Click);
            // 
            // noodles
            // 
            this.noodles.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.noodles;
            this.noodles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noodles.FlatAppearance.BorderSize = 0;
            this.noodles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.noodles.Location = new System.Drawing.Point(484, 388);
            this.noodles.MaximumSize = new System.Drawing.Size(60, 60);
            this.noodles.MinimumSize = new System.Drawing.Size(60, 60);
            this.noodles.Name = "noodles";
            this.noodles.Size = new System.Drawing.Size(60, 60);
            this.noodles.TabIndex = 38;
            this.noodles.UseVisualStyleBackColor = true;
            this.noodles.Click += new System.EventHandler(this.noodles_Click);
            // 
            // drinks
            // 
            this.drinks.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.drinks;
            this.drinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drinks.FlatAppearance.BorderSize = 0;
            this.drinks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.drinks.Location = new System.Drawing.Point(550, 388);
            this.drinks.MaximumSize = new System.Drawing.Size(60, 60);
            this.drinks.MinimumSize = new System.Drawing.Size(60, 60);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(60, 60);
            this.drinks.TabIndex = 39;
            this.drinks.UseVisualStyleBackColor = true;
            this.drinks.Click += new System.EventHandler(this.drinks_Click);
            // 
            // categories
            // 
            this.categories.BackColor = System.Drawing.Color.RoyalBlue;
            this.categories.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categories.ForeColor = System.Drawing.Color.White;
            this.categories.Location = new System.Drawing.Point(0, 0);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(821, 45);
            this.categories.TabIndex = 43;
            this.categories.Text = "CATEGORIES";
            this.categories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_panel
            // 
            this.add_panel.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.menubg;
            this.add_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_panel.Controls.Add(this.cancel);
            this.add_panel.Controls.Add(this.save);
            this.add_panel.Controls.Add(this.browse);
            this.add_panel.Controls.Add(this.menu_picture);
            this.add_panel.Controls.Add(this.label3);
            this.add_panel.Controls.Add(this.price);
            this.add_panel.Controls.Add(this.label2);
            this.add_panel.Controls.Add(this.quantity);
            this.add_panel.Controls.Add(this.label1);
            this.add_panel.Controls.Add(this.order_name);
            this.add_panel.Controls.Add(this.label9);
            this.add_panel.Controls.Add(this.panel5);
            this.add_panel.Location = new System.Drawing.Point(138, 122);
            this.add_panel.Name = "add_panel";
            this.add_panel.Size = new System.Drawing.Size(574, 260);
            this.add_panel.TabIndex = 44;
            this.add_panel.Visible = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel.Location = new System.Drawing.Point(284, 223);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 25);
            this.cancel.TabIndex = 47;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.CornflowerBlue;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(162, 223);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 25);
            this.save.TabIndex = 46;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.CornflowerBlue;
            this.browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.browse.FlatAppearance.BorderSize = 0;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.ForeColor = System.Drawing.Color.White;
            this.browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browse.Location = new System.Drawing.Point(445, 190);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(100, 25);
            this.browse.TabIndex = 45;
            this.browse.Text = "BROWSE";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // menu_picture
            // 
            this.menu_picture.Image = global::ORDERING_SYSTEM.Properties.Resources.menu1;
            this.menu_picture.Location = new System.Drawing.Point(434, 63);
            this.menu_picture.Name = "menu_picture";
            this.menu_picture.Size = new System.Drawing.Size(120, 120);
            this.menu_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu_picture.TabIndex = 34;
            this.menu_picture.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(431, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 146);
            this.label3.TabIndex = 33;
            this.label3.Text = "PICTURE OF MENU";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Gray;
            this.price.Location = new System.Drawing.Point(119, 134);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(291, 26);
            this.price.TabIndex = 31;
            this.price.Text = "ENTER PRICE";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Enter += new System.EventHandler(this.price_Enter);
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            this.price.Leave += new System.EventHandler(this.price_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "PRICE";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.Color.Gray;
            this.quantity.Location = new System.Drawing.Point(119, 101);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(291, 26);
            this.quantity.TabIndex = 29;
            this.quantity.Text = "ENTER QUANTITY";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity.Enter += new System.EventHandler(this.quantity_Enter);
            this.quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_KeyPress);
            this.quantity.Leave += new System.EventHandler(this.quantity_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "QUANTITY";
            // 
            // order_name
            // 
            this.order_name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_name.ForeColor = System.Drawing.Color.Gray;
            this.order_name.Location = new System.Drawing.Point(119, 69);
            this.order_name.Name = "order_name";
            this.order_name.Size = new System.Drawing.Size(291, 26);
            this.order_name.TabIndex = 2;
            this.order_name.Text = "ENTER ORDER NAME";
            this.order_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.order_name.Enter += new System.EventHandler(this.order_name_Enter);
            this.order_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.order_name_KeyPress);
            this.order_name.Leave += new System.EventHandler(this.order_name_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "ORDER NAME";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.add_menu);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(574, 37);
            this.panel5.TabIndex = 21;
            // 
            // add_menu
            // 
            this.add_menu.BackColor = System.Drawing.Color.Transparent;
            this.add_menu.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_menu.ForeColor = System.Drawing.Color.White;
            this.add_menu.Location = new System.Drawing.Point(0, 0);
            this.add_menu.Name = "add_menu";
            this.add_menu.Size = new System.Drawing.Size(574, 37);
            this.add_menu.TabIndex = 13;
            this.add_menu.Text = "ADD MENU";
            this.add_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // update_panel
            // 
            this.update_panel.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.menubg;
            this.update_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.update_panel.Controls.Add(this.update_price);
            this.update_panel.Controls.Add(this.update_quantity);
            this.update_panel.Controls.Add(this.update_ordername);
            this.update_panel.Controls.Add(this.label12);
            this.update_panel.Controls.Add(this.label13);
            this.update_panel.Controls.Add(this.label14);
            this.update_panel.Controls.Add(this.new_price);
            this.update_panel.Controls.Add(this.label5);
            this.update_panel.Controls.Add(this.new_quantity);
            this.update_panel.Controls.Add(this.label6);
            this.update_panel.Controls.Add(this.new_ordername);
            this.update_panel.Controls.Add(this.label7);
            this.update_panel.Controls.Add(this.panel1);
            this.update_panel.Controls.Add(this.new_browse);
            this.update_panel.Controls.Add(this.new_update_pic);
            this.update_panel.Controls.Add(this.label10);
            this.update_panel.Controls.Add(this.update_cancel);
            this.update_panel.Controls.Add(this.new_update);
            this.update_panel.Controls.Add(this.update_pic);
            this.update_panel.Controls.Add(this.label4);
            this.update_panel.Controls.Add(this.panel2);
            this.update_panel.Location = new System.Drawing.Point(138, 5);
            this.update_panel.Name = "update_panel";
            this.update_panel.Size = new System.Drawing.Size(574, 461);
            this.update_panel.TabIndex = 46;
            this.update_panel.Visible = false;
            // 
            // update_price
            // 
            this.update_price.BackColor = System.Drawing.Color.White;
            this.update_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.update_price.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_price.Location = new System.Drawing.Point(119, 128);
            this.update_price.Name = "update_price";
            this.update_price.Size = new System.Drawing.Size(291, 26);
            this.update_price.TabIndex = 63;
            this.update_price.Text = "PRICE";
            this.update_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // update_quantity
            // 
            this.update_quantity.BackColor = System.Drawing.Color.White;
            this.update_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.update_quantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_quantity.Location = new System.Drawing.Point(119, 96);
            this.update_quantity.Name = "update_quantity";
            this.update_quantity.Size = new System.Drawing.Size(291, 26);
            this.update_quantity.TabIndex = 62;
            this.update_quantity.Text = "QUANTITY";
            this.update_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // update_ordername
            // 
            this.update_ordername.BackColor = System.Drawing.Color.White;
            this.update_ordername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.update_ordername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_ordername.Location = new System.Drawing.Point(119, 63);
            this.update_ordername.Name = "update_ordername";
            this.update_ordername.Size = new System.Drawing.Size(291, 26);
            this.update_ordername.TabIndex = 61;
            this.update_ordername.Text = "ORDER NAME";
            this.update_ordername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(73, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 60;
            this.label12.Text = "PRICE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(46, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 59;
            this.label13.Text = "QUANTITY";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 20);
            this.label14.TabIndex = 58;
            this.label14.Text = "ORDER NAME";
            // 
            // new_price
            // 
            this.new_price.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_price.ForeColor = System.Drawing.Color.Gray;
            this.new_price.Location = new System.Drawing.Point(119, 343);
            this.new_price.Name = "new_price";
            this.new_price.Size = new System.Drawing.Size(291, 26);
            this.new_price.TabIndex = 56;
            this.new_price.Text = "ENTER PRICE";
            this.new_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.new_price.Enter += new System.EventHandler(this.new_price_Enter);
            this.new_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.new_price_KeyPress);
            this.new_price.Leave += new System.EventHandler(this.new_price_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "PRICE";
            // 
            // new_quantity
            // 
            this.new_quantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_quantity.ForeColor = System.Drawing.Color.Gray;
            this.new_quantity.Location = new System.Drawing.Point(119, 310);
            this.new_quantity.Name = "new_quantity";
            this.new_quantity.Size = new System.Drawing.Size(291, 26);
            this.new_quantity.TabIndex = 54;
            this.new_quantity.Text = "ENTER QUANTITY";
            this.new_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.new_quantity.Enter += new System.EventHandler(this.new_quantity_Enter);
            this.new_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.new_quantity_KeyPress);
            this.new_quantity.Leave += new System.EventHandler(this.new_quantity_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "QUANTITY";
            // 
            // new_ordername
            // 
            this.new_ordername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_ordername.ForeColor = System.Drawing.Color.Gray;
            this.new_ordername.Location = new System.Drawing.Point(119, 278);
            this.new_ordername.Name = "new_ordername";
            this.new_ordername.Size = new System.Drawing.Size(291, 26);
            this.new_ordername.TabIndex = 52;
            this.new_ordername.Text = "ENTER ORDER NAME";
            this.new_ordername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.new_ordername.Enter += new System.EventHandler(this.new_ordername_Enter);
            this.new_ordername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.new_ordername_KeyPress);
            this.new_ordername.Leave += new System.EventHandler(this.new_ordername_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "ORDER NAME";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(0, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 37);
            this.panel1.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(574, 37);
            this.label11.TabIndex = 13;
            this.label11.Text = "CHANGE THE FOLLOWING:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // new_browse
            // 
            this.new_browse.BackColor = System.Drawing.Color.CornflowerBlue;
            this.new_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.new_browse.FlatAppearance.BorderSize = 0;
            this.new_browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.new_browse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_browse.ForeColor = System.Drawing.Color.White;
            this.new_browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_browse.Location = new System.Drawing.Point(444, 391);
            this.new_browse.Name = "new_browse";
            this.new_browse.Size = new System.Drawing.Size(100, 25);
            this.new_browse.TabIndex = 50;
            this.new_browse.Text = "BROWSE";
            this.new_browse.UseVisualStyleBackColor = false;
            this.new_browse.Click += new System.EventHandler(this.new_browse_Click);
            // 
            // new_update_pic
            // 
            this.new_update_pic.Image = global::ORDERING_SYSTEM.Properties.Resources.menu1;
            this.new_update_pic.Location = new System.Drawing.Point(433, 264);
            this.new_update_pic.Name = "new_update_pic";
            this.new_update_pic.Size = new System.Drawing.Size(120, 120);
            this.new_update_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.new_update_pic.TabIndex = 49;
            this.new_update_pic.TabStop = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.SteelBlue;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(430, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 146);
            this.label10.TabIndex = 48;
            this.label10.Text = "PICTURE OF MENU";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.update_cancel.Location = new System.Drawing.Point(284, 422);
            this.update_cancel.Name = "update_cancel";
            this.update_cancel.Size = new System.Drawing.Size(100, 25);
            this.update_cancel.TabIndex = 47;
            this.update_cancel.Text = "CANCEL";
            this.update_cancel.UseVisualStyleBackColor = false;
            this.update_cancel.Click += new System.EventHandler(this.update_cancel_Click);
            // 
            // new_update
            // 
            this.new_update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.new_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.new_update.FlatAppearance.BorderSize = 0;
            this.new_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.new_update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_update.ForeColor = System.Drawing.Color.White;
            this.new_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_update.Location = new System.Drawing.Point(162, 422);
            this.new_update.Name = "new_update";
            this.new_update.Size = new System.Drawing.Size(100, 25);
            this.new_update.TabIndex = 46;
            this.new_update.Text = "UPDATE";
            this.new_update.UseVisualStyleBackColor = false;
            this.new_update.Click += new System.EventHandler(this.new_update_Click);
            // 
            // update_pic
            // 
            this.update_pic.Image = global::ORDERING_SYSTEM.Properties.Resources.menu1;
            this.update_pic.Location = new System.Drawing.Point(434, 63);
            this.update_pic.Name = "update_pic";
            this.update_pic.Size = new System.Drawing.Size(120, 120);
            this.update_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.update_pic.TabIndex = 34;
            this.update_pic.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(431, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 146);
            this.label4.TabIndex = 33;
            this.label4.Text = "PICTURE OF MENU";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label_update);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 37);
            this.panel2.TabIndex = 21;
            // 
            // label_update
            // 
            this.label_update.BackColor = System.Drawing.Color.Transparent;
            this.label_update.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_update.ForeColor = System.Drawing.Color.White;
            this.label_update.Location = new System.Drawing.Point(0, 0);
            this.label_update.Name = "label_update";
            this.label_update.Size = new System.Drawing.Size(574, 37);
            this.label_update.TabIndex = 13;
            this.label_update.Text = "UPDATE MENU";
            this.label_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu_database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.menubg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 478);
            this.ControlBox = false;
            this.Controls.Add(this.update_panel);
            this.Controls.Add(this.add_panel);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.drinks);
            this.Controls.Add(this.noodles);
            this.Controls.Add(this.vegetables);
            this.Controls.Add(this.seafood);
            this.Controls.Add(this.porkchic);
            this.Controls.Add(this.rice);
            this.Controls.Add(this.soup);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.update);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu_datagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu_database";
            this.Text = "menu_database";
            ((System.ComponentModel.ISupportInitialize)(this.orderingsystemdatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordering_system_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_datagrid)).EndInit();
            this.add_panel.ResumeLayout(false);
            this.add_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_picture)).EndInit();
            this.panel5.ResumeLayout(false);
            this.update_panel.ResumeLayout(false);
            this.update_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.new_update_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_pic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderingsystemdatabaseDataSetBindingSource;
        private ordering_system_databaseDataSet ordering_system_databaseDataSet;
        public System.Windows.Forms.TextBox search;
        public System.Windows.Forms.Button update;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView menu_datagrid;
        public System.Windows.Forms.Button add;
        public System.Windows.Forms.Button delete;
        public System.Windows.Forms.Label categories;
        public System.Windows.Forms.Panel add_panel;
        public System.Windows.Forms.TextBox order_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label add_menu;
        public System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button browse;
        public System.Windows.Forms.Button cancel;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button soup;
        public System.Windows.Forms.Button rice;
        public System.Windows.Forms.Button porkchic;
        public System.Windows.Forms.Button seafood;
        public System.Windows.Forms.Button vegetables;
        public System.Windows.Forms.Button noodles;
        public System.Windows.Forms.Button drinks;
        public System.Windows.Forms.PictureBox menu_picture;
        public System.Windows.Forms.Panel update_panel;
        public System.Windows.Forms.Button new_browse;
        public System.Windows.Forms.PictureBox new_update_pic;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button update_cancel;
        public System.Windows.Forms.Button new_update;
        public System.Windows.Forms.PictureBox update_pic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label update_price;
        private System.Windows.Forms.Label update_quantity;
        private System.Windows.Forms.Label update_ordername;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox new_price;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox new_quantity;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox new_ordername;
        private System.Windows.Forms.Label label7;


    }
}