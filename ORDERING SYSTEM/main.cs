using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

namespace ORDERING_SYSTEM
{
    public class main
    {
        //Connection string for database
        private static string con_string = ConfigurationManager.ConnectionStrings["con_string"].ConnectionString;
        public SqlConnection con = new SqlConnection(con_string);

        //DataTable variables---------------------------------------------------------------------------------------------------------------------
        public DataTable admin_account;

        //Global Variables-------------------------------------------------------------------------------------------------------------------------
        public static string firstname,lastname,username, password,confirmpass, search, selected_cell, selected_cell2, update_username;
        public static string update_password, save_username, save_password, log_username, log_password, categories,imagelocation;
        public static string customer_name;
        public static string order_name, str_customerID,date,time;
        public static int quantity, customerID, menuNo;
        public static int orderNo = 1;
        public static double price,totalamount,cash,change;
        public static byte[] image;
        public static string cashier_name, cashier_username, cashier_password,cashier_confirm;
        //tmp variables for enable/disable button and textbox
        public static int tmp_add_button,tmp_delete_button, tmp_search, tmp_update, tmp_save,tmp_log,tmp_image;
        public static int tmp_menu;
        //Method for Exit button-------------------------------------------------------------------------------------------------------------------
        public void exit()
        {
            DialogResult message = MessageBox.Show("EXIT THE PROGRAM?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Selecting data from admin_acount table--------------------------------------------------------------------------------------------------------------
        public void admin_account_select()
        {
            try
            {
                //sql query-----------------------------------------------------------------------------------------------------------------------------------
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select USERNAME from admin_account order by Username asc";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                admin_account  = dt;
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }
        }

        //Selecting data from customer table--------------------------------------------------------------------------------------------------------------
        public DataTable customer_select()
        {
            DataTable dt = new DataTable();
           try
           {
                //sql query-----------------------------------------------------------------------------------------------------------------------------------
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from customer_table order by CustomerID asc";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
           }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return dt;
            }
        }

        //Selecting data from order table---------------------------------------------------------------------------------------------------------------------
        public DataTable order_select()
        {
            DataTable dt = new DataTable();
            try
            {
                //sql query-----------------------------------------------------------------------------------------------------------------------------------
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Cashier,CustomerID,Name,OrderNo,OrderName,Price FROM order_table order by CustomerID asc";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        //Selecting data from summary table---------------------------------------------------------------------------------------------------------------------
        public DataTable summary_select()
        {
            DataTable dt = new DataTable();
            try
            {
                //sql query-----------------------------------------------------------------------------------------------------------------------------------
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Cashier,CustomerID, Name, OrderName, count(OrderName) as Quantity, sum(Price) as TotalAmount from order_table group by Cashier,CustomerID,Name,OrderName order by CustomerID asc";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        //Selecting data from customer table--------------------------------------------------------------------------------------------------------------------------------------
        public DataTable menu_select()
        {
            DataTable dt = new DataTable();
            try
            {
                //sql query-----------------------------------------------------------------------------------------------------------------------------------
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select MenuID, OrderName, Quantity, Price, MenuPicture from menu_table WHERE Categories = '" + categories + "' order by MenuID asc";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        //Selecting data from cashier table--------------------------------------------------------------------------------------------------------------------------------------
        public DataTable cashier_select()
        {
            DataTable dt = new DataTable();
            try
            {
                //sql query-----------------------------------------------------------------------------------------------------------------------------------
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select CashierName,Username from CashierAccount order by CashierName asc";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        //Selecting data from cashier log in record table--------------------------------------------------------------------------------------------------------------------------------------
        public DataTable cashier_record()
        {
            DataTable dt = new DataTable();
            try
            {
                //sql query-----------------------------------------------------------------------------------------------------------------------------------
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from cashier_record order by CashierName asc";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }
    }
}