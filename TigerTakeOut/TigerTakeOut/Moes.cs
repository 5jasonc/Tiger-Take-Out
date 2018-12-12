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
    public partial class Moes : Form
    {
        List<string> names = new List<string>();
        List<double> prices = new List<double>();

        public Moes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void burrito2_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void burrito3_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void burrito4_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void dilla1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void dila2_Click(object sender, EventArgs e)
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

        private void side3_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void side4_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void taco1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void taco2_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(names, prices);
            checkout.ShowDialog();
        }

        public void DisableButton()
        {
            button1.Enabled = false;
            burrito2.Enabled = false;
            burrito3.Enabled = false;
            dilla1.Enabled = false;
            dila2.Enabled = false;
            side1.Enabled = false;
            side2.Enabled = false;
            side3.Enabled = false;
            side4.Enabled = false;
            taco1.Enabled = false;
            taco2.Enabled = false;
            burrito4.Enabled = false;
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
