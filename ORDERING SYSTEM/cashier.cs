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
    class cashier : main
    {
        //method to create cashier account
        public void cashier_account()
        {
            try
            {
                //check if the data for creating admin account is incomplete
                if (cashier_name == "ENTER CASHIER NAME" || cashier_username == "ENTER USERNAME" || cashier_password == "ENTER PASSWORD")
                {
                    MessageBox.Show("INCOMPLETE DATA TO CREATE ACCOUNT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tmp_add_button = 0;
                }
                else
                {
                    //check if the password and confirmpassword are match
                    if (cashier_password != cashier_confirm)
                    {
                        MessageBox.Show("PASSWORD DO NOT MATCH", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //sql query inserting username and password
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into CashierAccount(CashierName,Username,Password) values('" + cashier_name + "','" + cashier_username + "','" + cashier_password + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("ACCOUNT SUCCESSFULLY CREATED");
                        tmp_add_button = 1;
                    }
                }
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                //closing sql connection 
                con.Close();
            }
        }

        //method to search username account from cashier account table------------------------------------------------------------------------------------------------------------------
        public DataTable search_cashier()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                string sql = "select CashierName,Username from CashierAccount order by Username asc";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            else
            {
                con.Open();
                string sql = "select CashierName,Username from CashierAccount WHERE Username LIKE '%" + search + "%' order by Username asc";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
        }

        //method to delete data from cashier account table------------------------------------------------------------------------------------------------------------------
        public void delete_cashier()
        {
            try
            {
                DialogResult message = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS DATA?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (message == DialogResult.Yes)
                {
                    //sql query deleting data
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM CashierAccount WHERE Username = '" + selected_cell + "' ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("CASHIER ACCOUNT SUCCESSFULLY DELETED");
                    tmp_delete_button = 1;
                }
                else
                {
                    tmp_delete_button = 1;
                }

            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                //closing sql connection 
                con.Close();
            }
        }

        //method for finding cashier account in database
        public DataTable find_cashier()
        {
            DataTable dt = new DataTable();
            try
            {

                string sql = "Select Count(*) From CashierAccount WHERE CashierName = '" + cashier_name + "'";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

                if ("" + dt.Rows[0][0] == "1")
                {
                    tmp_update = 1;
                }
                else
                {
                    tmp_update = 0;
                    MessageBox.Show("INCORRECT NAME. PLEASE TRY AGAIN!");
                }
                con.Close();
                return dt;
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        //method to admin cashier account
        public DataTable update_cashier()
        {
            DataTable dt = new DataTable();

            try
            {
                if (cashier_username == "ENTER USERNAME" && cashier_password == "ENTER PASSWORD" && cashier_confirm == "CONFIRM PASSWORD")
                {
                    MessageBox.Show("NO CHANGES IN CASHIER ACCOUNT");
                    tmp_save = 1;
                }
                else if (cashier_password == "ENTER PASSWORD" && cashier_confirm == "CONFIRM PASSWORD")
                {
                    string sql1 = "UPDATE CashierAccount SET Username = '" + cashier_username + "' WHERE CashierName = '" + cashier_name + "'";
                    //Creating cmd using sql and con
                    SqlCommand cmd1 = new SqlCommand(sql1, con);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                    adapter1.Fill(dt);
                    MessageBox.Show("USERNAME OF CASHIER ACCOUNT SUCCESSFULLY UPDATED");
                    tmp_save = 1;
                }
                else if (cashier_username == "ENTER USERNAME")
                {
                    if (cashier_password == cashier_confirm)
                    {
                        string sql = "UPDATE CashierAccount SET Password = '" + cashier_password + "' WHERE CashierName = '" + cashier_name + "'";
                        //Creating cmd using sql and con
                        SqlCommand cmd = new SqlCommand(sql, con);
                        //Creating Sql DataAdapter using cmd
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        con.Open();
                        adapter.Fill(dt);
                        MessageBox.Show("PASSWORD OF CASHIER ACCOUNT SUCCESSFULLY UPDATED");
                        tmp_save = 1;
                    }
                    else
                    {
                        MessageBox.Show("PASSWORD DO NOT MATCH", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tmp_save = 0;
                    }
                }
                else if (username != "ENTER USERNAME" && password != "ENTER PASSWORD" && confirmpass != "CONFIRM PASSWORD")
                {
                    if (cashier_password == cashier_confirm)
                    {
                        string sql = "UPDATE CashierAccount SET Username = '" + cashier_username + "', Password = '" + cashier_password + "' WHERE CashierName = '" + cashier_name + "'";
                        //Creating cmd using sql and con
                        SqlCommand cmd = new SqlCommand(sql, con);
                        //Creating Sql DataAdapter using cmd
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        con.Open();
                        adapter.Fill(dt);
                        MessageBox.Show("USERNAME AND PASSWORD OF CASHIER ACCOUNT SUCCESSFULLY UPDATED");
                        tmp_save = 1;
                    }
                    else
                    {
                        MessageBox.Show("PASSWORD DO NOT MATCH", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tmp_save = 0;
                    }
                }
                con.Close();
                return dt;
            }
            catch 
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        //method for log in cashier account
        public DataTable log_cashier()
        {
            DataTable dt = new DataTable();
            try 
            {
                 string sql = "Select Count(*) From CashierAccount WHERE Username = '" + log_username + "' and Password = '" + log_password + "'";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

                if ("" + dt.Rows[0][0] == "1")
                {
                    tmp_log = 1;
                }
                else
                {
                    tmp_log = 0;
                    MessageBox.Show("USERNAME/PASSWORD IS INCORRECT. PLEASE TRY AGAIN!");
                }
                con.Close();
                return dt;
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
            }

        //get the cashier name in cashier account
        public DataTable cashier_record()
        {
            DataTable dt = new DataTable();
            try 
            {
                 string sql = "Select CashierName From CashierAccount WHERE Username = '" + log_username + "' and Password = '" + log_password + "'";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                cashier_name = dt.Rows[0][0].ToString();
                con.Close();
                return dt;
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        //insert record in cashier_record table
        public void insert_cashier()
        {
            //sql query inserting username and password
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into cashier_record(CashierName,Username,Date,Time) values('" + cashier_name + "','" + log_username + "','" + date + "','" + time + "')";
            cmd.ExecuteNonQuery();
        }

        //method to delete data from cashier log in record table------------------------------------------------------------------------------------------------------------------
        public void delete_record()
        {
            try
            {
                DialogResult message = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS DATA?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (message == DialogResult.Yes)
                {
                    //sql query deleting data
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM cashier_record WHERE Time = '" + selected_cell + "' ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("CASHIER LOG IN RECORD SUCCESSFULLY DELETED");
                    tmp_delete_button = 1;
                }
                else
                {
                    tmp_delete_button = 1;
                }

            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                //closing sql connection 
                con.Close();
            }
        }

        //method to search username account from cashier account table------------------------------------------------------------------------------------------------------------------
        public DataTable search_record()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                string sql = "select * from cashier_record order by CashierName asc";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            else
            {
                con.Open();
                string sql = "select * from cashier_record WHERE CashierName LIKE '%" + search + "%' order by CashierName asc";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
        }
        }
    }

