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
            Variables.items.Add(item1.Text);
            Variables.items.Add(item2.Text);
            Variables.items.Add(item3.Text);
            Variables.items.Add(item4.Text);
            Variables.items.Add(item5.Text);
            //adds the prices from user selection to a list
            Variables.costs.Add(Convert.ToDouble(price1.Text));
            Variables.costs.Add(Convert.ToDouble(price2.Text));
            Variables.costs.Add(Convert.ToDouble(price3.Text));
            Variables.costs.Add(Convert.ToDouble(price4.Text));
            Variables.costs.Add(Convert.ToDouble(price5.Text));

            //"prints" item names and prices to shopping cart receipt
            for(int i = 0; i < names.Count; i++)
            {
                Variables.items[i] = names[i];
                Variables.costs[i] = prices[i];

                Variables.subTotal += prices[i];
            }

            //prints the total w/ 5.99 delivery fee
            Variables.total = Variables.subTotal + 5.99;


        }

        private void orderBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
