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
using System.Configuration;

namespace ORDERING_SYSTEM
{
    public partial class menu_database : Form
    {
        public menu_database()
        {
            InitializeComponent();
        }

        //initialization of class and form
        menu menu = new menu();
        main main = new main();

//function of event search, order_name,quanttity,price enter/leave menu_database form--------------------------------------------------------------------------------------------------------- 
        private void search_Enter(object sender, EventArgs e)
        {
            if (search.Text == "Search MenuID or OrderName")
            {
                search.Text = null;
                search.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "Search MenuID or OrderName";
                search.ForeColor = Color.Gray;
            }
        }

        private void order_name_Enter(object sender, EventArgs e)
        {
            if (order_name.Text == "ENTER ORDER NAME")
            {
                order_name.Text = null;
                order_name.ForeColor = Color.Black;
            }
        }

        private void order_name_Leave(object sender, EventArgs e)
        {
            if (order_name.Text == "")
            {
                order_name.Text = "ENTER ORDER NAME";
                order_name.ForeColor = Color.Gray;
            }

        }

        private void quantity_Enter(object sender, EventArgs e)
        {
            if (quantity.Text == "ENTER QUANTITY")
            {
                quantity.Text = null;
                quantity.ForeColor = Color.Black;
            }
        }

        private void quantity_Leave(object sender, EventArgs e)
        {
            if (quantity.Text == "")
            {
                quantity.Text = "ENTER QUANTITY";
                quantity.ForeColor = Color.Gray;
            }
        }

        private void price_Enter(object sender, EventArgs e)
        {
            if (price.Text == "ENTER PRICE")
            {
                price.Text = null;
                price.ForeColor = Color.Black;
            }
        }

        private void price_Leave(object sender, EventArgs e)
        {
            if (price.Text == "")
            {
                price.Text = "ENTER PRICE";
                price.ForeColor = Color.Gray;
            }
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && number != 8)
            {

                e.Handled = true;
            }
        }

        private void order_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsLetter(e.KeyChar) && number != 8 && number != 32)
            {

                e.Handled = true;
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && number != 8 && number != 46)
            {

                e.Handled = true;
            }
        }

        private void new_ordername_Enter(object sender, EventArgs e)
        {
            if (new_ordername.Text == "ENTER ORDER NAME")
            {
                new_ordername.Text = null;
                new_ordername.ForeColor = Color.Black;
            }
        }

        private void new_ordername_Leave(object sender, EventArgs e)
        {
            if (new_ordername.Text == "")
            {
                new_ordername.Text = "ENTER ORDER NAME";
                new_ordername.ForeColor = Color.Gray;
            }
        }

        private void new_quantity_Enter(object sender, EventArgs e)
        {
            if (new_quantity.Text == "ENTER QUANTITY")
            {
                new_quantity.Text = null;
                new_quantity.ForeColor = Color.Black;
            }
        }

        private void new_quantity_Leave(object sender, EventArgs e)
        {
            if (new_quantity.Text == "")
            {
                new_quantity.Text = "ENTER QUANTITY";
                new_quantity.ForeColor = Color.Gray;
            }
        }

        private void new_price_Enter(object sender, EventArgs e)
        {
            if (new_price.Text == "ENTER PRICE")
            {
                new_price.Text = null;
                new_price.ForeColor = Color.Black;
            }
        }

        private void new_price_Leave(object sender, EventArgs e)
        {
            if (new_price.Text == "")
            {
                new_price.Text = "ENTER PRICE";
                new_price.ForeColor = Color.Gray;
            }
        }

        private void new_ordername_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsLetter(e.KeyChar) && number != 8 && number != 32)
            {

                e.Handled = true;
            }
        }

        private void new_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && number != 8)
            {

                e.Handled = true;
            }
        }

        private void new_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && number != 8 && number != 46)
            {

                e.Handled = true;
            }
        }
        //end of function of event search, order_name,quanttity,price enter/leave 

//function of Event soup button click for menu database form---------------------------------------------------------------------------------------------------------------------- 
        private void soup_Click(object sender, EventArgs e)
        {
            search.Enabled = true;
            add.Enabled = true;
            delete.Enabled = false;
            update.Enabled = false;
            search.Text = "Search MenuID or OrderName";
            search.ForeColor = Color.Gray;

            main.categories = "SOUP";
            categories.Text = main.categories;
            //method for selecting data in menu_table
            menu_datagrid.DataSource = main.menu_select();
        }

