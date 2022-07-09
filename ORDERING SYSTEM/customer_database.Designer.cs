namespace ORDERING_SYSTEM
{
    partial class customer_database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_database));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orderingsystemdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordering_system_databaseDataSet = new ORDERING_SYSTEM.ordering_system_databaseDataSet();
            this.customer_datagrid = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderingsystemdatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordering_system_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ORDERING_SYSTEM.Properties.Resources.icons8_search_24;
            this.pictureBox1.Location = new System.Drawing.Point(19, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
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
            // customer_datagrid
            // 
            this.customer_datagrid.AllowUserToAddRows = false;
            this.customer_datagrid.AllowUserToDeleteRows = false;
            this.customer_datagrid.AllowUserToResizeColumns = false;
            this.customer_datagrid.AllowUserToResizeRows = false;
            this.customer_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customer_datagrid.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.customer_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customer_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customer_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customer_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customer_datagrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.customer_datagrid.EnableHeadersVisualStyles = false;
            this.customer_datagrid.GridColor = System.Drawing.Color.White;
            this.customer_datagrid.Location = new System.Drawing.Point(12, 70);
            this.customer_datagrid.Name = "customer_datagrid";
            this.customer_datagrid.ReadOnly = true;
            this.customer_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customer_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.customer_datagrid.RowHeadersVisible = false;
            this.customer_datagrid.RowHeadersWidth = 40;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.customer_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.customer_datagrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.customer_datagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.customer_datagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_datagrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.customer_datagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.customer_datagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.customer_datagrid.RowTemplate.Height = 25;
            this.customer_datagrid.Size = new System.Drawing.Size(797, 298);
            this.customer_datagrid.TabIndex = 17;
            this.customer_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_datagrid_CellClick);
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
            this.delete.Location = new System.Drawing.Point(709, 411);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 25);
            this.delete.TabIndex = 25;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Gray;
            this.search.Location = new System.Drawing.Point(49, 35);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(400, 26);
            this.search.TabIndex = 26;
            this.search.Text = "Search Customer No or Name";
            this.search.Enter += new System.EventHandler(this.search_Enter);
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_KeyPress);
            this.search.Leave += new System.EventHandler(this.search_Leave);
            // 
            // customer_database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.menubg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 478);
            this.ControlBox = false;
            this.Controls.Add(this.search);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customer_datagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customer_database";
            this.Text = "customer_database";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderingsystemdatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordering_system_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource orderingsystemdatabaseDataSetBindingSource;
        private ordering_system_databaseDataSet ordering_system_databaseDataSet;
        public System.Windows.Forms.DataGridView customer_datagrid;
        public System.Windows.Forms.Button delete;
        public System.Windows.Forms.TextBox search;

    }
}