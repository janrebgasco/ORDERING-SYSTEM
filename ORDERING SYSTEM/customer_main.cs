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
    class customer_main : main
    {
        //method for adding order in order database-----------------------------------------------------------------------------------------------------
        public void add_order()
        {
            try
            {
                if (main.quantity != 0)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into order_table(CustomerID,Name,Categories,MenuNo,OrderNo,OrderName,Price,Cashier) values('" + str_customerID + "','" + customer_name + "','" + categories + "'," + menuNo + ",'" + orderNo + "','" + order_name + "'," + price + ",'" + cashier_name + "')";
                    cmd.ExecuteNonQuery();
                    tmp_add_button = 1;
                }
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tmp_add_button = 0;
            }
            finally
            {
                //closing sql connection 
                con.Close();
            }
        }

        //method for selecting data in order database-----------------------------------------------------------------------------------------------------
        public DataTable menu_order_select()
        {
            DataTable dt = new DataTable();
            try
            {
                //sql query-----------------------------------------------------------------------------------------------------------------------------------
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select OrderNo,OrderName,Price FROM order_table where CustomerID = '" + str_customerID + "'  order by OrderNo asc";
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

        //method for selecting data in order database-----------------------------------------------------------------------------------------------------
        public DataTable menu_summary_select()
        {
            DataTable dt = new DataTable();
            try
            {
                //sql query-----------------------------------------------------------------------------------------------------------------------------------
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select OrderName, count(OrderName) as Quantity, sum(Price) as TotalAmount from order_table where CustomerID = '" + str_customerID + "' group by OrderName order by orderName asc";
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

        //method to generate customerID------------------------------------------------------------------------------------------------------------------
        public DataTable generate_customerID()
        {
            DataTable dt = new DataTable();
            try
            {

                string sql = "Select isnull(MAX(cast(CustomerID as int)),0) + 1 FROM order_table";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                str_customerID = dt.Rows[0][0].ToString();
                con.Close();
                return dt;
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        //method to update menu from menu table-----------------------------------------------------------------------------------------------------------------------------------
        public DataTable update_menu()
        {
            DataTable dt = new DataTable();
            try
            {
                    string sql = "UPDATE menu_table SET Quantity = '" + quantity + "' WHERE MenuID = '" + menuNo + "'";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    tmp_add_button = 1;
                    con.Close();
                    return dt; 
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        //method to delete data from order table------------------------------------------------------------------------------------------------------------------
        public void delete_order()
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
                    cmd.CommandText = "DELETE FROM order_table WHERE CustomerID = '" + str_customerID + "' and OrderNo = '" + orderNo + "'";
                    cmd.ExecuteNonQuery();
                    tmp_delete_button = 1;
                    MessageBox.Show("ORDER SUCCESSFULLY DELETED");
                }
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tmp_delete_button = 0;
            }
            finally
            {
                //closing sql connection 
                con.Close();
            }
        }

        //method to delete data from order table------------------------------------------------------------------------------------------------------------------
        public void delete_summary()
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
                    cmd.CommandText = "DELETE FROM order_table WHERE CustomerID = '" + str_customerID + "' and OrderName = '" + order_name + "'";
                    cmd.ExecuteNonQuery();
                    tmp_delete_button = 1;
                    MessageBox.Show("ORDER SUCCESSFULLY DELETED");
                }
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tmp_delete_button = 0;
            }
            finally
            {
                //closing sql connection 
                con.Close();
            }
        }

        //method for adding Customer data in customer database-----------------------------------------------------------------------------------------------------
        public void customer_table()
        {
            try
            {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into customer_table(CustomerID,Name,Date,Time,TotalAmount,Cash,Change,Cashier)values('" + str_customerID + "','" + customer_name + "','" + date + "','" + time + "','" + totalamount + "','" + cash + "','" + change + "','" + cashier_name + "')";
                    cmd.ExecuteNonQuery();
                    tmp_add_button = 1;
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tmp_add_button = 0;
            }
            finally
            {
                //closing sql connection 
                con.Close();
            }
        }
    }
}
