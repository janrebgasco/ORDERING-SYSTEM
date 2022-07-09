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
    public partial class admin_account_database : Form
    {
        public admin_account_database()
        {
            InitializeComponent();
        }
        
        //initialization of class and form
         main main = new main();
         admin admin = new admin();

//function of event username enter/leave and password enter/leave in admin_log_in--------------------------------------------------------------------------------------------------------- 

        private void search_Enter_1(object sender, EventArgs e)
        {
            if (search.Text == "Search Username")
            {
                search.Text = null;
                search.ForeColor = Color.Black;
            }
        }

        private void search_Leave_1(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "Search Username";
                search.ForeColor = Color.Gray;
            }
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            delete.Enabled = false;
            update.Enabled = false;
        }

        private void update_password_Enter(object sender, EventArgs e)
        {
            if (update_password.Text == "ENTER PASSWORD")
            {
                update_password.UseSystemPasswordChar = true;
                update_password.Text = null;
                update_password.ForeColor = Color.Black;
            }
        }

        private void update_password_Leave(object sender, EventArgs e)
        {
            if (update_password.Text == "")
            {
                update_password.UseSystemPasswordChar = false;
                update_password.Text = "ENTER PASSWORD";
                update_password.ForeColor = Color.Gray;
            }
        }

        private void new_username_Leave(object sender, EventArgs e)
        {
            if (new_username.Text == "")
            {
                new_username.Text = "ENTER NEW USERNAME";
                new_username.ForeColor = Color.Gray;
            }
        }

        private void new_username_Enter(object sender, EventArgs e)
        {
            if (new_username.Text == "ENTER NEW USERNAME")
            {
                new_username.Text = null;
                new_username.ForeColor = Color.Black;
            }
        }

        private void new_password_Leave(object sender, EventArgs e)
        {
            if (new_password.Text == "")
            {
                new_password.UseSystemPasswordChar = false;
                new_password.Text = "ENTER NEW PASSWORD";
                new_password.ForeColor = Color.Gray;
            }
        }

        private void new_password_Enter(object sender, EventArgs e)
        {
            if (new_password.Text == "ENTER NEW PASSWORD")
            {
                new_password.UseSystemPasswordChar = true;
                new_password.Text = null;
                new_password.ForeColor = Color.Black;
            }
        }

        private void show_pass2_CheckedChanged(object sender, EventArgs e)
        {
            new_password.UseSystemPasswordChar = false;
            if (show_pass2.Checked == false)
            {
                new_password.UseSystemPasswordChar = true;
            }
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            delete.Enabled = false;
            update.Enabled = false;
        }

        private void add_firstname_Enter(object sender, EventArgs e)
        {
            if (add_firstname.Text == "ENTER FIRST NAME")
            {
                add_firstname.Text = null;
                add_firstname.ForeColor = Color.Black;
            }
        }

        private void add_firstname_Leave(object sender, EventArgs e)
        {
            if (add_firstname.Text == "")
            {
                add_firstname.Text = "ENTER FIRST NAME";
               add_firstname.ForeColor = Color.Gray;
            }
        }

        private void add_lastname_Enter(object sender, EventArgs e)
        {
            if (add_lastname.Text == "ENTER LAST NAME")
            {
                add_lastname.Text = null;
                add_lastname.ForeColor = Color.Black;
            }
        }

        private void add_lastname_Leave(object sender, EventArgs e)
        {
            if (add_lastname.Text == "")
            {
                add_lastname.Text = "ENTER LAST NAME";
                add_lastname.ForeColor = Color.Gray;
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

        private void add_firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsLetter(e.KeyChar) && number != 8 && number != 32)
            {

                e.Handled = true;
            }
        }

        private void add_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsLetter(e.KeyChar) && number != 8 && number != 32)
            {

                e.Handled = true;
            }
        }
        //end of function of event search enter/leave, username enter/leave and password enter/leave

       //method for refresh data in datagridview
        public void refreshdata()
        {
            main.admin_account_select();
            admin_account_datagrid.DataSource = main.admin_account;
            search.Text = "Search Username";
            search.ForeColor = Color.Gray;
        }

//display table of admin account in datagridview----------------------------------------------------------------------------------------------------------------------------------
        private void admin_account_database_Load(object sender, EventArgs e)
        {
            //display table of admin account in datagridview
            main.admin_account_select();
            admin_account_datagrid.DataSource = main.admin_account;
            update.Enabled = false;
            delete.Enabled = false;
        }

