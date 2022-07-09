using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

namespace ORDERING_SYSTEM
{
    public partial class admin_log_in : Form
    {
       public admin_log_in()
        {
            InitializeComponent();
        }

       //initialization of class
       admin admin = new admin();
       main main = new main();

//Exit button------------------------------------------------------------------------------------------------------------------------
        private void exit_Click(object sender, EventArgs e)
        {
            main.exit();
        }



//Events of username and password textbox in admin_log_in--------------------------------------------------------------------------------------------------------- 
        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = null;
                username.ForeColor = Color.Black;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Username";
                username.ForeColor = Color.Gray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = null;
                password.UseSystemPasswordChar = true;
                password.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
                password.UseSystemPasswordChar = false;
                password.ForeColor = Color.Gray;
            }
        }

        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = false;
            if (show_pass.Checked == false)
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void forgot_firstname_Enter(object sender, EventArgs e)
        {
            if (forgot_firstname.Text == "ENTER FIRST NAME")
            {
                forgot_firstname.Text = null;
                forgot_firstname.ForeColor = Color.Black;
            }
        }

        private void forgot_firstname_Leave(object sender, EventArgs e)
        {
            if (forgot_firstname.Text == "")
            {
                forgot_firstname.Text = "ENTER FIRST NAME";
                forgot_firstname.ForeColor = Color.Gray;
            }
        }

        private void forgot_lastname_Enter(object sender, EventArgs e)
        {
            if (forgot_lastname.Text == "ENTER LAST NAME")
            {
                forgot_lastname.Text = null;
                forgot_lastname.ForeColor = Color.Black;
            }
        }

        private void forgot_lastname_Leave(object sender, EventArgs e)
        {
            if (forgot_lastname.Text == "")
            {
                forgot_lastname.Text = "ENTER LAST NAME";
                forgot_lastname.ForeColor = Color.Gray;
            }
        }

        private void forgot_username_Enter(object sender, EventArgs e)
        {
            if (forgot_username.Text == "ENTER NEW USERNAME")
            {
                forgot_username.Text = null;
                forgot_username.ForeColor = Color.Black;
            }
        }

        private void forgot_username_Leave(object sender, EventArgs e)
        {
            if (forgot_username.Text == "")
            {
                forgot_username.Text = "ENTER NEW USERNAME";
                forgot_username.ForeColor = Color.Gray;
            }
        }

        private void forgot_password_Enter(object sender, EventArgs e)
        {
            if (forgot_password.Text == "ENTER NEW PASSWORD")
            {
                forgot_password.UseSystemPasswordChar = true;
                forgot_password.Text = null;
                forgot_password.ForeColor = Color.Black;
                confirm.Image = null;
            }
        }

        private void forgot_password_Leave(object sender, EventArgs e)
        {
            if (forgot_password.Text == "")
            {
                forgot_password.UseSystemPasswordChar = false;
                forgot_password.Text = "ENTER NEW PASSWORD";
                forgot_password.ForeColor = Color.Gray;
                confirm.Image = null;
            }
        }

        private void forgot_confirmpass_Enter(object sender, EventArgs e)
        {
            if (forgot_confirmpass.Text == "CONFIRM PASSWORD")
            {
                forgot_confirmpass.UseSystemPasswordChar = true;
                forgot_confirmpass.Text = null;
                forgot_confirmpass.ForeColor = Color.Black;
                confirm.Image = null;
            }
        }

        private void forgot_confirmpass_Leave(object sender, EventArgs e)
        {
            if (forgot_confirmpass.Text == "")
            {
                forgot_confirmpass.UseSystemPasswordChar = false;
                forgot_confirmpass.Text = "CONFIRM PASSWORD";
                forgot_confirmpass.ForeColor = Color.Gray;
                confirm.Image = null;
            }
        }

        private void forgot_confirmpass_TextChanged(object sender, EventArgs e)
        {

            if (forgot_password.Text == forgot_confirmpass.Text)
            {
                confirm.Image = Properties.Resources.check;
            }
            else
            {
                confirm.Image = Properties.Resources.x;
                confirm.BackColor = Color.Transparent;
            }
        }

        private void forgot_password_TextChanged(object sender, EventArgs e)
        {

            if (forgot_password.Text == forgot_confirmpass.Text)
            {
                confirm.Image = Properties.Resources.check;
            }
            else
            {
                confirm.Image = Properties.Resources.x;
                confirm.BackColor = Color.Transparent;
            }
        }

        private void forgot_firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsLetter(e.KeyChar) && number != 8 && number != 32)
            {

                e.Handled = true;
            }
        }

        private void forgot_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsLetter(e.KeyChar) && number != 8 && number != 32)
            {

                e.Handled = true;
            }
        }
        //end of events username and password textbox


