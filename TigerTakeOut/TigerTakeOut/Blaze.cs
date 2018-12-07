﻿using System;
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

        private void pizza2_Click(object sender, EventArgs e)
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

        private void pizza3_Click(object sender, EventArgs e)
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

        private void pizza4_Click(object sender, EventArgs e)
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

        private void salad1_Click(object sender, EventArgs e)
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

        private void salad2_Click(object sender, EventArgs e)
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

        private void dess1_Click(object sender, EventArgs e)
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

        private void dess2_Click(object sender, EventArgs e)
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
    }
}
