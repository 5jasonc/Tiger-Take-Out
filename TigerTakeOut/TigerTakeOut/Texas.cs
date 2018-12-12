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
    public partial class Texas : Form
    {

        List<string> names = new List<string>();
        List<double> prices = new List<double>();

        public Texas()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(names, prices);
            checkout.ShowDialog();
        }

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
            string foodItem12 = this.Text;
            foodItem12.Split('\n');

            if (foodItem12.Length == 2)
            {
                string foodName12 = char.ToString(foodItem12[0]);
                double foodPrice12 = Convert.ToDouble(foodItem12[1]);

                names.Add(foodName12);
                prices.Add(foodPrice12);

            }
            if (names.Count > 5 && prices.Count > 5)
            {
                DisableButton();
            }
        }

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
