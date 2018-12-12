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
    public partial class Blaze : Form
    {
        List<string> names = new List<string>();
        List<double> prices = new List<double>();

        public Blaze()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(names, prices);
            checkout.ShowDialog();
        }

        private void pizza1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void pizza2_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void pizza3_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void pizza4_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void salad1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void salad2_Click(object sender, EventArgs e)
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

        private void dess1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void dess2_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        public void DisableButton()
        {
            pizza1.Enabled = false;
            pizza2.Enabled = false;
            pizza3.Enabled = false;
            pizza4.Enabled = false;
            salad1.Enabled = false;
            salad2.Enabled = false;
            side1.Enabled = false;
            side2.Enabled = false;
            dess1.Enabled = false;
            dess2.Enabled = false;
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
