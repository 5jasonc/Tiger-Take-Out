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
            string foodItem = this.Text;
            foodItem.Split('\n');

            if (foodItem.Length == 2)
            {
                string foodName = char.ToString(foodItem[0]);
                double foodPrice = Convert.ToDouble(foodItem[1]);

                names.Add(foodName);
                prices.Add(foodPrice);
            }
            if (names.Count > 5)
            {
                DisableButton();
            }
        }

        private void grill2_Click(object sender, EventArgs e)
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
            if (names.Count > 5)
            {
                DisableButton();
            }
        }

        private void grill3_Click(object sender, EventArgs e)
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
            if (names.Count > 5)
            {
                DisableButton();
            }
        }

        private void grill4_Click(object sender, EventArgs e)
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
            if (names.Count > 5)
            {
                DisableButton();
            }
        }

        private void chick1_Click(object sender, EventArgs e)
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
            if (names.Count > 5)
            {
                DisableButton();
            }
        }

        private void chick2_Click(object sender, EventArgs e)
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
            if (names.Count > 5)
            {
                DisableButton();
            }
        }

        private void sand1_Click(object sender, EventArgs e)
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
            if (names.Count > 5)
            {
                DisableButton();
            }
        }

        private void sand2_Click(object sender, EventArgs e)
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
            if(names.Count > 5)
            {
                DisableButton();
            }
        }

        private void app1_Click(object sender, EventArgs e)
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
            if (names.Count > 5)
            {
                DisableButton();
            }
        }

        private void app2_Click(object sender, EventArgs e)
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
            if (names.Count > 5)
            {
                DisableButton();
            }
        }

        private void app3_Click(object sender, EventArgs e)
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
            if (names.Count > 5)
            {
                DisableButton();
            }
        }

        private void app4_Click(object sender, EventArgs e)
        {
            string foodItem8 = this.Text;
            foodItem8.Split('\n');

            if (foodItem8.Length == 2)
            {
                string foodName9 = char.ToString(foodItem8[0]);
                double foodPrice10 = Convert.ToDouble(foodItem8[1]);

                    names.Add(foodName9);
                    prices.Add(foodPrice10);
           
            }
            if (names.Count > 5)
            {
                DisableButton();
            }
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

    }
}
