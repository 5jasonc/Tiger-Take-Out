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
        List<string> names = new List<string>();
        List<double> prices = new List<double>();
        public Apple()
        {
            InitializeComponent();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(names, prices);
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
            
        }

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
