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
    public partial class Mandarin : Form
    {
        List<string> names = new List<string>();
        List<double> prices = new List<double>();

        public Mandarin()
        {
            InitializeComponent();
        }

        private void chef1_Click(object sender, EventArgs e)
        {
            GetItems(sender);
        }

        public void DisableButton()
        {
            chef1.Enabled = false;
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
