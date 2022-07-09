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
    class summary : main
    {
        //method to delete data from summary table------------------------------------------------------------------------------------------------------------------
        public void delete_Summary()
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
                    cmd.CommandText = "DELETE FROM order_table WHERE CustomerID = '" + selected_cell + "' and OrderName = '" + selected_cell2 + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ORDER DATA SUCCESSFULLY DELETED");
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

        //method to search data from summary table------------------------------------------------------------------------------------------------------------------
        public DataTable search_order()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                dt = summary_select();
                return dt;
            }
            else
            {
                con.Open();
                string sql = "Select CustomerID, Name, OrderName, count(OrderName) as Quantity, sum(Price) as TotalAmount from order_table where CustomerID LIKE '%" + search + "%' or Name LIKE '%" + search + "%' group by CustomerID,Name,OrderName order by OrderName asc";
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
