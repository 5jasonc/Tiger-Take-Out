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
    //Functions and events for the Texas Bar-B-Q Joint's menu
    //clicking up to five food items will push their price and name to the list
    //clicking the "checkout" button will open the checkout form and pass through the lists containing the selected food items
    public partial class Texas : Form
    {
        //global lists that will hold the names and prices of each food item
        List<string> names = new List<string>();
        List<double> prices = new List<double>();

        public Texas()
        {
            InitializeComponent();
        }

        //click event for the checkout button, opens the checkout form and passes in the two lists as parameters to be used on the next form
        private void button13_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(names, prices);
            checkout.ShowDialog();
        }

        //click events for each menu item, calls the GetItems function for each and passes in the sender object 
        private void sand1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void sand2_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void sand3_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void sand4_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void potat1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void potat2_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void side1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void side2_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void platter1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void platter2_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void side3_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void side4_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        //Function to disable all the buttons on the page by setting the Enabled boolen to false for each
        //lets user know the cart is full and to proceed to checkout
        public void DisableButton()
        {
            sand1.Enabled = false;
            sand2.Enabled = false;
            sand3.Enabled = false;
            sand4.Enabled = false;
            potat1.Enabled = false;
            potat2.Enabled = false;
            platter1.Enabled = false;
            platter2.Enabled = false;
            side1.Enabled = false;
            side2.Enabled = false;
            side3.Enabled = false;
            side4.Enabled = false;

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
                string foodName10 = char.ToString(foodItem[0]);
                double foodPrice10 = Convert.ToDouble(foodItem[1]);

                names.Add(foodName10);
                prices.Add(foodPrice10);

            }

            if (names.Count > 5 && prices.Count > 5)
            {
                DisableButton();
            }
        }
    }
}
