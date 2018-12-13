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

            //honestly this was a last resort. it's so ugly, but we had no other choices and we just want to cry
            //sorry
            //This checks how many items are selected by the user, then adds them to the order slip on the checkout page
            //we left the code that shows the attempted better way of doing this :c
            if(names.Count == 1)
            {
                food1.Text = names[0];
                cost1.Text = Convert.ToString(prices[0]);
                food2.Text = "";
                cost2.Text = "";
                food3.Text = "";
                cost3.Text = "";
                food4.Text = "";
                cost4.Text = "";
                food5.Text = "";
                cost5.Text = "";

                Variables.subTotal = prices[0];
            } else if(names.Count == 2)
            {
                food1.Text = names[0];
                cost1.Text = Convert.ToString(prices[0]);
                food2.Text = names[1];
                cost2.Text = Convert.ToString(prices[1]);
                food3.Text = "";
                cost3.Text = "";
                food4.Text = "";
                cost4.Text = "";
                food5.Text = "";
                cost5.Text = "";

                Variables.subTotal = prices[0] + prices[1];
            } else if(names.Count == 3)
            {
                food1.Text = names[0];
                cost1.Text = Convert.ToString(prices[0]);
                food2.Text = names[1];
                cost2.Text = Convert.ToString(prices[1]);
                food3.Text = names[2];
                cost3.Text = Convert.ToString(prices[2]);
                food4.Text = "";
                cost4.Text = "";
                food5.Text = "";
                cost5.Text = "";

                Variables.subTotal = prices[0] + prices[1] + prices[2];
            } else if(names.Count == 4)
            {
                food1.Text = names[0];
                cost1.Text = Convert.ToString(prices[0]);
                food2.Text = names[1];
                cost2.Text = Convert.ToString(prices[1]);
                food3.Text = names[2];
                cost3.Text = Convert.ToString(prices[2]);
                food4.Text = names[3];
                cost4.Text = Convert.ToString(prices[3]);
                food5.Text = "";
                cost5.Text = "";

                Variables.subTotal = prices[0] + prices[1] + prices[2] + prices[3];
            } else if(names.Count == 5)
            {
                food1.Text = names[0];
                cost1.Text = Convert.ToString(prices[0]);
                food2.Text = names[1];
                cost2.Text = Convert.ToString(prices[1]);
                food3.Text = names[2];
                cost3.Text = Convert.ToString(prices[2]);
                food4.Text = names[3];
                cost4.Text = Convert.ToString(prices[3]);
                food5.Text = names[4];
                cost5.Text = Convert.ToString(prices[4]);

                Variables.subTotal = prices[0] + prices[1] + prices[2] + prices[3] + prices[4];
            }

            //this failed miserably, but we tried our best and that's what matters :/
            /*//adds items from user selection to a list 
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
            }*/

            //prints the total w/ 5.99 delivery fee 

            Variables.total = Variables.subTotal + 5.99;
            fullTotal.Text = Convert.ToString(Variables.total);

            stotal.Text = Convert.ToString(Variables.subTotal);

      
          
        




        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OrderTracking order = new OrderTracking();
            order.ShowDialog();
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            Variables.email = emailBox.Text;
        }

        private void streetBox_TextChanged(object sender, EventArgs e)
        {
            Variables.street = streetBox.Text;
        }

        private void aptBox_TextChanged(object sender, EventArgs e)
        {
            Variables.apptNum = aptBox.Text;
        }

        private void cityBox_TextChanged(object sender, EventArgs e)
        {
            Variables.city = cityBox.Text;
        }

        private void zipBox_TextChanged(object sender, EventArgs e)
        {
            Variables.zip = zipBox.Text;
        }
    }
}
