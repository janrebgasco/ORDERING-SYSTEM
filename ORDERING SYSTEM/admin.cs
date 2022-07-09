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
    class admin : main
    {
        //method for adding account in admin account-----------------------------------------------------------------------------------------------------
        public void add_admin_account()
        {
            try
            {
                //check if the data for creating admin account is incomplete
                if (firstname == "ENTER FIRST NAME" || lastname == "ENTER LAST NAME" || username == "ENTER USERNAME" || password == "ENTER PASSWORD" || confirmpass == "CONFIRM PASSWORD")
                {
                    MessageBox.Show("INCOMPLETE DATA TO CREATE ACCOUNT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tmp_add_button = 0;
                }
                else
                {
                    //check if the password and confirmpassword are match
                    if (password != confirmpass)
                    {
                        MessageBox.Show("PASSWORD DO NOT MATCH", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //sql query inserting username and password
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into admin_account(Username,Password,FirstName,LastName) values('" + username + "','" + password + "','" + firstname + "','" + lastname + "')";
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

        //method to delete data from admin account table------------------------------------------------------------------------------------------------------------------
        public void delete_data()
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
                    cmd.CommandText = "DELETE FROM admin_account WHERE Username = '" + selected_cell + "' ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ACCOUNT SUCCESSFULLY DELETED");
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

        //method to search username account from admin account table------------------------------------------------------------------------------------------------------------------
        public DataTable search_account()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                string sql = "select USERNAME from admin_account order by Username asc";
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
                string sql = "select USERNAME from admin_account WHERE Username LIKE '%" + search + "%' order by Username asc";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
        }

        //method to update account from admin account table------------------------------------------------------------------------------------------------------------------
        public DataTable update_account()
        {
            DataTable dt = new DataTable();

            try
            {

                string sql = "Select Count(*) From admin_account WHERE Username = '" + update_username + "' and Password = '" + update_password + "'";
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
                    MessageBox.Show("PASSWORD IS INCORRECT. PLEASE TRY AGAIN!");
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

        //method to update account from admin account table------------------------------------------------------------------------------------------------------------------
        public DataTable save_update_account()
        {
            DataTable dt = new DataTable();

            try
            {
                if (save_username == "ENTER NEW USERNAME" && save_password == "ENTER NEW PASSWORD")
                {
                    MessageBox.Show("NO CHANGES IN ADMIN ACCOUNT");
                    tmp_save = 1;
                }

                else if (save_username == "ENTER NEW USERNAME")
                {
                    string sql = "UPDATE admin_account SET Password = '" + save_password + "' WHERE Username = '" + update_username + "'";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    MessageBox.Show("NEW PASSWORD OF ADMIN ACCOUNT SUCCESSFULLY UPDATED");
                    tmp_save = 1;
                }

                else if (save_password == "ENTER NEW PASSWORD")
                {
                    string sql = "UPDATE admin_account SET Username = '" + save_username + "' WHERE Username = '" + update_username + "'";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    MessageBox.Show("NEW USERNAME OF ADMIN ACCOUNT SUCCESSFULLY UPDATED");
                    tmp_save = 1;
                }

                else if (save_username != "ENTER NEW USERNAME" && save_password != "ENTER NEW PASSWORD")
                {
                    string sql = "UPDATE admin_account SET Username = '" + save_username + "', Password = '" + save_password + "' WHERE Username = '" + update_username + "'";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    MessageBox.Show("NEW USERNAME AND NEW PASSWORD OF ADMIN ACCOUNT SUCCESSFULLY UPDATED");
                    tmp_save = 1;
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

        //method to Log in  admin account in admin log in form------------------------------------------------------------------------------------------------------------------
        public DataTable admin_log()
        {
            DataTable dt = new DataTable();

            try
            {

                string sql = "Select Count(*) From admin_account WHERE Username = '" + log_username + "' and Password = '" + log_password + "'";
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

        //method of forgot username and password admin account--------------------------------------------------------------------------------------------------------------------
        public DataTable find_account()
        {
            DataTable dt = new DataTable();

            try
            {

                string sql = "Select Count(*) From admin_account WHERE FirstName = '" + firstname + "' and LastName = '" + lastname + "'";
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

        //method of saving new username and password in recover admin account-----------------------------------------------------------------------------------------------------
        public DataTable forgot_save()
        {
            DataTable dt = new DataTable();

            try
            {   
                if (username == "ENTER NEW USERNAME" && password == "ENTER NEW PASSWORD" && confirmpass == "CONFIRM PASSWORD")
                {
                    MessageBox.Show("NO CHANGES IN ADMIN ACCOUNT");
                    tmp_save = 1;
                }

                else if (password == "ENTER NEW PASSWORD" && confirmpass == "CONFIRM PASSWORD")
                {
                    string sql = "Select Count(*) From admin_account WHERE Username = '" + username + "'";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);

                    if ("" + dt.Rows[0][0] == "1")
                    {
                        MessageBox.Show("USERNAME ALREADY EXIST", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tmp_save = 0;
                    }
                    else
                    {
                        string sql1 = "UPDATE admin_account SET Username = '" + username + "' WHERE FirstName = '" + firstname + "' and LastName = '" + lastname + "'";
                        //Creating cmd using sql and con
                        SqlCommand cmd1 = new SqlCommand(sql1, con);
                        //Creating Sql DataAdapter using cmd
                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                        adapter1.Fill(dt);
                        MessageBox.Show("USERNAME OF ADMIN ACCOUNT SUCCESSFULLY CHANGED");
                        tmp_save = 1;
                    }
                }

                else if (username == "ENTER NEW USERNAME")
                {
                    if (password == confirmpass)
                    {
                        string sql = "UPDATE admin_account SET Password = '" + password + "' WHERE FirstName = '" + firstname + "' and LastName = '" + lastname + "'";
                        //Creating cmd using sql and con
                        SqlCommand cmd = new SqlCommand(sql, con);
                        //Creating Sql DataAdapter using cmd
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        con.Open();
                        adapter.Fill(dt);
                        MessageBox.Show("PASSWORD OF ADMIN ACCOUNT SUCCESSFULLY CHANGED");
                        tmp_save = 1;
                    }
                    else
                    {
                        MessageBox.Show("PASSWORD DO NOT MATCH", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tmp_save = 0;
                    }
                }

                else if (username != "ENTER NEW USERNAME" && password != "ENTER NEW PASSWORD" && confirmpass != "CONFIRM PASSWORD")
                {
                    string sql = "Select Count(*) From admin_account WHERE Username = '" + username + "'";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);

                    if ("" + dt.Rows[0][0] == "1")
                    {
                        MessageBox.Show("USERNAME ALREADY EXIST", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tmp_save = 0;
                    }
                    else
                    {
                        if (password == confirmpass)
                        {
                            string sql1 = "UPDATE admin_account SET Username = '" + username + "', Password = '" + password + "' WHERE FirstName = '" + firstname + "' and LastName = '" + lastname + "'";
                            //Creating cmd using sql and con
                            SqlCommand cmd1 = new SqlCommand(sql1, con);
                            //Creating Sql DataAdapter using cmd
                            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                            adapter1.Fill(dt);
                            MessageBox.Show("USERNAME AND PASSWORD OF ADMIN ACCOUNT SUCCESSFULLY CHANGED");
                            tmp_save = 1;
                        }
                        else
                        {
                            MessageBox.Show("PASSWORD DO NOT MATCH", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tmp_save = 0;
                        }
                    }
                }
                con.Close();
                return dt;
            }
            catch
            {
                tmp_save = 0;
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }
    }
}
