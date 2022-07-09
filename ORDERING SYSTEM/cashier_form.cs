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
    public partial class cashier_form : Form
    {
        public cashier_form()
        {
            InitializeComponent();
        }

        //initialize class and form 
        main main = new main();
        admin admin = new admin();
        cashier cashier = new cashier();
        //exit button----------------------------------------------------------------------------------------------------

        private void exit_Click_1(object sender, EventArgs e)
        {
            main.exit();
        }

        //Events of username and password textbox in cashier log in---------------------------------------------------------------------------------------------------------
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

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Username")
            {
                textBox2.Text = null;
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Password")
            {
                textBox1.Text = null;
                textBox1.UseSystemPasswordChar = true;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Username";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Password";
                textBox1.UseSystemPasswordChar = false;
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;
            if (checkBox1.Checked == false)
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }
        //end of events username and password textbox
        
        //function to display log in  admin account panel
        private void back_Click(object sender, EventArgs e)
        {
            record.Enabled = false;
            exit.Enabled = false;
            forgot_panel.Visible = true;
            username.Enabled = false;
            password.Enabled = false;
            login.Enabled = false;
            forgot.Enabled = false;
            username.Text = "Username";
            username.ForeColor = Color.Gray;
            password.Text = "Password";
            password.ForeColor = Color.Gray;
            password.UseSystemPasswordChar = false;

        }

        //function to display log in admin account panel
        private void forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            record.Enabled = false;
            exit.Enabled = false;
            forgot_panel.Visible = true;
            username.Enabled = false;
            password.Enabled = false;
            login.Enabled = false;
            create.Enabled = false;
            username.Text = "Username";
            username.ForeColor = Color.Gray;
            password.Text = "Password";
            password.ForeColor = Color.Gray;
            password.UseSystemPasswordChar = false;
        }

        //cancel log in admin account
        private void button2_Click(object sender, EventArgs e)
        {
            record.Enabled = true;
            exit.Enabled = true;
            forgot_panel.Visible = false;
            username.Enabled = true;
            password.Enabled = true;
            login.Enabled = true;
            create.Enabled = true;
            forgot.Enabled = true;
            textBox2.Text = "Username";
            textBox2.ForeColor = Color.Gray;
            textBox1.Text = "Password";
            textBox1.ForeColor = Color.Gray;
            textBox1.UseSystemPasswordChar = false;
        }

        //log in button of admin account
        private void button1_Click(object sender, EventArgs e)
        {
            main.log_username = textBox2.Text;
            main.log_password = textBox1.Text;

            //method for admin account log in
            admin.admin_log();

            //To display the cashier database form
            if (main.tmp_log == 1)
            {
                cashier_database cas = new cashier_database();
                cas.Show();
                //close admin log in form
                this.Hide();
            }
        }

        //function of event record click to view the log in record of cashier
        private void record_Click(object sender, EventArgs e)
        {
            cashier_record c = new cashier_record();
            c.Show();
            this.Hide();
        }

        //set time and date
        private void cashier_form_Load(object sender, EventArgs e)
        {
            timer.Start();
            date.Text = DateTime.Now.ToShortDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }
        //timer to start time 
        private void timer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        //log in cashier account
        private void login_Click(object sender, EventArgs e)
        {
           //get the value of username and password
           main.log_username = username.Text;
           main.log_password = password.Text;
           main.date = date.Text;
           main.time = time.Text;

            //method for log in cashier account
            cashier.log_cashier();

            if (main.tmp_log == 1)
            {
                cashier.cashier_record();
                cashier.insert_cashier();
                customer_order cus = new customer_order();
                cus.Show();
                this.Hide();
            }
        }
    }
}
