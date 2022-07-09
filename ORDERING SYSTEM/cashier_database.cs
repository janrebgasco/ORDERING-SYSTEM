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
    public partial class cashier_database : Form
    {
        public cashier_database()
        {
            InitializeComponent();
        }

        //initialize class and form
        cashier_form cash = new cashier_form();
        main main = new main();
        cashier cashier = new cashier();

        //function of event search enter/leave in cashier_database form--------------------------------------------------------------------------------------------------------- 
        private void search_Enter(object sender, EventArgs e)
        {
            if (search.Text == "Search Username")
            {
                search.Text = null;
                search.ForeColor = Color.Black;
            }
        }
        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "Search Username";
                search.ForeColor = Color.Gray;
            }
        }

        private void cashier_name_Enter(object sender, EventArgs e)
        {
            if (cashier_name.Text == "ENTER CASHIER NAME")
            {
                cashier_name.Text = null;
                cashier_name.ForeColor = Color.Black;
            }
        }

        private void cashier_name_Leave(object sender, EventArgs e)
        {
            if (cashier_name.Text == "")
            {
                cashier_name.Text = "ENTER CASHIER NAME";
                cashier_name.ForeColor = Color.Gray;
            }
        }
        private void add_username_Enter(object sender, EventArgs e)
        {
            if (add_username.Text == "ENTER USERNAME")
            {
                add_username.Text = null;
                add_username.ForeColor = Color.Black;
            }
        }

        private void add_username_Leave(object sender, EventArgs e)
        {
            if (add_username.Text == "")
            {
                add_username.Text = "ENTER USERNAME";
                add_username.ForeColor = Color.Gray;
            }
        }

        private void add_password_Enter(object sender, EventArgs e)
        {
            if (add_password.Text == "ENTER PASSWORD")
            {
                add_password.UseSystemPasswordChar = true;
                add_password.Text = null;
                add_password.ForeColor = Color.Black;
                confirm.Image = null;
            }
        }

        private void add_password_TextChanged(object sender, EventArgs e)
        {
            if (add_password.Text == add_confirmpassword.Text)
            {
                confirm.Image = Properties.Resources.check;
            }
            else
            {
                confirm.Image = Properties.Resources.x;
                confirm.BackColor = Color.Transparent;
            }
        }

        private void add_confirmpassword_TextChanged(object sender, EventArgs e)
        {
            if (add_password.Text == add_confirmpassword.Text)
            {
                confirm.Image = Properties.Resources.check;
            }
            else
            {
                confirm.Image = Properties.Resources.x;
                confirm.BackColor = Color.Transparent;
            }
        }

        private void add_password_Leave(object sender, EventArgs e)
        {
            if (add_password.Text == "")
            {
                add_password.UseSystemPasswordChar = false;
                add_password.Text = "ENTER PASSWORD";
                add_password.ForeColor = Color.Gray;
                confirm.Image = null;
            }
        }

        private void add_confirmpassword_Enter(object sender, EventArgs e)
        {
            if (add_confirmpassword.Text == "CONFIRM PASSWORD")
            {
                add_confirmpassword.UseSystemPasswordChar = true;
                add_confirmpassword.Text = null;
                add_confirmpassword.ForeColor = Color.Black;
                confirm.Image = null;
            }
        }

        private void add_confirmpassword_Leave(object sender, EventArgs e)
        {
            if (add_confirmpassword.Text == "")
            {
                add_confirmpassword.UseSystemPasswordChar = false;
                add_confirmpassword.Text = "CONFIRM PASSWORD";
                add_confirmpassword.ForeColor = Color.Gray;
                confirm.Image = null;
            }
        }

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            main.search = search.Text;

            //method to search cashier account 
            datagrid.DataSource = cashier.search_cashier();
            update.Enabled = true;
            delete.Enabled = false;
        }

        private void update_name_Enter(object sender, EventArgs e)
        {
            if (update_name.Text == "ENTER CASHIER NAME")
            {
                update_name.Text = null;
                update_name.ForeColor = Color.Black;
            }
        }

        private void update_name_Leave(object sender, EventArgs e)
        {
            if (update_name.Text == "")
            {
                update_name.Text = "ENTER CASHIER NAME";
                update_name.ForeColor = Color.Gray;
            }
        }

        private void update_username_Enter(object sender, EventArgs e)
        {
            if (update_username.Text == "ENTER USERNAME")
            {
                update_username.Text = null;
                update_username.ForeColor = Color.Black;
            }
        }

        private void update_username_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < datagrid.Rows.Count; ++i)
            {
                if (update_username.Text == "" + (datagrid.Rows[i].Cells[1].Value))
                {
                    MessageBox.Show("USERNAME ALREADY EXIST", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    update_username.Text = "";
                }
            }
        }

        private void Update_password_Enter(object sender, EventArgs e)
        {
            if (Update_password.Text == "ENTER PASSWORD")
            {
                Update_password.UseSystemPasswordChar = true;
                Update_password.Text = null;
                Update_password.ForeColor = Color.Black;
                update_pic.Image = null;
            }
        }

        private void Update_password_Leave(object sender, EventArgs e)
        {
            if (Update_password.Text == "")
            {
                Update_password.UseSystemPasswordChar = false;
                Update_password.Text = "ENTER PASSWORD";
                Update_password.ForeColor = Color.Gray;
                update_pic.Image = null;
            }
        }

        private void update_confirm_Enter(object sender, EventArgs e)
        {
            if (update_confirm.Text == "CONFIRM PASSWORD")
            {
                update_confirm.UseSystemPasswordChar = true;
                update_confirm.Text = null;
                update_confirm.ForeColor = Color.Black;
                update_pic.Image = null;
            }
        }

        private void update_confirm_Leave(object sender, EventArgs e)
        {
            if (update_confirm.Text == "")
            {
                update_confirm.UseSystemPasswordChar = false;
                update_confirm.Text = "CONFIRM PASSWORD";
                update_confirm.ForeColor = Color.Gray;
                update_pic.Image = null;
            }
        }

        private void Update_password_TextChanged(object sender, EventArgs e)
        {
            if (Update_password.Text == update_confirm.Text)
            {
                update_pic.Image = Properties.Resources.check;
            }
            else
            {
                update_pic.Image = Properties.Resources.x;
                update_pic.BackColor = Color.Transparent;
            }
        }

        private void update_confirm_TextChanged(object sender, EventArgs e)
        {
            if (Update_password.Text == update_confirm.Text)
            {
                update_pic.Image = Properties.Resources.check;
            }
            else
            {
                update_pic.Image = Properties.Resources.x;
                update_pic.BackColor = Color.Transparent;
            }
        }

        private void update_username_Leave(object sender, EventArgs e)
        {
            if (update_username.Text == "")
            {
                update_username.Text = "ENTER USERNAME";
                update_username.ForeColor = Color.Gray;
            }
        }

        //end of function of event search enter/leave

        //back to cashier log in form
        private void exit_Click(object sender, EventArgs e)
        {
            cash.Show();
            this.Hide();
        }

        //display the create cashier account panel
        private void add_Click(object sender, EventArgs e)
        {
            add_panel.Visible = true;
            datagrid.Enabled = false;
            search.Enabled = false;
            update.Enabled = false;
            delete.Enabled = false;
            search.Text = "Search Username";
            search.ForeColor = Color.Gray;
            datagrid.DataSource = main.cashier_select();
        }

        //hide create cashier account panel
        private void add_cancel_Click(object sender, EventArgs e)
        {
            add_panel.Visible = false;
            datagrid.Enabled = true;
            search.Enabled = true;
            update.Enabled = true;
            delete.Enabled = false;
            cashier_name.Text = "ENTER CASHIER NAME";
            add_username.Text = "ENTER USERNAME";
            add_password.Text = "ENTER PASSWORD";
            add_confirmpassword.Text = "CONFIRM PASSWORD";
            cashier_name.ForeColor = Color.Gray;
            add_username.ForeColor = Color.Gray;
            add_password.ForeColor = Color.Gray;
            add_confirmpassword.ForeColor = Color.Gray;
            add_password.UseSystemPasswordChar = false;
            add_confirmpassword.UseSystemPasswordChar = false;
            confirm.Image = null;
        }

        //button to create cashier account
        private void create_Click(object sender, EventArgs e)
        {
            //get the value of cashier name, username and password
            main.cashier_name = cashier_name.Text;
            main.cashier_username = add_username.Text;
            main.cashier_password = add_password.Text;
            main.cashier_confirm = add_confirmpassword.Text;
            //method to create cashier account
            cashier.cashier_account();

            //refresh data in datagridview
            datagrid.DataSource = main.cashier_select();

            if (main.tmp_add_button == 1)
            {
                add_panel.Visible = false;
                datagrid.Enabled = true;
                search.Enabled = true;
                update.Enabled = true;
                delete.Enabled = false;
                cashier_name.Text = "ENTER CASHIER NAME";
                add_username.Text = "ENTER USERNAME";
                add_password.Text = "ENTER PASSWORD";
                add_confirmpassword.Text = "CONFIRM PASSWORD";
                cashier_name.ForeColor = Color.Gray;
                add_username.ForeColor = Color.Gray;
                add_password.ForeColor = Color.Gray;
                add_confirmpassword.ForeColor = Color.Gray;
                add_password.UseSystemPasswordChar = false;
                add_confirmpassword.UseSystemPasswordChar = false;
                confirm.Image = null;
            }
        }

        //display cashier account data in datagridview
        private void cashier_database_Load(object sender, EventArgs e)
        {
            datagrid.DataSource = main.cashier_select();
        }

        //select cashier account in datagridview 
        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            update.Enabled = true;
            delete.Enabled = true;
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = datagrid.Rows[index];
                main.selected_cell = selectedRow.Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("ERROR IN SELECTING CELL IN DATAGRID. PLEASE SELECT AGAIN ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //delete cashier account
        private void delete_Click(object sender, EventArgs e)
        {
            //method to delete cashier account
            cashier.delete_cashier();


            //enabled/disabled button
            if (main.tmp_delete_button == 1)
            {
                delete.Enabled = false;
                update.Enabled = true;
                search.Text = "Search Username";
                search.ForeColor = Color.Gray;
                datagrid.DataSource = main.cashier_select();
            }
        }

        //verify the username if its already exist
        private void add_username_TextChanged(object sender, EventArgs e)
        {

            //verify the username if its already exist
            for (int i = 0; i < datagrid.Rows.Count; ++i)
            {
                if (add_username.Text == "" + (datagrid.Rows[i].Cells[1].Value))
                {
                    MessageBox.Show("USERNAME ALREADY EXIST", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    add_username.Text = "";
                }
            }
        }

        //update cashier account
        private void update_Click(object sender, EventArgs e)
        {
            update_name.Enabled = true;
            add.Enabled = false;
            update_panel.Visible = true;
            datagrid.Enabled = false;
            search.Enabled = false;
            delete.Enabled = false;
            search.Text = "Search Username";
            search.ForeColor = Color.Gray;
            datagrid.DataSource = main.cashier_select();
        }

        private void update_cancel_Click(object sender, EventArgs e)
        {
            //enabled/disabled button
            add.Enabled = true;
            update_panel.Visible = false;
            datagrid.Enabled = true;
            search.Enabled = true;
            update.Enabled = true;
            delete.Enabled = false;
            search_name.Enabled = true;
            save.Enabled = false;
            update_name.Text = "ENTER CASHIER NAME";
            update_name.ForeColor = Color.Gray;
            update_username.Text = "ENTER USERNAME";
            update_username.ForeColor = Color.Gray;
            Update_password.Text = "ENTER PASSWORD";
            Update_password.ForeColor = Color.Gray;
            Update_password.UseSystemPasswordChar = false;
            update_confirm.Text = "CONFIRM PASSWORD";
            update_confirm.ForeColor = Color.Gray;
            update_confirm.UseSystemPasswordChar = false;
            update_pic.Image = null;
            update_name.Enabled = true;
            update_username.Enabled = false;
            Update_password.Enabled = false;
            update_confirm.Enabled = false;
        }

        //find cashier account to update
        private void search_name_Click(object sender, EventArgs e)
        {
            //get the data of cashier name in textbox
            main.cashier_name = update_name.Text;

            //method to find cashier account
            cashier.find_cashier();

            //enabled/disabled button
            if (main.tmp_update == 1)
            {
                search_name.Enabled = true;
                update_username.Enabled = true;
                Update_password.Enabled = true;
                update_confirm.Enabled = true;
                save.Enabled = true;
                update_name.Enabled = false;
                search_name.Enabled = false;
                MessageBox.Show("YOUR ACCOUNT SUCCESSFULLY FOUND");
            }
        }

        //update cashier account
        private void save_Click(object sender, EventArgs e)
        {
            //get the data of cashier username and password in textbox
            main.cashier_username = update_username.Text;
            main.cashier_password = Update_password.Text;
            main.cashier_confirm = update_confirm.Text;
            main.cashier_name = update_name.Text;

            //method to update cashier account
            cashier.update_cashier();

            if (main.tmp_save == 1)
            {
                add.Enabled = true;
                update_panel.Visible = false;
                datagrid.Enabled = true;
                search.Enabled = true;
                update.Enabled = true;
                delete.Enabled = false;
                search_name.Enabled = true;
                save.Enabled = false;
                update_name.Text = "ENTER CASHIER NAME";
                update_name.ForeColor = Color.Gray;
                update_username.Text = "ENTER USERNAME";
                update_username.ForeColor = Color.Gray;
                Update_password.Text = "ENTER PASSWORD";
                Update_password.ForeColor = Color.Gray;
                Update_password.UseSystemPasswordChar = false;
                update_confirm.Text = "CONFIRM PASSWORD";
                update_confirm.ForeColor = Color.Gray;
                update_confirm.UseSystemPasswordChar = false;
                update_pic.Image = null;
                update_name.Enabled = true;
                update_username.Enabled = false;
                Update_password.Enabled = false;
                update_confirm.Enabled = false;
                datagrid.DataSource = main.cashier_select();
            }
        }
    }
}