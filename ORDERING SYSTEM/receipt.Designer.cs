namespace ORDERING_SYSTEM
{
    partial class receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receipt));
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderlist = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderlist)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = global::ORDERING_SYSTEM.Properties.Resources.close;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Location = new System.Drawing.Point(503, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 30);
            this.exit.TabIndex = 3;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(179, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 63;
            this.label2.Text = "ORDERING SYSTEM";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(81, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 54);
            this.label1.TabIndex = 62;
            this.label1.Text = "FOODIE ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Black;
            this.time.Location = new System.Drawing.Point(108, 80);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(276, 28);
            this.time.TabIndex = 66;
            this.time.Text = "TIME";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.Location = new System.Drawing.Point(108, 112);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(276, 28);
            this.date.TabIndex = 65;
            this.date.Text = "DATE";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(108, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 28);
            this.label3.TabIndex = 67;
            this.label3.Text = "CUSTOMER RECEIPT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderlist
            // 
            this.orderlist.AllowUserToAddRows = false;
            this.orderlist.AllowUserToDeleteRows = false;
            this.orderlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderlist.BackgroundColor = System.Drawing.Color.White;
            this.orderlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.orderlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderlist.Enabled = false;
            this.orderlist.Location = new System.Drawing.Point(12, 189);
            this.orderlist.Name = "orderlist";
            this.orderlist.ReadOnly = true;
            this.orderlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderlist.RowHeadersVisible = false;
            this.orderlist.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderlist.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderlist.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.orderlist.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.orderlist.Size = new System.Drawing.Size(509, 331);
            this.orderlist.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 28);
            this.label4.TabIndex = 69;
            this.label4.Text = "TOTAL AMOUNT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.Transparent;
            this.total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.Black;
            this.total.Location = new System.Drawing.Point(182, 522);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(334, 28);
            this.total.TabIndex = 70;
            this.total.Text = "TOTAL AMOUNT";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cash
            // 
            this.cash.BackColor = System.Drawing.Color.Transparent;
            this.cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.ForeColor = System.Drawing.Color.Black;
            this.cash.Location = new System.Drawing.Point(182, 557);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(334, 28);
            this.cash.TabIndex = 72;
            this.cash.Text = "TOTAL AMOUNT";
            this.cash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 28);
            this.label7.TabIndex = 71;
            this.label7.Text = "CASH";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.Transparent;
            this.change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.ForeColor = System.Drawing.Color.Black;
            this.change.Location = new System.Drawing.Point(182, 588);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(334, 28);
            this.change.TabIndex = 74;
            this.change.Text = "TOTAL AMOUNT";
            this.change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 588);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 28);
            this.label9.TabIndex = 73;
            this.label9.Text = "CHANGE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(141, 154);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(296, 28);
            this.name.TabIndex = 75;
            this.name.Text = "name";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 28);
            this.label6.TabIndex = 76;
            this.label6.Text = "CASHIER";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 650);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.name);
            this.Controls.Add(this.change);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderlist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "receipt";
            this.Load += new System.EventHandler(this.receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView orderlist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label cash;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label6;

    }
}