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
            string foodItem = this.Text;
            foodItem.Split('\n');

            if (foodItem.Length == 2)
            {
                string foodName = char.ToString(foodItem[0]);
                double foodPrice = Convert.ToDouble(foodItem[1]);

                names.Add(foodName);
                prices.Add(foodPrice);

            }
        }

        private void sand2_Click(object sender, EventArgs e)
        {
            string foodItem2 = this.Text;
            foodItem2.Split('\n');

            if (foodItem2.Length == 2)
            {
                string foodName2 = char.ToString(foodItem2[0]);
                double foodPrice2 = Convert.ToDouble(foodItem2[1]);

                names.Add(foodName2);
                prices.Add(foodPrice2);

            }
        }

        private void sand3_Click(object sender, EventArgs e)
        {
            string foodItem3 = this.Text;
            foodItem3.Split('\n');

            if (foodItem3.Length == 2)
            {
                string foodName3 = char.ToString(foodItem3[0]);
                double foodPrice3 = Convert.ToDouble(foodItem3[1]);

                names.Add(foodName3);
                prices.Add(foodPrice3);

            }
        }

        private void sand4_Click(object sender, EventArgs e)
        {
            string foodItem4 = this.Text;
            foodItem4.Split('\n');

            if (foodItem4.Length == 2)
            {
                string foodName4 = char.ToString(foodItem4[0]);
                double foodPrice4 = Convert.ToDouble(foodItem4[1]);

                names.Add(foodName4);
                prices.Add(foodPrice4);

            }
        }

        private void potat1_Click(object sender, EventArgs e)
        {
            string foodItem5 = this.Text;
            foodItem5.Split('\n');

            if (foodItem5.Length == 2)
            {
                string foodName5 = char.ToString(foodItem5[0]);
                double foodPrice5 = Convert.ToDouble(foodItem5[1]);

                names.Add(foodName5);
                prices.Add(foodPrice5);

            }
        }

        private void potat2_Click(object sender, EventArgs e)
        {
            string foodItem6 = this.Text;
            foodItem6.Split('\n');

            if (foodItem6.Length == 2)
            {
                string foodName6 = char.ToString(foodItem6[0]);
                double foodPrice6 = Convert.ToDouble(foodItem6[1]);

                names.Add(foodName6);
                prices.Add(foodPrice6);

            }
        }

        private void side1_Click(object sender, EventArgs e)
        {
            string foodItem7 = this.Text;
            foodItem7.Split('\n');

            if (foodItem7.Length == 2)
            {
                string foodName7 = char.ToString(foodItem7[0]);
                double foodPrice7 = Convert.ToDouble(foodItem7[1]);

                names.Add(foodName7);
                prices.Add(foodPrice7);

            }
        }

        private void side2_Click(object sender, EventArgs e)
        {
            string foodItem8 = this.Text;
            foodItem8.Split('\n');

            if (foodItem8.Length == 2)
            {
                string foodName8 = char.ToString(foodItem8[0]);
                double foodPrice8 = Convert.ToDouble(foodItem8[1]);

                names.Add(foodName8);
                prices.Add(foodPrice8);

            }
        }

        private void platter1_Click(object sender, EventArgs e)
        {
            string foodItem9 = this.Text;
            foodItem9.Split('\n');

            if (foodItem9.Length == 2)
            {
                string foodName9 = char.ToString(foodItem9[0]);
                double foodPrice9 = Convert.ToDouble(foodItem9[1]);

                names.Add(foodName9);
                prices.Add(foodPrice9);

            }
        }

        private void platter2_Click(object sender, EventArgs e)
        {
            string foodItem10 = this.Text;
            foodItem10.Split('\n');

            if (foodItem10.Length == 2)
            {
                string foodName10 = char.ToString(foodItem10[0]);
                double foodPrice10 = Convert.ToDouble(foodItem10[1]);

                names.Add(foodName10);
                prices.Add(foodPrice10);

            }
        }

        private void side3_Click(object sender, EventArgs e)
        {
            string foodItem11 = this.Text;
            foodItem11.Split('\n');

            if (foodItem11.Length == 2)
            {
                string foodName11 = char.ToString(foodItem11[0]);
                double foodPrice11 = Convert.ToDouble(foodItem11[1]);

                names.Add(foodName11);
                prices.Add(foodPrice11);

            }
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
        }
    }
}