//Function of Event add button click for admin account database form------------------------------------------------------------------------------------------------------------------ 
        private void add_Click(object sender, EventArgs e)
        {
            //refresh data in datagridview
            refreshdata();

            //disable/enable of button and textbox
            search.Text = "Search Username";
            search.ForeColor = Color.Gray;
            add_panel.Visible = true;
            delete.Enabled = false;
            update.Enabled = false;
            add.Enabled = false;
            admin_account_datagrid.Enabled = false;
            search.Enabled = false;
            confirm.Image = null;
        }

//function of event text change for username textbox-------------------------------------------------------------------------------------------------------------------------------
        private void new_username_TextChanged(object sender, EventArgs e)
        {
            //refresh data in datagridview
            refreshdata();

            //verify the username if its already use
            for (int i = 0; i < admin_account_datagrid.Rows.Count; ++i)
            {
                if (new_username.Text == "" + (admin_account_datagrid.Rows[i].Cells[0].Value))
                {
                    MessageBox.Show("USERNAME ALREADY EXIST", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    new_username.Text = "";
                }
            }
        }

//function of Event cellclick  for admin account datagrid-------------------------------------------------------------------------------------------------------------------------
        private void admin_account_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            delete.Enabled = true;
            update.Enabled = true;

            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = admin_account_datagrid.Rows[index];
                main.selected_cell = selectedRow.Cells[0].Value.ToString();
                lblusername.Text = main.selected_cell;
            }
            catch
            {
                MessageBox.Show("ERROR IN SELECTING CELL IN DATAGRID. PLEASE SELECT AGAIN ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

//function of Event delete button click for admin account database form----------------------------------------------------------------------------------------------------------- 
        private void delete_Click(object sender, EventArgs e)
        {
            //method for deleting account 
            admin.delete_data();

            //refresh data in datagridview
            refreshdata();

            //Disabled update and delete button
            if (main.tmp_delete_button == 1)
            {
                delete.Enabled = false;
                update.Enabled = false;
            }
        }

//function of search textbox------------------------------------------------------------------------------------------------------------------------------------------------------
        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //get the data from search textbox
            main.search = search.Text;

            //method for searching account
            DataTable dt = admin.search_account();
            admin_account_datagrid.DataSource = dt;

            //disable/enable of button and textbox
            delete.Enabled = false;
            update.Enabled = false;
        }

//function of event text change for password textbox-------------------------------------------------------------------------------------------------------------------------
        private void password_TextChanged(object sender, EventArgs e)
        {
            //refresh data in datagridview
            refreshdata();
        }

//function of event update button click-------------------------------------------------------------------------------------------------------------------------
        private void update_Click(object sender, EventArgs e)
        {
            //update panel disable/enable button and textbox
            update_panel.Visible = true;
            search.Enabled = false;
            admin_account_datagrid.Enabled = false;
            add.Enabled = false;
            delete.Enabled = false;
            update.Enabled = false;
        }

//function of event cancel button click to cancel the update in account-------------------------------------------------------------------------------------------------------------------------
        private void cancel_Click(object sender, EventArgs e)
        {
            //disable/enable of button and textbox 
            log_in.Enabled = true;
            save.Enabled = false;
            new_username.Enabled = false;
            new_password.Enabled = false;
            update.Enabled = false;
            delete.Enabled = false;
            update_panel.Visible = false;
            search.Enabled = true;
            admin_account_datagrid.Enabled = true;
            add.Enabled = true;
            update_password.Enabled = true;
            update_password.Text = "ENTER PASSWORD";
            update_password.ForeColor = Color.Gray;
            update_password.UseSystemPasswordChar = false;
            new_username.Text = "ENTER NEW USERNAME";
            new_password.Text = "ENTER NEW PASSWORD";
            new_username.ForeColor = Color.Gray;
            new_password.ForeColor = Color.Gray;
            new_password.UseSystemPasswordChar = false;
        }

//function of Event Log In button-------------------------------------------------------------------------------------------------------------------------------------------------
        private void log_in_Click(object sender, EventArgs e)
        {
            //get the data from username and password textbox
            main.update_username = lblusername.Text;
            main.update_password = update_password.Text;

            //method for update account log in
            admin.update_account();

            if (main.tmp_update == 1)
            {
                //disable/enable of button and textbox 
                new_username.Enabled = true;
                new_password.Enabled = true;
                update_password.Enabled = false;
                log_in.Enabled = false;
                save.Enabled = true;
                MessageBox.Show("ACCOUNT SUCCESSFULLY LOG IN");
            }
            else
            {
                //disable/enable of button and textbox 
                update_password.Text = "ENTER PASSWORD";
                update_password.ForeColor = Color.Gray;
                update_password.UseSystemPasswordChar = false;
            }
        }

//function of Event save button click to save the update in account-------------------------------------------------------------------------------------------------------------------------
        private void save_Click(object sender, EventArgs e)
        {
            //get the data from username and password textbox
            main.save_username = new_username.Text;
            main.save_password = new_password.Text;

            //method to update account in admin account table
            DataTable dt = admin.save_update_account();
            admin_account_datagrid.DataSource = dt;

            //refresh data in datagridview
            refreshdata();

            if (main.tmp_save == 1)
            {
                //disable/enable of button and textbox
                update_panel.Visible = false;
                save.Enabled = false;
                new_username.Enabled = false;
                new_password.Enabled = false;
                update_password.Enabled = true;
                log_in.Enabled = true;
                update_password.Text = "ENTER PASSWORD";
                update_password.ForeColor = Color.Gray;
                update_password.UseSystemPasswordChar = false;
                new_username.Text = "ENTER NEW USERNAME";
                new_username.ForeColor = Color.Gray;
                new_password.Text = "ENTER NEW PASSWORD";
                new_password.UseSystemPasswordChar = false;
                new_password.ForeColor = Color.Gray;
                search.Enabled = true;
                admin_account_datagrid.Enabled = true;
                add.Enabled = true;
                delete.Enabled = false;
                update.Enabled = false;
            }
        }

//function of event cancel button click to cancel the add in account-------------------------------------------------------------------------------------------------------------------------
        private void add_cancel_Click(object sender, EventArgs e)
        {
            confirm.Image = null;
            search.Enabled = true;
            add.Enabled = true;
            admin_account_datagrid.Enabled = true;
            add_panel.Visible = false;
            confirm.Image = null;
            add_firstname.Text = "ENTER FIRST NAME";
            add_firstname.ForeColor = Color.Gray;
            add_lastname.Text = "ENTER LAST NAME";
            add_lastname.ForeColor = Color.Gray;
            add_username.Text = "ENTER USERNAME";
            add_username.ForeColor = Color.Gray;
            add_password.Text = "ENTER PASSWORD";
            add_password.ForeColor = Color.Gray;
            add_confirmpassword.Text = "CONFIRM PASSWORD";
            add_confirmpassword.ForeColor = Color.Gray;
            add_password.UseSystemPasswordChar = false;
            add_confirmpassword.UseSystemPasswordChar = false;
        }

//function of event create button click to create admin account---------------------------------------------------------------------------------------------------------------------------------
        private void create_Click(object sender, EventArgs e)
        {
            //get the data from first name, last name, username and password textbox
            main.firstname = add_firstname.Text;
            main.lastname = add_lastname.Text;
            main.username = add_username.Text;
            main.password = add_password.Text;
            main.confirmpass = add_confirmpassword.Text;

            //refresh data in datagridview
            refreshdata();
            
            //method for creating admin account
            admin.add_admin_account();
           
            //clear firstname, lastname, username and password textbox
            if (main.tmp_add_button == 1)
            {
                search.Enabled = true;
                add.Enabled = true;
                admin_account_datagrid.Enabled = true;
                add_username.Text = "ENTER USERNAME";
                add_password.Text = "ENTER PASSWORD";
                add_firstname.Text = "ENTER FIRST NAME";
                add_lastname.Text = "ENTER LAST NAME";
                add_confirmpassword.Text = "CONFIRM PASSWORD";
                add_firstname.ForeColor = Color.Gray;
                add_lastname.ForeColor = Color.Gray;
                add_username.ForeColor = Color.Gray;
                add_password.ForeColor = Color.Gray;
                add_confirmpassword.ForeColor = Color.Gray;
                add_password.UseSystemPasswordChar = false;
                add_confirmpassword.UseSystemPasswordChar = false;
                confirm.Image = null;
                add_panel.Visible = false;
            }
        }

//function of event text change for username textbox------------------------------------------------------------------------------------------------------------------------------ 
        private void add_username_TextChanged(object sender, EventArgs e)
        {
            //refresh data in datagridview
            refreshdata();

            //verify the username if its already use
            for (int i = 0; i < admin_account_datagrid.Rows.Count; ++i)
            {
                if (add_username.Text == "" + (admin_account_datagrid.Rows[i].Cells[0].Value))
                {
                    MessageBox.Show("USERNAME ALREADY EXIST", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    add_username.Text = "";
                }
            }
        }
    }
}
