using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORDERING_SYSTEM
{
    public partial class receipt : Form
    {
        public receipt()
        {
            InitializeComponent();
        }
        customer_main customer = new customer_main();

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            name.Text = main.cashier_name;
            orderlist.DataSource = customer.menu_summary_select();
            time.Text = main.time;
            date.Text = main.date;
            total.Text = "Php " + main.totalamount;
            cash.Text = "Php " + main.cash;
            change.Text = "Php " + main.change;
        }
    }
}