//Admin log in button-----------------------------------------------------------------------------------------------------------
        private void login_Click(object sender, EventArgs e)
        {
            //get the data from username and password textbox
            main.log_username = username.Text;
            main.log_password = password.Text;

            //method for admin account log in
            admin.admin_log();

            //To display the admin database form
            if (main.tmp_log == 1)
            {
                admin_database ad = new admin_database();
                ad.Show();
                //close admin log in form
                this.Hide();
            }

            //enable/disable textbox and button
            forgot_firstname.Enabled = true;
            forgot_lastname.Enabled = true;
            find_account.Enabled = true;
            forgot_save.Enabled = false;
            forgot_username.Enabled = false;
            forgot_password.Enabled = false;
            forgot_confirmpass.Enabled = false;
            forgot_panel.Visible = false;
            forgot_firstname.Text = "ENTER FIRST NAME";
            forgot_lastname.Text = "ENTER LAST NAME";
            forgot_username.Text = "ENTER NEW USERNAME";
            forgot_password.Text = "ENTER NEW PASSWORD";
            forgot_confirmpass.Text = "CONFIRM PASSWORD";
            forgot_firstname.ForeColor = Color.Gray;
            forgot_lastname.ForeColor = Color.Gray;
            forgot_username.ForeColor = Color.Gray;
            forgot_password.ForeColor = Color.Gray;
            forgot_confirmpass.ForeColor = Color.Gray;
            confirm.Image = null;
            forgot_password.UseSystemPasswordChar = false;
            forgot_confirmpass.UseSystemPasswordChar = false;
        }

        //back to customer_order form
        private void back_Click(object sender, EventArgs e)
        {
            customer_order cus_order = new customer_order();
            cus_order.Show();
            this.Hide();
        }
//function of event forgot username or password linklabel click--------------------------------------------------------------------------------------------------
        private void forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgot_panel.Visible = true;
            username.Enabled = false;
            password.Enabled = false;
            login.Enabled = false;
        }

//function of event forgot cancel click-------------------------------------------------------------------------------------------------------------------------------------------
        private void forgot_cancel_Click(object sender, EventArgs e)
        {
            //enable/disable textbox and button
            forgot_firstname.Enabled = true;
            forgot_lastname.Enabled = true;
            find_account.Enabled = true;
            forgot_save.Enabled = false;
            forgot_username.Enabled = false;
            forgot_password.Enabled = false;
            forgot_confirmpass.Enabled = false;
            forgot_panel.Visible = false;
            forgot_firstname.Text = "ENTER FIRST NAME";
            forgot_lastname.Text = "ENTER LAST NAME";
            forgot_username.Text = "ENTER NEW USERNAME";
            forgot_password.Text = "ENTER NEW PASSWORD";
            forgot_confirmpass.Text = "CONFIRM PASSWORD";
            forgot_firstname.ForeColor = Color.Gray;
            forgot_lastname.ForeColor = Color.Gray;
            forgot_username.ForeColor = Color.Gray;
            forgot_password.ForeColor = Color.Gray;
            forgot_confirmpass.ForeColor = Color.Gray;
            confirm.Image = null;
            forgot_password.UseSystemPasswordChar = false;
            forgot_confirmpass.UseSystemPasswordChar = false;
            username.Enabled = true;
            password.Enabled = true;
            login.Enabled = true;
        }

//function of event find account click-----------------------------------------------------------------------------------------------------------------------------------------
        private void find_account_Click(object sender, EventArgs e)
        {
            //get the data from firstname and lastname textbox
            main.firstname = forgot_firstname.Text;
            main.lastname = forgot_lastname.Text;
            
            //method for finding account
            admin.find_account();

            if (main.tmp_update == 1)
            {
                //disable/enable of button and textbox 
                forgot_firstname.Enabled = false;
                forgot_lastname.Enabled = false;
                find_account.Enabled = false;
                forgot_username.Enabled = true;
                forgot_password.Enabled = true;
                forgot_confirmpass.Enabled = true;
                forgot_save.Enabled = true;
                MessageBox.Show("YOUR ACCOUNT SUCCESSFULLY FOUND");
            }
        }

//function of event save click for saving new username and password-------------------------------------------------------------------------------------------------------------------------------------------
        private void forgot_save_Click(object sender, EventArgs e)
        {
            //get the data from firstname and lastname textbox
            main.username = forgot_username.Text;
            main.password = forgot_password.Text;
            main.confirmpass = forgot_confirmpass.Text;

            //method for saving new username and password in recover admin account
            admin.forgot_save();

            //enable/disable textbox and button
            if (main.tmp_save == 1)
            {
                forgot_firstname.Enabled = true;
                forgot_lastname.Enabled = true;
                find_account.Enabled = true;
                forgot_save.Enabled = false;
                forgot_username.Enabled = false;
                forgot_password.Enabled = false;
                forgot_confirmpass.Enabled = false;
                forgot_panel.Visible = false;
                forgot_firstname.Text = "ENTER FIRST NAME";
                forgot_lastname.Text = "ENTER LAST NAME";
                forgot_username.Text = "ENTER NEW USERNAME";
                forgot_password.Text = "ENTER NEW PASSWORD";
                forgot_confirmpass.Text = "CONFIRM PASSWORD";
                forgot_firstname.ForeColor = Color.Gray;
                forgot_lastname.ForeColor = Color.Gray;
                forgot_username.ForeColor = Color.Gray;
                forgot_password.ForeColor = Color.Gray;
                forgot_confirmpass.ForeColor = Color.Gray;
                confirm.Image = null;
                forgot_password.UseSystemPasswordChar = false;
                forgot_confirmpass.UseSystemPasswordChar = false;
                username.Enabled = true;
                password.Enabled = true;
                login.Enabled = true;
            }
        }

       
    }
}
