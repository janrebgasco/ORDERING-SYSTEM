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
    class menu : main
    {
        //method for adding menu in menu database-----------------------------------------------------------------------------------------------------
        public void add_menu()
        {
            try
            {
                 con.Open();
                 SqlCommand cmd = con.CreateCommand();
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "insert into menu_table(Categories,OrderName,Quantity,Price,MenuPicture) values('"+categories+"','"+order_name+"','"+quantity+"',"+price+",@image)";
                 cmd.Parameters.AddWithValue("@image", main.image);
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("MENU SUCCESSFULLY SAVED");
                 main.imagelocation = null;
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

        //method to search data from menu table------------------------------------------------------------------------------------------------------------------
        public DataTable menu_search()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                dt = menu_select();
                return dt;
            }
            else
            {
                con.Open();
                string sql = "select  MenuID, OrderName, Quantity, Price, MenuPicture from menu_table WHERE MenuID LIKE '%" + search + "%' or OrderName LIKE '%" + search + "%' order by MenuID asc";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
        }

        //method to delete data from menu table------------------------------------------------------------------------------------------------------------------
        public void delete_menu()
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
                    cmd.CommandText = "DELETE FROM menu_table WHERE MenuID = '" + selected_cell + "' ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("MENU DATA SUCCESSFULLY DELETED");
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

        //method to update menu from menu table-----------------------------------------------------------------------------------------------------------------------------------
        public DataTable update_menu()
        {
            DataTable dt = new DataTable();
            try
            {
                if (main.order_name == "ENTER ORDER NAME" && main.quantity == 0 && main.price == 0 && main.imagelocation == null)
                {
                    MessageBox.Show("NO CHANGES IN " + main.categories + " MENU");
                    main.tmp_save = 1;
                }

                else if (quantity == 0 && price == 0 && imagelocation == null)
                {
                    string sql = "UPDATE menu_table SET OrderName = '" + order_name + "' WHERE MenuID = '" + selected_cell + "'";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    MessageBox.Show("NEW ORDER NAME IN "+ main.categories +  " MENU SUCCESSFULLY UPDATED");
                    tmp_save = 1;
                }

                else if (main.order_name == "ENTER ORDER NAME" && main.price == 0 && main.imagelocation == null)
                {
                    string sql = "UPDATE menu_table SET Quantity = '" + quantity + "' WHERE MenuID = '" + selected_cell + "'";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    MessageBox.Show("NEW QUANTITY IN " + main.categories + " MENU SUCCESSFULLY UPDATED");
                    tmp_save = 1;
                }

                else if (main.order_name == "ENTER ORDER NAME" && main.quantity == 0 && main.imagelocation == null)
                {
                    string sql = "UPDATE menu_table SET Price = '" + price + "' WHERE MenuID = '" + selected_cell + "'";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    MessageBox.Show("NEW PRICE IN " + main.categories + " MENU SUCCESSFULLY UPDATED");
                    tmp_save = 1;
                }

                else if (main.order_name == "ENTER ORDER NAME" && main.quantity == 0 && main.price == 0)
                {
                    string sql = "UPDATE menu_table SET MenuPicture = @image WHERE MenuID = '" + selected_cell + "'";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@image", main.image);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    MessageBox.Show("NEW MENU PICTURE IN " + main.categories + " MENU SUCCESSFULLY UPDATED");
                    tmp_save = 1;
                }

                else if (main.order_name != "ENTER ORDER NAME" && main.quantity != 0 && main.price != 0 && main.imagelocation != null)
                {
                    string sql = "UPDATE menu_table SET OrderName = '" + order_name + "', Quantity = '" + quantity + "', Price = '" + price + "', MenuPicture = @image WHERE MenuID = '" + selected_cell + "'";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@image", main.image);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    MessageBox.Show( main.categories + " MENU SUCCESSFULLY UPDATED");
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
    }
}
