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
    public partial class customer_order : Form
    {
        public customer_order()
        {
            InitializeComponent();
        }
        //Initialization of class and form------------------------------------------------------------------------------------------
        main main = new main();
        admin_log_in log = new admin_log_in();
        customer_main customer = new customer_main();

//exit button------------------------------------------------------------------------------------------------------------------------
        private void exit_Click(object sender, EventArgs e)
        {
            cashier_form cash = new cashier_form();
            cash.Show();
            this.Hide();
        }
//admin button-----------------------------------------------------------------------------------------------------------------------
        private void admin_Click(object sender, EventArgs e)
        {
            log.Show();
            this.Hide();
        }

//function of event customer_name enter/leave--------------------------------------------------------------------------------------------------------- 
        private void customer_name_Enter(object sender, EventArgs e)
        {
            if (customer_name.Text == "ENTER CUSTOMER NAME")
            {
                customer_name.Text = null;
                customer_name.ForeColor = Color.Black;
            }
        }

        private void customer_name_Leave(object sender, EventArgs e)
        {
            if (customer_name.Text == "")
            {
                customer_name.Text = "ENTER CUSTOMER NAME";
                customer_name.ForeColor = Color.Gray;
            }
        }

        private void customer_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            enter.Enabled = true;
            char number = e.KeyChar;
            if (!char.IsLetter(e.KeyChar) && number != 8 && number != 32)
            {

                e.Handled = true;
            }
        }

        private void cash_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && number != 8 && number != 46)
            {

                e.Handled = true;
            }

        }
        //end of function of event customer_name enter/leave