//function of Event rice button click for menu database form----------------------------------------------------------------------------------------------------------------------
        private void rice_Click(object sender, EventArgs e)
        {
            search.Enabled = true;
            add.Enabled = true;
            delete.Enabled = false;
            update.Enabled = false;
            search.Text = "Search MenuID or OrderName";
            search.ForeColor = Color.Gray;
            
            main.categories = "RICE";
            categories.Text = main.categories;

            //method for selecting data in menu_table
            menu_datagrid.DataSource = main.menu_select();
        }

//function of Event porkchic button click for menu database form----------------------------------------------------------------------------------------------------------------------
        private void porkchic_Click(object sender, EventArgs e)
        {
            search.Enabled = true;
            add.Enabled = true;
            delete.Enabled = false;
            update.Enabled = false;
            search.Text = "Search MenuID or OrderName";
            search.ForeColor = Color.Gray;
            
            main.categories = "PORK AND CHICKEN";
            categories.Text = main.categories;

            //method for selecting data in menu_table
            menu_datagrid.DataSource = main.menu_select();
        }

//function of Event searfood button click for menu database form----------------------------------------------------------------------------------------------------------------------
        private void seafood_Click(object sender, EventArgs e)
        {
            search.Enabled = true;
            add.Enabled = true;
            delete.Enabled = false;
            update.Enabled = false;
            search.Text = "Search MenuID or OrderName";
            search.ForeColor = Color.Gray;
            
            main.categories = "SEAFOOD";
            categories.Text = main.categories;

            //method for selecting data in menu_table
            menu_datagrid.DataSource = main.menu_select();
        }

//function of Event vegetables button click for menu database form----------------------------------------------------------------------------------------------------------------------
        private void vegetables_Click(object sender, EventArgs e)
        {
            search.Enabled = true;
            add.Enabled = true;
            delete.Enabled = false;
            update.Enabled = false;
            search.Text = "Search MenuID or OrderName";
            search.ForeColor = Color.Gray;
            
            main.categories = "VEGETABLES";
            categories.Text = main.categories;

            //method for selecting data in menu_table
            menu_datagrid.DataSource = main.menu_select();
        }

//function of Event vegetables button click for menu database form----------------------------------------------------------------------------------------------------------------------
        private void noodles_Click(object sender, EventArgs e)
        {
            search.Enabled = true;
            add.Enabled = true;
            delete.Enabled = false;
            update.Enabled = false;
            main.categories = "NOODLES";
            search.Text = "Search MenuID or OrderName";
            search.ForeColor = Color.Gray;
            
            categories.Text = main.categories;

            //method for selecting data in menu_table
            menu_datagrid.DataSource = main.menu_select();
        }

//function of Event vegetables button click for menu database form----------------------------------------------------------------------------------------------------------------------
        private void drinks_Click(object sender, EventArgs e)
        {
            search.Enabled = true;
            add.Enabled = true;
            delete.Enabled = false;
            update.Enabled = false;
            main.categories = "DRINKS";
            search.Text = "Search MenuID or OrderName";
            search.ForeColor = Color.Gray;
            
            categories.Text = main.categories;

            //method for selecting data in menu_table
            menu_datagrid.DataSource = main.menu_select();
        }

//function of Event add button click for adding menu in menu database----------------------------------------------------------------------------------------------------------------------
        private void add_Click(object sender, EventArgs e)
        {
            //enable/disable buttons
            add.Enabled = false;
            update.Enabled = false;
            delete.Enabled = false;
            search.Enabled = false;
            soup.Enabled = false;
            rice.Enabled = false;
            porkchic.Enabled = false;
            seafood.Enabled = false;
            vegetables.Enabled = false;
            noodles.Enabled = false;
            drinks.Enabled = false;
            add_panel.Visible = true;
            menu_datagrid.Enabled = false;
            add_menu.Text = "ADD " + main.categories + " MENU";
        }

