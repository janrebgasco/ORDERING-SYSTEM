using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORDERING_SYSTEM
{
    public partial class cashier_record : Form
    {
        public cashier_record()
        {
            InitializeComponent();
        }

        //initialization of  form and class
        main main = new main();
        cashier_form cas = new cashier_form();
        cashier cashier = new cashier();

        //display cashier log in record table in datagrid 
        private void cashier_record_Load(object sender, EventArgs e)
        {
            datagrid.DataSource = main.cashier_record();
        }

        //back to cashier log in form
        private void exit_Click(object sender, EventArgs e)
        {
            cas.Show();
            this.Hide();
        }

        private void search_Enter(object sender, EventArgs e)
        {
            if (search.Text == "Search Cashier Name")
            {
                search.Text = null;
                search.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "Search Cashier Name";
                search.ForeColor = Color.Gray;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            cashier.delete_record();
            datagrid.DataSource = main.cashier_record();
            if (main.tmp_delete_button == 1)
            {
                delete.Enabled = false;
            }
        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            delete.Enabled = true;

            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = datagrid.Rows[index];
                main.selected_cell = selectedRow.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("ERROR IN SELECTING CELL IN DATAGRID. PLEASE SELECT AGAIN ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            main.search = search.Text;
            datagrid.DataSource = cashier.search_record();
        }
    }
}
