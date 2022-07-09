using System;
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
    public partial class customer_database : Form
    {
        public customer_database()
        {
            InitializeComponent();
        }

        //initialization of class and form
        customer customer = new customer();
        main main = new main();

//function of event search enter/leave in customer_database form--------------------------------------------------------------------------------------------------------- 
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

//function of Event cellclick  for customer database datagrid-------------------------------------------------------------------------------------------------------------------------
        private void customer_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            delete.Enabled = true;

            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow =customer_datagrid.Rows[index];
                main.selected_cell = selectedRow.Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("ERROR IN SELECTING CELL IN DATAGRID. PLEASE SELECT AGAIN ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //method for refresh data in datagridview
        public void refreshdata()
        {
            customer_datagrid.DataSource = main.customer_select();
            search.Text = "Search Customer ID or Name";
            search.ForeColor = Color.Gray;
        }

//function of Event delete button click for customer database form----------------------------------------------------------------------------------------------------------- 
        private void delete_Click(object sender, EventArgs e)
        {
            //method for deleting customer data 
            customer.delete_customer();
            customer.delete_customer_order();
            //method to refresh data in customer datagridview
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
            customer_datagrid.DataSource = customer.search_customer();

            //disable/enable of button
            delete.Enabled = false;

        }

    }
}
