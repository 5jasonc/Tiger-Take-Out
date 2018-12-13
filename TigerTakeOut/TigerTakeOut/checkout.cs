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
    public partial class Checkout : Form
    {
        public Checkout(List<string> names, List<double> prices)
        {

            InitializeComponent();


            //adds items from user selection to a list 
            Variables.items.Add(food1);
            Variables.items.Add(food2);
            Variables.items.Add(food3.Text);
            Variables.items.Add(food4.Text);
            Variables.items.Add(food5.Text);
            //adds the prices from user selection to a list
            Variables.costs.Add(Convert.ToDouble(cost1.Text));
            Variables.costs.Add(Convert.ToDouble(cost2.Text));
            Variables.costs.Add(Convert.ToDouble(cost3.Text));
            Variables.costs.Add(Convert.ToDouble(cost4.Text));
            Variables.costs.Add(Convert.ToDouble(cost5.Text));

            //"prints" item names and prices to shopping cart receipt
            for(int i = 0; i < names.Count-1; i++)
            {
                Variables.items[i].Text = names[i];
                Variables.costs[i] = prices[i];

                Variables.subTotal += prices[i];
                stotal.Text = Convert.ToString(Variables.subTotal);
            }

            //prints the total w/ 5.99 delivery fee 
            Variables.total = Variables.subTotal + 5.99;
            fullTotal.Text = Convert.ToString(Variables.total);
            Variables.email = emailBox.Text;
            Variables.street = streetBox.Text;
            Variables.city = cityBox.Text;
            //Variables.zip = Convert.ToDouble(zipBox.Text);



        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OrderTracking order = new OrderTracking();
            order.ShowDialog();
        }


    }
}