//function of Event save button click to insert new menu-------------------------------------------------------------------------------------------------------------------------------------------------------
        private void save_Click(object sender, EventArgs e)
        {
            if (order_name.Text == "ENTER ORDER NAME" || quantity.Text == "ENTER QUANTITY" || price.Text == "ENTER PRICE" || main.imagelocation == null)
            {
                MessageBox.Show("INCOMPLETE DATA TO " + add_menu.Text + "", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                main.tmp_add_button = 0;
            }
            else
            {
                main.order_name = order_name.Text;
                main.quantity = int.Parse(quantity.Text);
                main.price = double.Parse(price.Text);
                main.image = null;
                FileStream fs = new FileStream(main.imagelocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                main.image = br.ReadBytes((int)fs.Length);

                //method for adding menu
                menu.add_menu();

                //refresh data in datagridview
                menu_datagrid.DataSource = main.menu_select();
            }

            if (main.tmp_add_button == 1)
            {
                //enable/disable buttons
                add.Enabled = true;
                update.Enabled = false;
                delete.Enabled = false;
                search.Enabled = true;
                soup.Enabled = true;
                rice.Enabled = true;
                porkchic.Enabled = true;
                seafood.Enabled = true;
                vegetables.Enabled = true;
                noodles.Enabled = true;
                drinks.Enabled = true;
                add_panel.Visible = false;
                menu_datagrid.Enabled = true;
                order_name.Text = "ENTER ORDER NAME";
                quantity.Text = "ENTER QUANTITY";
                price.Text = "ENTER PRICE";
                order_name.ForeColor = Color.Gray;
                quantity.ForeColor = Color.Gray;
                price.ForeColor = Color.Gray;
                menu_picture.Image = Properties.Resources.menu1;
            }
        }
//function of Event cancel button click-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void cancel_Click(object sender, EventArgs e)
        {
            //enable/disable buttons
            add.Enabled = true;
            update.Enabled = false;
            delete.Enabled = false;
            search.Enabled = true;
            soup.Enabled = true;
            rice.Enabled = true;
            porkchic.Enabled = true;
            seafood.Enabled = true;
            vegetables.Enabled = true;
            noodles.Enabled = true;
            drinks.Enabled = true;
            add_panel.Visible = false;
            menu_datagrid.Enabled = true;
            order_name.Text = "ENTER ORDER NAME";
            quantity.Text = "ENTER QUANTITY";
            price.Text = "ENTER PRICE";
            order_name.ForeColor = Color.Gray;
            quantity.ForeColor = Color.Gray;
            price.ForeColor = Color.Gray;
            menu_picture.Image = Properties.Resources.menu1;
        }

//function of Event browse button click-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void browse_Click(object sender, EventArgs e)
        {
            //function for browsing picture on PC
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*png)|*.png|jpg files(*jpg)|*.jpg|All files(*.*)|*.*";
            dialog.Title = "Select Menu Picture";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                main.imagelocation = dialog.FileName.ToString();
                menu_picture.ImageLocation = main.imagelocation;
            }
        }

//function of search textbox------------------------------------------------------------------------------------------------------------------------------------------------------
        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //get the data from search textbox
            main.search = search.Text;

            //method for searching data
            menu_datagrid.DataSource = menu.menu_search();

            //disable/enable of button
            delete.Enabled = false;
            update.Enabled = false;
        }

//function of Event cellclick  for menu database datagrid-------------------------------------------------------------------------------------------------------------------------
        private void menu_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = menu_datagrid.Rows[index];
                main.selected_cell = selectedRow.Cells[0].Value.ToString();
                delete.Enabled = true;
                update.Enabled = true;

                //set data in update panel for ordername,quantity,price and menu picture
                label_update.Text = "UPDATE " + main.categories + " MENU";
                update_ordername.Text = selectedRow.Cells[1].Value.ToString();
                update_quantity.Text = selectedRow.Cells[2].Value.ToString();
                update_price.Text = selectedRow.Cells[3].Value.ToString();

                string con_string = ConfigurationManager.ConnectionStrings["con_string"].ConnectionString;
                SqlConnection con = new SqlConnection(con_string);
                String sql = "select MenuPicture from menu_table WHERE MenuID = " + main.selected_cell+ "";
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    byte[] img = (byte[])(reader[0]);
                    if (img == null)
                    {
                        update_pic.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        update_pic.Image = Image.FromStream(ms);
                    }
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("ERROR IN SELECTING CELL IN DATAGRID. PLEASE SELECT AGAIN ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                delete.Enabled = false;
                update.Enabled = false;
            }
        }

 //function of Event delete button click for menu database form----------------------------------------------------------------------------------------------------------- 
        private void delete_Click(object sender, EventArgs e)
        {
            //method for deleting menu data 
            menu.delete_menu();

            //method to refresh data in menu datagridview
            menu_datagrid.DataSource = main.menu_select();

            //Disabled delete button
            if (main.tmp_delete_button == 1)
            {
                delete.Enabled = false;
                update.Enabled = false;
                add.Enabled = true;
                search.Text = "Search MenuID or OrderName";
                search.ForeColor = Color.Gray;
           }
        }

 //function of Event update button click for menu database form-------------------------------------------------------------------------------------------------------------------- 
        private void update_Click(object sender, EventArgs e)
        {
            //enable/disable button
            add.Enabled = false;
            update.Enabled = false;
            delete.Enabled = false;
            update_panel.Visible = true;
            search.Enabled = false;
            soup.Enabled = false;
            rice.Enabled = false;
            porkchic.Enabled = false;
            seafood.Enabled = false;
            vegetables.Enabled = false;
            noodles.Enabled = false;
            drinks.Enabled = false;
            menu_datagrid.Enabled = false;
            search.Text = "Search MenuID or OrderName";
            search.ForeColor = Color.Gray;
        }

