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
    public partial class admin_database : Form
    {
//Initialization of class and  form------------------------------------------------------------------------------------------
        main main = new main();
        admin_account_database account = new admin_account_database();
        customer_database customer = new customer_database();
        order_database order = new order_database();
        summary_database summary = new summary_database();
        menu_database menu = new menu_database();
        customer_order cus_order = new customer_order();
        public admin_database()
        {
            InitializeComponent();
        }

//exit button---------------------------------------------------------------------------------------------------------------
        private void exit_Click(object sender, EventArgs e)
        {
            main.exit();
        }

//admin account button----------------------------------------------------------------------------------------------------
        private void admin_account_Click(object sender, EventArgs e)
        {
            //customizing border color for button
            admin_account.FlatAppearance.BorderColor = Color.CornflowerBlue;
            customer_database.FlatAppearance.BorderColor = Color.White;
            menu_database.FlatAppearance.BorderColor = Color.White;
            order_database.FlatAppearance.BorderColor = Color.White;
            summary_order.FlatAppearance.BorderColor = Color.White;
            //end of customize

            //display admin_account_database form to panel displayform
            displayform.Controls.Clear();
            account.TopLevel = false;
            account.Dock = DockStyle.Fill;
            displayform.Controls.Add(account);
            account.Show();

            //disable/enable of button and textbox in admin_account_database form
            this.account.log_in.Enabled = true;
            this.account.save.Enabled = false;
            this.account.new_username.Enabled = false;
            this.account.new_password.Enabled = false;
            this.account.update.Enabled = false;
            this.account.delete.Enabled = false;
            this.account.update_panel.Visible = false;
            this.account.search.Enabled = true;
            this.account.admin_account_datagrid.Enabled = true;
            this.account.add.Enabled = true;
            this.account.update_password.Enabled = true;
            this.account.update_password.Text = "ENTER PASSWORD";
            this.account.update_password.ForeColor = Color.Gray;
            this.account.update_password.UseSystemPasswordChar = false;
            this.account.search.Text = "Search Username";
            this.account.search.ForeColor = Color.Gray;
            this.customer.search.Text = "Search Customer ID or Name";
            this.customer.search.ForeColor = Color.Gray;
            this.order.search.Text = "Search Customer ID or Name";
            this.order.search.ForeColor = Color.Gray;
            this.summary.search.Text = "Search Customer ID or Name";
            this.summary.search.ForeColor = Color.Gray;
            this.account.new_username.Text = "ENTER NEW USERNAME";
            this.account.new_password.Text = "ENTER NEW PASSWORD";
            this.account.new_username.ForeColor = Color.Gray;
            this.account.new_password.ForeColor = Color.Gray;
            this.account.new_password.UseSystemPasswordChar = false;
            this.account.add_panel.Visible = false;
            this.account.add_firstname.Text = "ENTER FIRST NAME";
            this.account.add_firstname.ForeColor = Color.Gray;
            this.account.add_lastname.Text = "ENTER LAST NAME";
            this.account.add_lastname.ForeColor = Color.Gray;
            this.account.add_username.Text = "ENTER USERNAME";
            this.account.add_username.ForeColor = Color.Gray;
            this.account.add_password.Text = "ENTER PASSWORD";
            this.account.add_password.ForeColor = Color.Gray;
            this.account.add_confirmpassword.Text = "CONFIRM PASSWORD";
            this.account.add_confirmpassword.ForeColor = Color.Gray;
            this.account.add_password.UseSystemPasswordChar = false;
            this.account.add_confirmpassword.UseSystemPasswordChar = false;
            this.account.confirm.Image = null;

            //display the order table in order form datagridview 
            main.admin_account_select();
            this.account.admin_account_datagrid.DataSource = main.admin_account;

            //disable/enable of button and textbox in customer database form
            this.customer.delete.Enabled = false;
            this.order.delete.Enabled = false;
            this.summary.delete.Enabled = false;
            this.menu.update.Enabled = false;
            this.menu.delete.Enabled = false;
            this.menu.add.Enabled = false;
            this.menu.soup.Enabled = true;
            this.menu.rice.Enabled = true;
            this.menu.porkchic.Enabled = true;
            this.menu.seafood.Enabled = true;
            this.menu.vegetables.Enabled = true;
            this.menu.noodles.Enabled = true;
            this.menu.drinks.Enabled = true;
            this.menu.add_panel.Visible = false;
            this.menu.menu_datagrid.Enabled = true;
            this.menu.order_name.Text = "ENTER ORDER NAME";
            this.menu.quantity.Text = "ENTER QUANTITY";
            this.menu.price.Text = "ENTER PRICE";
            this.menu.order_name.ForeColor = Color.Gray;
            this.menu.quantity.ForeColor = Color.Gray;
            this.menu.price.ForeColor = Color.Gray;
            this.menu.menu_picture.Image = Properties.Resources.menu1;
            this.menu.search.Text = "Search MenuID or OrderName";
            this.menu.search.ForeColor = Color.Gray;
            this.menu.search.Enabled = false;
            this.menu.update_panel.Visible = false;
            this.menu.new_update_pic.Image = Properties.Resources.menu1;
            this.menu.new_ordername.Text = "ENTER ORDER NAME";
            this.menu.new_quantity.Text = "ENTER QUANTITY";
            this.menu.new_price.Text = "ENTER PRICE";
            this.menu.new_ordername.ForeColor = Color.Gray;
            this.menu.new_quantity.ForeColor = Color.Gray;
            this.menu.new_price.ForeColor = Color.Gray;
        }

//customer database button--------------------------------------------------------------------------------------------------
        private void customer_database_Click(object sender, EventArgs e)
        {
            //customizing border color for button
            customer_database.FlatAppearance.BorderColor = Color.CornflowerBlue;
            admin_account.FlatAppearance.BorderColor = Color.White;
            menu_database.FlatAppearance.BorderColor = Color.White;
            order_database.FlatAppearance.BorderColor = Color.White;
            summary_order.FlatAppearance.BorderColor = Color.White;
            //end of customize

            //display customer database form to panel displayform
            displayform.Controls.Clear();
            customer.TopLevel = false;
            customer.Dock = DockStyle.Fill;
            displayform.Controls.Add(customer);
            customer.Show();

            //display the customer table in customer form datagridview 
            this.customer.customer_datagrid.DataSource = main.customer_select();

            //disable/enable of button and textbox in admin_account_database form
            this.account.log_in.Enabled = true;
            this.account.save.Enabled = false;
            this.account.new_username.Enabled = false;
            this.account.new_password.Enabled = false;
            this.account.update.Enabled = false;
            this.account.delete.Enabled = false;
            this.account.update_panel.Visible = false;
            this.account.search.Enabled = true;
            this.account.admin_account_datagrid.Enabled = true;
            this.account.add.Enabled = true;
            this.account.update_password.Enabled = true;
            this.account.update_password.Text = "ENTER PASSWORD";
            this.account.update_password.ForeColor = Color.Gray;
            this.account.update_password.UseSystemPasswordChar = false;
            this.account.search.Text = "Search Username";
            this.account.search.ForeColor = Color.Gray;
            this.customer.search.Text = "Search Customer ID or Name";
            this.customer.search.ForeColor = Color.Gray;
            this.order.search.Text = "Search Customer ID or Name";
            this.order.search.ForeColor = Color.Gray;
            this.summary.search.Text = "Search Customer ID or Name";
            this.summary.search.ForeColor = Color.Gray;
            this.account.new_username.Text = "ENTER NEW USERNAME";
            this.account.new_password.Text = "ENTER NEW PASSWORD";
            this.account.new_username.ForeColor = Color.Gray;
            this.account.new_password.ForeColor = Color.Gray;
            this.account.new_password.UseSystemPasswordChar = false;
            this.account.add_panel.Visible = false;
            this.account.add_firstname.Text = "ENTER FIRST NAME";
            this.account.add_firstname.ForeColor = Color.Gray;
            this.account.add_lastname.Text = "ENTER LAST NAME";
            this.account.add_lastname.ForeColor = Color.Gray;
            this.account.add_username.Text = "ENTER USERNAME";
            this.account.add_username.ForeColor = Color.Gray;
            this.account.add_password.Text = "ENTER PASSWORD";
            this.account.add_password.ForeColor = Color.Gray;
            this.account.add_confirmpassword.Text = "CONFIRM PASSWORD";
            this.account.add_confirmpassword.ForeColor = Color.Gray;
            this.account.add_password.UseSystemPasswordChar = false;
            this.account.add_confirmpassword.UseSystemPasswordChar = false;
            this.account.confirm.Image = null;

            //disable/enable of button and textbox in customer database form
            this.customer.delete.Enabled = false;
            this.order.delete.Enabled = false;
            this.summary.delete.Enabled = false;
            this.menu.update.Enabled = false;
            this.menu.delete.Enabled = false;
            this.menu.add.Enabled = false;
            this.menu.soup.Enabled = true;
            this.menu.rice.Enabled = true;
            this.menu.porkchic.Enabled = true;
            this.menu.seafood.Enabled = true;
            this.menu.vegetables.Enabled = true;
            this.menu.noodles.Enabled = true;
            this.menu.drinks.Enabled = true;
            this.menu.add_panel.Visible = false;
            this.menu.menu_datagrid.Enabled = true;
            this.menu.order_name.Text = "ENTER ORDER NAME";
            this.menu.quantity.Text = "ENTER QUANTITY";
            this.menu.price.Text = "ENTER PRICE";
            this.menu.order_name.ForeColor = Color.Gray;
            this.menu.quantity.ForeColor = Color.Gray;
            this.menu.price.ForeColor = Color.Gray;
            this.menu.menu_picture.Image = Properties.Resources.menu1;
            this.menu.search.Text = "Search MenuID or OrderName";
            this.menu.search.ForeColor = Color.Gray;
            this.menu.search.Enabled = false;
            this.menu.update_panel.Visible = false;
            this.menu.new_update_pic.Image = Properties.Resources.menu1;
            this.menu.new_ordername.Text = "ENTER ORDER NAME";
            this.menu.new_quantity.Text = "ENTER QUANTITY";
            this.menu.new_price.Text = "ENTER PRICE";
            this.menu.new_ordername.ForeColor = Color.Gray;
            this.menu.new_quantity.ForeColor = Color.Gray;
            this.menu.new_price.ForeColor = Color.Gray;
        }

//menu database button-----------------------------------------------------------------------------------------------------
        private void menu_database_Click(object sender, EventArgs e)
        {
            //customizing border color for button
            menu_database.FlatAppearance.BorderColor = Color.CornflowerBlue;
            admin_account.FlatAppearance.BorderColor = Color.White;
            customer_database.FlatAppearance.BorderColor = Color.White;
            order_database.FlatAppearance.BorderColor = Color.White;
            summary_order.FlatAppearance.BorderColor = Color.White;
            //end of customize

            //display customer database form to panel displayform
            displayform.Controls.Clear();
            menu.TopLevel = false;
            menu.Dock = DockStyle.Fill;
            displayform.Controls.Add(menu);
            menu.Show();

            //method for selecting data in menu_table
            this.menu.categories.Text = "CATEGORIES";
            main.categories = this.menu.categories.Text;
            this.menu.menu_datagrid.DataSource = main.menu_select();

            //disable/enable of button and textbox in admin_account_database form
            this.account.log_in.Enabled = true;
            this.account.save.Enabled = false;
            this.account.new_username.Enabled = false;
            this.account.new_password.Enabled = false;
            this.account.update.Enabled = false;
            this.account.delete.Enabled = false;
            this.account.update_panel.Visible = false;
            this.account.search.Enabled = true;
            this.account.admin_account_datagrid.Enabled = true;
            this.account.add.Enabled = true;
            this.account.update_password.Enabled = true;
            this.account.update_password.Text = "ENTER PASSWORD";
            this.account.update_password.ForeColor = Color.Gray;
            this.account.update_password.UseSystemPasswordChar = false;
            this.account.search.Text = "Search Username";
            this.account.search.ForeColor = Color.Gray;
            this.customer.search.Text = "Search Customer ID or Name";
            this.customer.search.ForeColor = Color.Gray;
            this.order.search.Text = "Search Customer ID or Name";
            this.order.search.ForeColor = Color.Gray;
            this.summary.search.Text = "Search Customer ID or Name";
            this.summary.search.ForeColor = Color.Gray;
            this.account.new_username.Text = "ENTER NEW USERNAME";
            this.account.new_password.Text = "ENTER NEW PASSWORD";
            this.account.new_username.ForeColor = Color.Gray;
            this.account.new_password.ForeColor = Color.Gray;
            this.account.new_password.UseSystemPasswordChar = false;
            this.account.add_panel.Visible = false;
            this.account.add_firstname.Text = "ENTER FIRST NAME";
            this.account.add_firstname.ForeColor = Color.Gray;
            this.account.add_lastname.Text = "ENTER LAST NAME";
            this.account.add_lastname.ForeColor = Color.Gray;
            this.account.add_username.Text = "ENTER USERNAME";
            this.account.add_username.ForeColor = Color.Gray;
            this.account.add_password.Text = "ENTER PASSWORD";
            this.account.add_password.ForeColor = Color.Gray;
            this.account.add_confirmpassword.Text = "CONFIRM PASSWORD";
            this.account.add_confirmpassword.ForeColor = Color.Gray;
            this.account.add_password.UseSystemPasswordChar = false;
            this.account.add_confirmpassword.UseSystemPasswordChar = false;
            this.account.confirm.Image = null;

            //disable/enable of button and textbox in customer database form
            this.customer.delete.Enabled = false;
            this.order.delete.Enabled = false;
            this.summary.delete.Enabled = false;
            this.menu.update.Enabled = false;
            this.menu.delete.Enabled = false;
            this.menu.add.Enabled = false;
            this.menu.soup.Enabled = true;
            this.menu.rice.Enabled = true;
            this.menu.porkchic.Enabled = true;
            this.menu.seafood.Enabled = true;
            this.menu.vegetables.Enabled = true;
            this.menu.noodles.Enabled = true;
            this.menu.drinks.Enabled = true;
            this.menu.add_panel.Visible = false;
            this.menu.menu_datagrid.Enabled = true;
            this.menu.order_name.Text = "ENTER ORDER NAME";
            this.menu.quantity.Text = "ENTER QUANTITY";
            this.menu.price.Text = "ENTER PRICE";
            this.menu.order_name.ForeColor = Color.Gray;
            this.menu.quantity.ForeColor = Color.Gray;
            this.menu.price.ForeColor = Color.Gray;
            this.menu.menu_picture.Image = Properties.Resources.menu1;
            this.menu.search.Text = "Search MenuID or OrderName";
            this.menu.search.ForeColor = Color.Gray;
            this.menu.search.Enabled = false;
            this.menu.update_panel.Visible = false;
            this.menu.new_update_pic.Image = Properties.Resources.menu1;
            this.menu.new_ordername.Text = "ENTER ORDER NAME";
            this.menu.new_quantity.Text = "ENTER QUANTITY";
            this.menu.new_price.Text = "ENTER PRICE";
            this.menu.new_ordername.ForeColor = Color.Gray;
            this.menu.new_quantity.ForeColor = Color.Gray;
            this.menu.new_price.ForeColor = Color.Gray;
        }

//order database button-------------------------------------------------------------------------------------------------------
        private void order_database_Click(object sender, EventArgs e)
        {
            //customizing border color for button
            order_database.FlatAppearance.BorderColor = Color.CornflowerBlue;
            admin_account.FlatAppearance.BorderColor = Color.White;
            customer_database.FlatAppearance.BorderColor = Color.White;
            menu_database.FlatAppearance.BorderColor = Color.White;
            summary_order.FlatAppearance.BorderColor = Color.White;
            //end of customize

            //disable/enable of button and textbox in admin_account_database form
            this.account.log_in.Enabled = true;
            this.account.save.Enabled = false;
            this.account.new_username.Enabled = false;
            this.account.new_password.Enabled = false;
            this.account.update.Enabled = false;
            this.account.delete.Enabled = false;
            this.account.update_panel.Visible = false;
            this.account.search.Enabled = true;
            this.account.admin_account_datagrid.Enabled = true;
            this.account.add.Enabled = true;
            this.account.update_password.Enabled = true;
            this.account.update_password.Text = "ENTER PASSWORD";
            this.account.update_password.ForeColor = Color.Gray;
            this.account.update_password.UseSystemPasswordChar = false;
            this.account.search.Text = "Search Username";
            this.account.search.ForeColor = Color.Gray;
            this.customer.search.Text = "Search Customer ID or Name";
            this.customer.search.ForeColor = Color.Gray;
            this.order.search.Text = "Search Customer ID or Name";
            this.order.search.ForeColor = Color.Gray;
            this.summary.search.Text = "Search Customer ID or Name";
            this.summary.search.ForeColor = Color.Gray;
            this.account.new_username.Text = "ENTER NEW USERNAME";
            this.account.new_password.Text = "ENTER NEW PASSWORD";
            this.account.new_username.ForeColor = Color.Gray;
            this.account.new_password.ForeColor = Color.Gray;
            this.account.new_password.UseSystemPasswordChar = false;
            this.account.add_panel.Visible = false;
            this.account.add_firstname.Text = "ENTER FIRST NAME";
            this.account.add_firstname.ForeColor = Color.Gray;
            this.account.add_lastname.Text = "ENTER LAST NAME";
            this.account.add_lastname.ForeColor = Color.Gray;
            this.account.add_username.Text = "ENTER USERNAME";
            this.account.add_username.ForeColor = Color.Gray;
            this.account.add_password.Text = "ENTER PASSWORD";
            this.account.add_password.ForeColor = Color.Gray;
            this.account.add_confirmpassword.Text = "CONFIRM PASSWORD";
            this.account.add_confirmpassword.ForeColor = Color.Gray;
            this.account.add_password.UseSystemPasswordChar = false;
            this.account.add_confirmpassword.UseSystemPasswordChar = false;
            this.account.confirm.Image = null;

            //display customer database form to panel displayform
            displayform.Controls.Clear();
            order.TopLevel = false;
            order.Dock = DockStyle.Fill;
            displayform.Controls.Add(order);
            order.Show();

            //display the order table in order form datagridview 
            this.order.order_datagrid.DataSource = main.order_select();

            //disable/enable of button and textbox in customer database form
            this.customer.delete.Enabled = false;
            this.order.delete.Enabled = false;
            this.summary.delete.Enabled = false;
            this.menu.update.Enabled = false;
            this.menu.delete.Enabled = false;
            this.menu.add.Enabled = false;
            this.menu.soup.Enabled = true;
            this.menu.rice.Enabled = true;
            this.menu.porkchic.Enabled = true;
            this.menu.seafood.Enabled = true;
            this.menu.vegetables.Enabled = true;
            this.menu.noodles.Enabled = true;
            this.menu.drinks.Enabled = true;
            this.menu.add_panel.Visible = false;
            this.menu.menu_datagrid.Enabled = true;
            this.menu.order_name.Text = "ENTER ORDER NAME";
            this.menu.quantity.Text = "ENTER QUANTITY";
            this.menu.price.Text = "ENTER PRICE";
            this.menu.order_name.ForeColor = Color.Gray;
            this.menu.quantity.ForeColor = Color.Gray;
            this.menu.price.ForeColor = Color.Gray;
            this.menu.menu_picture.Image = Properties.Resources.menu1;
            this.menu.search.Text = "Search MenuID or OrderName";
            this.menu.search.ForeColor = Color.Gray;
            this.menu.search.Enabled = false;
            this.menu.update_panel.Visible = false;
            this.menu.new_update_pic.Image = Properties.Resources.menu1;
            this.menu.new_ordername.Text = "ENTER ORDER NAME";
            this.menu.new_quantity.Text = "ENTER QUANTITY";
            this.menu.new_price.Text = "ENTER PRICE";
            this.menu.new_ordername.ForeColor = Color.Gray;
            this.menu.new_quantity.ForeColor = Color.Gray;
            this.menu.new_price.ForeColor = Color.Gray;
        }

//summary order button-----------------------------------------------------------------------------------------------------------
        private void summary_order_Click(object sender, EventArgs e)
        {
            //customizing border color for button
            summary_order.FlatAppearance.BorderColor = Color.CornflowerBlue;
            order_database.FlatAppearance.BorderColor = Color.White;
            admin_account.FlatAppearance.BorderColor = Color.White;
            customer_database.FlatAppearance.BorderColor = Color.White;
            menu_database.FlatAppearance.BorderColor = Color.White;
            //end of customize

            //display customer database form to panel displayform
            displayform.Controls.Clear();
            summary.TopLevel = false;
            summary.Dock = DockStyle.Fill;
            displayform.Controls.Add(summary);
            summary.Show();

            //disable/enable of button and textbox in admin_account_database form
            this.account.log_in.Enabled = true;
            this.account.save.Enabled = false;
            this.account.new_username.Enabled = false;
            this.account.new_password.Enabled = false;
            this.account.update.Enabled = false;
            this.account.delete.Enabled = false;
            this.account.update_panel.Visible = false;
            this.account.search.Enabled = true;
            this.account.admin_account_datagrid.Enabled = true;
            this.account.add.Enabled = true;
            this.account.update_password.Enabled = true;
            this.account.update_password.Text = "ENTER PASSWORD";
            this.account.update_password.ForeColor = Color.Gray;
            this.account.update_password.UseSystemPasswordChar = false;
            this.account.search.Text = "Search Username";
            this.account.search.ForeColor = Color.Gray;
            this.customer.search.Text = "Search Customer ID or Name";
            this.customer.search.ForeColor = Color.Gray;
            this.order.search.Text = "Search Customer ID or Name";
            this.order.search.ForeColor = Color.Gray;
            this.summary.search.Text = "Search Customer ID or Name";
            this.summary.search.ForeColor = Color.Gray;
            this.account.new_username.Text = "ENTER NEW USERNAME";
            this.account.new_password.Text = "ENTER NEW PASSWORD";
            this.account.new_username.ForeColor = Color.Gray;
            this.account.new_password.ForeColor = Color.Gray;
            this.account.new_password.UseSystemPasswordChar = false;
            this.account.add_panel.Visible = false;
            this.account.add_firstname.Text = "ENTER FIRST NAME";
            this.account.add_firstname.ForeColor = Color.Gray;
            this.account.add_lastname.Text = "ENTER LAST NAME";
            this.account.add_lastname.ForeColor = Color.Gray;
            this.account.add_username.Text = "ENTER USERNAME";
            this.account.add_username.ForeColor = Color.Gray;
            this.account.add_password.Text = "ENTER PASSWORD";
            this.account.add_password.ForeColor = Color.Gray;
            this.account.add_confirmpassword.Text = "CONFIRM PASSWORD";
            this.account.add_confirmpassword.ForeColor = Color.Gray;
            this.account.add_password.UseSystemPasswordChar = false;
            this.account.add_confirmpassword.UseSystemPasswordChar = false;
            this.account.confirm.Image = null;

            //display the summary table in summary form datagridview 
            this.summary.summary_datagrid.DataSource = main.summary_select();

            //disable/enable of button and textbox in customer database form
            this.customer.delete.Enabled = false;
            this.order.delete.Enabled = false;
            this.summary.delete.Enabled = false;
            this.menu.update.Enabled = false;
            this.menu.delete.Enabled = false;
            this.menu.add.Enabled = false;
            this.menu.soup.Enabled = true;
            this.menu.rice.Enabled = true;
            this.menu.porkchic.Enabled = true;
            this.menu.seafood.Enabled = true;
            this.menu.vegetables.Enabled = true;
            this.menu.noodles.Enabled = true;
            this.menu.drinks.Enabled = true;
            this.menu.add_panel.Visible = false;
            this.menu.menu_datagrid.Enabled = true;
            this.menu.order_name.Text = "ENTER ORDER NAME";
            this.menu.quantity.Text = "ENTER QUANTITY";
            this.menu.price.Text = "ENTER PRICE";
            this.menu.order_name.ForeColor = Color.Gray;
            this.menu.quantity.ForeColor = Color.Gray;
            this.menu.price.ForeColor = Color.Gray;
            this.menu.menu_picture.Image = Properties.Resources.menu1;
            this.menu.search.Text = "Search MenuID or OrderName";
            this.menu.search.ForeColor = Color.Gray;
            this.menu.search.Enabled = false;
            this.menu.update_panel.Visible = false;
            this.menu.new_update_pic.Image = Properties.Resources.menu1;
            this.menu.new_ordername.Text = "ENTER ORDER NAME";
            this.menu.new_quantity.Text = "ENTER QUANTITY";
            this.menu.new_price.Text = "ENTER PRICE";
            this.menu.new_ordername.ForeColor = Color.Gray;
            this.menu.new_quantity.ForeColor = Color.Gray;
            this.menu.new_price.ForeColor = Color.Gray;
        }

//log out admin button-----------------------------------------------------------------------------------------------------------
        private void log_out_Click(object sender, EventArgs e)
        {
            cus_order.Show();
            this.Hide();
            //disable/enable of button and textbox in admin_account_database form
            this.account.log_in.Enabled = true;
            this.account.save.Enabled = false;
            this.account.new_username.Enabled = false;
            this.account.new_password.Enabled = false;
            this.account.update.Enabled = false;
            this.account.delete.Enabled = false;
            this.account.update_panel.Visible = false;
            this.account.search.Enabled = true;
            this.account.admin_account_datagrid.Enabled = true;
            this.account.add.Enabled = true;
            this.account.update_password.Enabled = true;
            this.account.update_password.Text = "ENTER PASSWORD";
            this.account.update_password.ForeColor = Color.Gray;
            this.account.update_password.UseSystemPasswordChar = false;
            this.account.search.Text = "Search Username";
            this.account.search.ForeColor = Color.Gray;
            this.customer.search.Text = "Search Customer ID or Name";
            this.customer.search.ForeColor = Color.Gray;
            this.order.search.Text = "Search Customer ID or Name";
            this.order.search.ForeColor = Color.Gray;
            this.summary.search.Text = "Search Customer ID or Name";
            this.summary.search.ForeColor = Color.Gray;
            this.account.new_username.Text = "ENTER NEW USERNAME";
            this.account.new_password.Text = "ENTER NEW PASSWORD";
            this.account.new_username.ForeColor = Color.Gray;
            this.account.new_password.ForeColor = Color.Gray;
            this.account.new_password.UseSystemPasswordChar = false;
            this.account.add_panel.Visible = false;
            this.account.add_firstname.Text = "ENTER FIRST NAME";
            this.account.add_firstname.ForeColor = Color.Gray;
            this.account.add_lastname.Text = "ENTER LAST NAME";
            this.account.add_lastname.ForeColor = Color.Gray;
            this.account.add_username.Text = "ENTER USERNAME";
            this.account.add_username.ForeColor = Color.Gray;
            this.account.add_password.Text = "ENTER PASSWORD";
            this.account.add_password.ForeColor = Color.Gray;
            this.account.add_confirmpassword.Text = "CONFIRM PASSWORD";
            this.account.add_confirmpassword.ForeColor = Color.Gray;
            this.account.add_password.UseSystemPasswordChar = false;
            this.account.add_confirmpassword.UseSystemPasswordChar = false;
            this.account.confirm.Image = null;

            //disable/enable of button and textbox in customer database form
            this.customer.delete.Enabled = false;
            this.order.delete.Enabled = false;
            this.summary.delete.Enabled = false;
            this.menu.update.Enabled = false;
            this.menu.delete.Enabled = false;
            this.menu.add.Enabled = false;
            this.menu.soup.Enabled = true;
            this.menu.rice.Enabled = true;
            this.menu.porkchic.Enabled = true;
            this.menu.seafood.Enabled = true;
            this.menu.vegetables.Enabled = true;
            this.menu.noodles.Enabled = true;
            this.menu.drinks.Enabled = true;
            this.menu.add_panel.Visible = false;
            this.menu.menu_datagrid.Enabled = true;
            this.menu.order_name.Text = "ENTER ORDER NAME";
            this.menu.quantity.Text = "ENTER QUANTITY";
            this.menu.price.Text = "ENTER PRICE";
            this.menu.order_name.ForeColor = Color.Gray;
            this.menu.quantity.ForeColor = Color.Gray;
            this.menu.price.ForeColor = Color.Gray;
            this.menu.menu_picture.Image = Properties.Resources.menu1;
            this.menu.search.Text = "Search MenuID or OrderName";
            this.menu.search.ForeColor = Color.Gray;
            this.menu.search.Enabled = false;
            this.menu.update_panel.Visible = false;
            this.menu.new_update_pic.Image = Properties.Resources.menu1;
            this.menu.new_ordername.Text = "ENTER ORDER NAME";
            this.menu.new_quantity.Text = "ENTER QUANTITY";
            this.menu.new_price.Text = "ENTER PRICE";
            this.menu.new_ordername.ForeColor = Color.Gray;
            this.menu.new_quantity.ForeColor = Color.Gray;
            this.menu.new_price.ForeColor = Color.Gray;
        }
    }
}
