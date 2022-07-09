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
    class customer : main
    {
        //method to delete data from customer table------------------------------------------------------------------------------------------------------------------
        public void delete_customer()
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
                    cmd.CommandText = "DELETE FROM customer_table WHERE CustomerID = '" + selected_cell + "' ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("CUSTOMER DATA SUCCESSFULLY DELETED");
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

        //method to delete data from customer table------------------------------------------------------------------------------------------------------------------
        public void delete_customer_order()
        {
            try
            {
                    //sql query deleting data
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM order_table WHERE CustomerID = '" + selected_cell + "' ";
                    cmd.ExecuteNonQuery();
                    tmp_delete_button = 1;
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
        //method to search data from customer table------------------------------------------------------------------------------------------------------------------
        public DataTable search_customer()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                dt = customer_select();
                return dt;
            }
            else
            {
                con.Open();
                string sql = "select * from customer_table WHERE CustomerID LIKE '%" + search + "%' or Name LIKE '%" + search + "%' or Date LIKE '%" + search + "%' or Cash LIKE '%" + search + "%' or TotalAmount LIKE '%" + search + "%' or Change LIKE '%" + search + "%' order by CustomerID asc";
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