//function of Event update button click for menu database form------------------------------------------------------------------------------------------------------------------------------ 
        private void update_cancel_Click(object sender, EventArgs e)
        {
            //enable/disable button
            add.Enabled = true;
            update.Enabled = false;
            delete.Enabled = false;
            search.Enabled = true;
            soup.Enabled = true;
            rice.Enabled = true;
            porkchic.Enabled = true;
            seafood.Enabled = true;
            vegetables.Enabled = true;
            noodles.Enabled = true;
            drinks.Enabled = true;
            menu_datagrid.Enabled = true;
            search.Text = "Search MenuID or OrderName";
            search.ForeColor = Color.Gray;
            update_panel.Visible = false;
            new_update_pic.Image = Properties.Resources.menu1;
            new_ordername.Text = "ENTER ORDER NAME";
            new_quantity.Text = "ENTER QUANTITY";
            new_price.Text = "ENTER PRICE";
            new_ordername.ForeColor = Color.Gray;
            new_quantity.ForeColor = Color.Gray;
            new_price.ForeColor = Color.Gray;
        }

//function of Event browse button click-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void new_browse_Click(object sender, EventArgs e)
        {
            //function for browsing picture on PC
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*png)|*.png|jpg files(*jpg)|*.jpg|All files(*.*)|*.*";
            dialog.Title = "Select Menu Picture";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                main.imagelocation = dialog.FileName.ToString();
                new_update_pic.ImageLocation = main.imagelocation;
            }
        }

 //function of Event update button click for menu database form-----------------------------------------------------------------------------------------------------------------------------
        private void new_update_Click(object sender, EventArgs e)
        {
            //get the data of ordername,quantity,price and menu picture
            main.order_name = new_ordername.Text;

            if (new_quantity.Text == "ENTER QUANTITY")
            {
                main.quantity = 0;
            }
            else
            {
                main.quantity = int.Parse(new_quantity.Text);
            }
            if (new_price.Text == "ENTER PRICE")
            {
                main.price = 0;
            }
            else
            {
                main.price = double.Parse(new_price.Text);
            }
            try
                {
                    main.image = null;
                    FileStream fs = new FileStream(main.imagelocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    main.image = br.ReadBytes((int)fs.Length);
                }
                catch(Exception) 
                {
                }
           
            //method for updating menu
            menu_datagrid.DataSource = menu.update_menu();

            //method to refresh data in menu datagridview
            menu_datagrid.DataSource = main.menu_select();

            if (main.tmp_save == 1)
            {
                //enable/disable button
                add.Enabled = true;
                update.Enabled = false;
                delete.Enabled = false;
                search.Enabled = true;
                soup.Enabled = true;
                rice.Enabled = true;
                porkchic.Enabled = true;
                seafood.Enabled = true;
                vegetables.Enabled = true;
                noodles.Enabled = true;
                drinks.Enabled = true;
                menu_datagrid.Enabled = true;
                search.Text = "Search MenuID or OrderName";
                search.ForeColor = Color.Gray;
                update_panel.Visible = false;
                new_update_pic.Image = Properties.Resources.menu1;
                new_ordername.Text = "ENTER ORDER NAME";
                new_quantity.Text = "ENTER QUANTITY";
                new_price.Text = "ENTER PRICE";
                new_ordername.ForeColor = Color.Gray;
                new_quantity.ForeColor = Color.Gray;
                new_price.ForeColor = Color.Gray;
            }
        }
    }
}
