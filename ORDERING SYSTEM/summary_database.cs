﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace ORDERING_SYSTEM
{
    public partial class summary_database : Form
    {
        public summary_database()
        {
            InitializeComponent();
        }

        //initialization of class and form
        main main = new main();
        summary summary = new summary();

//function of event search enter/leave in summary_database form---------------------------------------------------------------------------------------------------------
        private void search_Enter(object sender, EventArgs e)
        {
            if (search.Text == "Search Customer ID or Name")
            {
                search.Text = null;
                search.ForeColor = Color.Black;
            }

        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "Search Customer ID or Name";
                search.ForeColor = Color.Gray;
            }
        }
        //end of function of event search enter/leave

        //method for refresh data in datagridview
        public void refreshdata()
        {
            summary_datagrid.DataSource = main.summary_select();
            search.Text = "Search Customer ID or Name";
            search.ForeColor = Color.Gray;
        }

//function of Event cellclick  for summay database datagrid-------------------------------------------------------------------------------------------------------------------------
        private void summary_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            delete.Enabled = true;

            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = summary_datagrid.Rows[index];
                main.selected_cell = selectedRow.Cells[0].Value.ToString();
                main.selected_cell2 = selectedRow.Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("ERROR IN SELECTING CELL IN DATAGRID. PLEASE SELECT AGAIN ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

//function of Event delete button click for summary database form----------------------------------------------------------------------------------------------------------- 
        private void delete_Click(object sender, EventArgs e)
        {
            //method for deleting summary data 
            summary.delete_Summary();

            //method to refresh data in summary datagridview
            refreshdata();

            //Disabled delete button
            if (main.tmp_delete_button == 1)
            {
                delete.Enabled = false;
            }
        }

//function of search textbox------------------------------------------------------------------------------------------------------------------------------------------------------
        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //get the data from search textbox
            main.search = search.Text;

            //method for searching data
            summary_datagrid.DataSource = summary.search_order();

            //disable/enable of button
            delete.Enabled = false;
        }
    }
}