//function of event enter click to add customer name--------------------------------------------------------------------------------------------------------- 
        private void enter_Click(object sender, EventArgs e)

        {
            main.totalamount = 0;
            if (customer_name.Text == string.Empty || customer_name.Text == "ENTER CUSTOMER NAME")
            {
                MessageBox.Show("PLEASE ENTER CUSTOMER NAME", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                enter.Enabled = false;
            }
            else
            {
                //method to generate customerID
                main.orderNo = 1;
                customer.generate_customerID();
                main.customer_name = customer_name.Text;
                //enable/disableb button and groupbox
                enter.Enabled = false;
                customer_name.Enabled = false;
                categories.Enabled = true;
            }
            
        }

//function of Event soup button click for customer_order form---------------------------------------------------------------------------------------------------------------------- 
        private void soup_Click(object sender, EventArgs e)
        {
            main.categories = "SOUP";
            menu.Text = main.categories + " MENU";
            //method for selecting data in menu_table
            menu_datagrid.DataSource = main.menu_select();
            menu_datagrid.Enabled = true;
            order_datagrid.Enabled = true;
            summary_datagrid.Enabled = true;
        }

//function of Event rice button click for customer_order form---------------------------------------------------------------------------------------------------------------------- 
        private void rice_Click(object sender, EventArgs e)
        {
            main.categories = "RICE";
            menu.Text = main.categories + " MENU";
            //method for selecting data in menu_table
            menu_datagrid.DataSource = main.menu_select();
            menu_datagrid.Enabled = true;
            order_datagrid.Enabled = true;
            summary_datagrid.Enabled = true;
        }

//function of Event porkchic button click for customer_order form---------------------------------------------------------------------------------------------------------------------- 
        private void porkchic_Click(object sender, EventArgs e)
        {
            main.categories = "PORK AND CHICKEN";
            menu.Text = main.categories + " MENU";
            //method for selecting data in menu_table
            menu_datagrid.DataSource = main.menu_select();
            menu_datagrid.Enabled = true;
            order_datagrid.Enabled = true;
            summary_datagrid.Enabled = true;
        }

//function of Event seafood button click for customer_order form---------------------------------------------------------------------------------------------------------------------- 
        private void seafood_Click(object sender, EventArgs e)
        {
            main.categories = "SEAFOOD";
            menu.Text = main.categories + " MENU";
            //method for selecting data in menu_table
            menu_datagrid.DataSource = main.menu_select();
            menu_datagrid.Enabled = true;
            order_datagrid.Enabled = true;
            summary_datagrid.Enabled = true;
        }

//function of Event vegetables button click for customer_order form---------------------------------------------------------------------------------------------------------------------- 
        private void vegetables_Click(object sender, EventArgs e)
        {
            main.categories = "VEGETABLES";
            menu.Text = main.categories + " MENU";
            //method for selecting data in menu_table
            menu_datagrid.DataSource = main.menu_select();
            menu_datagrid.Enabled = true;
            order_datagrid.Enabled = true;
            summary_datagrid.Enabled = true;
        }

//function of Event noodles button click for customer_order form---------------------------------------------------------------------------------------------------------------------- 
        private void noodles_Click(object sender, EventArgs e)
        {
            main.categories = "NOODLES";
            menu.Text = main.categories + " MENU";
            //method for selecting data in menu_table
            menu_datagrid.DataSource = main.menu_select();
            menu_datagrid.Enabled = true;
            order_datagrid.Enabled = true;
            summary_datagrid.Enabled = true;
        }

//function of Event drinks button click for customer_order form---------------------------------------------------------------------------------------------------------------------- 
        private void drinks_Click(object sender, EventArgs e)
        {
            main.categories = "DRINKS";
            menu.Text = main.categories + " MENU";
            //method for selecting data in menu_table
            menu_datagrid.DataSource = main.menu_select();
            menu_datagrid.Enabled = true;
            order_datagrid.Enabled = true;
            summary_datagrid.Enabled = true;
        }

        //selecting menu-----------------------------------------------------------------------------------------------------------------------------------------------------------
        private void summary_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = summary_datagrid.Rows[index];
            main.order_name = selectedRow.Cells[0].Value.ToString();
            main.price = double.Parse(selectedRow.Cells[2].Value.ToString());
        }

        private void order_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = order_datagrid.Rows[index];
                main.orderNo = int.Parse(selectedRow.Cells[0].Value.ToString());
                main.order_name = selectedRow.Cells[1].Value.ToString();
                main.price = double.Parse(selectedRow.Cells[2].Value.ToString());
            }
            catch
            {
                MessageBox.Show("ERROR IN SELECTING CELL IN DATAGRID. PLEASE SELECT AGAIN ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menu_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = menu_datagrid.Rows[index];
                main.menuNo = int.Parse(selectedRow.Cells[0].Value.ToString());
                main.order_name = selectedRow.Cells[1].Value.ToString();
                main.quantity = int.Parse(selectedRow.Cells[2].Value.ToString());
                main.price = double.Parse(selectedRow.Cells[3].Value.ToString());
                add.Enabled = true;
                if (main.quantity == 0)
                {
                    add.Enabled = false;
                    MessageBox.Show(main.order_name + " is out of stock", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("ERROR IN SELECTING CELL IN DATAGRID. PLEASE SELECT AGAIN ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //add order----------------------------------------------------------------------------------------------------------------------------------------------------
        private void add_Click(object sender, EventArgs e)
        {
            main.totalamount = main.totalamount + main.price;

            //method to add order
            customer.add_order();
            if (main.tmp_add_button == 1)
            {
                order.Enabled = true;
                summary.Enabled = true;
                totalamount.Enabled = true;
                total.Text ="Php " + main.totalamount;
            }
            if (main.quantity != 0)
            {
                main.orderNo = main.orderNo + 1;
                main.quantity = main.quantity - 1;
                order_datagrid.DataSource = customer.menu_order_select();
                summary_datagrid.DataSource = customer.menu_summary_select();
                menu_datagrid.DataSource = customer.update_menu();
                menu_datagrid.DataSource = main.menu_select();
            }
            else
            {
                add.Enabled = false;
                main.quantity = 0;
                menu_datagrid.DataSource = main.menu_select();
                MessageBox.Show(main.order_name + " IS OUT OF STOCK", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //delete order---------------------------------------------------------------------------------------------------------------------------------------------------------
        private void delete_order_Click(object sender, EventArgs e)
        {
            customer.delete_order();
            if (main.tmp_delete_button == 1)
            {
                order_datagrid.DataSource = customer.menu_order_select();
                summary_datagrid.DataSource = customer.menu_summary_select();
                main.totalamount = main.totalamount - main.price;
                total.Text = "Php " + main.totalamount;
            }
            
        }

        private void delete_summary_Click(object sender, EventArgs e)
        {
            customer.delete_summary();
            if (main.tmp_delete_button == 1)
            {
                summary_datagrid.DataSource = customer.menu_summary_select();
                order_datagrid.DataSource = customer.menu_order_select();
                main.totalamount = main.totalamount - main.price;
                total.Text = "Php " + main.totalamount;
            }

        }

        //display payment panel
        private void payment_Click(object sender, EventArgs e)
        {
            customer_payment.Enabled = true;
            customer_payment.Visible = true;
            categories.Enabled = false;
            order.Enabled = false;
            menu_datagrid.Enabled = false;
            add.Enabled = false;
            summary.Enabled = false;
            totalamount.Enabled = false;
            admin.Enabled = false;

            name_customer.Text = main.customer_name;
            date_payment.Text = date.Text;
            time_payment.Text = time.Text;
            total_payment.Text ="Php " + main.totalamount;
        }

        //dispaly date and time
        private void customer_order_Load(object sender, EventArgs e)
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

        //cancel button in payment panel
        private void cancel_Click(object sender, EventArgs e)
        {
            customer_payment.Enabled = false;
            customer_payment.Visible = false;
            categories.Enabled = true;
            order.Enabled = true;
            menu.Enabled = true;
            add.Enabled = true;
            summary.Enabled = true;
            totalamount.Enabled = true;
            admin.Enabled = true;
            menu_datagrid.Enabled = true;

        }

        private void pay_Click(object sender, EventArgs e)
        {
            main.date = date_payment.Text;
            main.time = time_payment.Text;

            if (cash.Text == string.Empty)
            {
                MessageBox.Show("CASH AMOUNT IS INVALID", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                main.cash = double.Parse(cash.Text);
         
            }
            if (main.cash < main.totalamount)
            {
                MessageBox.Show("CASH AMOUNT IS INVALID", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (main.tmp_add_button == 1)
                {
                    main.change = main.cash - main.totalamount;
                    MessageBox.Show("CUSTOMER CHANGE: " + main.change, "CHANGE");
                    customer.customer_table();
                    customer_payment.Enabled = false;
                    customer_payment.Visible = false;
                    categories.Enabled = false;
                    order.Enabled = false;
                    menu.Enabled = true;
                    add.Enabled = true;
                    summary.Enabled = false;
                    totalamount.Enabled = false;
                    admin.Enabled = true;
                    menu_datagrid.DataSource = null;
                    order_datagrid.DataSource = null;
                    summary_datagrid.DataSource = null;
                    customer_name.Text = "ENTER CUSTOMER NAME";
                    customer_name.ForeColor = Color.Gray;
                    customer_name.Enabled = true;
                    total.Text = "Php 0.00";
                    add.Enabled = false;
                    cash.Text = "";
                    receipt receipt = new receipt();
                    receipt.ShowDialog();
                }
            }
        }
    }
}
