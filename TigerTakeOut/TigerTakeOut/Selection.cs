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
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int select = comboBox1.SelectedIndex;

            if(select == 0)
            {
                Mandarin mandarin = new Mandarin();
                mandarin.ShowDialog();
            } else if (select == 1)
            {
                Apple applebees = new Apple();
                applebees.ShowDialog();
            } else if (select == 2)
            {
                Blaze blaze = new Blaze();
                blaze.ShowDialog();
            } else if (select == 3)
            {
                Moes moes = new Moes();
                moes.ShowDialog();
            } else if (select == 4)
            {
                Texas texas = new Texas();
                texas.ShowDialog();
            }
        }
    }
}
