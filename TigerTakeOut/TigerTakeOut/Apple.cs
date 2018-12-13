using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TigerTakeOut
{
    public partial class Apple : Form
    {

        public Apple()
        {
            InitializeComponent();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(Variables.names, Variables.prices);
            checkout.ShowDialog();
        }

        private void grill1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void grill2_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void grill3_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void grill4_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void chick1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void chick2_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void sand1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void sand2_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void app1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void app2_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void app3_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void app4_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        public void DisableButton()
        {
            grill1.Enabled = false;
            grill2.Enabled = false;
            grill3.Enabled = false;
            grill4.Enabled = false;
            chick1.Enabled = false;
            chick2.Enabled = false;
            sand1.Enabled = false;
            sand2.Enabled = false;
            app1.Enabled = false;
            app2.Enabled = false;
            app3.Enabled = false;
            app4.Enabled = false;

            MessageBox.Show("Cart full, please proceed to checkout");

        }

        //Function to split the text within the passed in sender object (from the menu item buttons)
        //Once the button text is split on the line break, check to make sure there are two items in the temporary foodItem array
        //if the temporary array has two items within it, convert the first item(menu item name) to a string and convert the second menu item price) to a double. Then, push each into their respective lists.
        //if the lists have five objects each (five food items and their prices), all buttons will be disabled and the user is prompted to checkout

        public void GetItems(object sender)
        {
            string foodItem = ((Button)sender).Text;
            foodItem.Split('\n');

            if (foodItem.Length == 2)
            {
                string foodName = char.ToString(foodItem[0]);
                double foodPrice = Convert.ToDouble(foodItem[1]);

                Variables.names.Add(foodName);
                Variables.prices.Add(foodPrice);

            }

            if (Variables.names.Count > 5 && Variables.prices.Count > 5)
            {
                DisableButton();
            }
        }

    }
}
