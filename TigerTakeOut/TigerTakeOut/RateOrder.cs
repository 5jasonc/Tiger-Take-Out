using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Jason Streeter
// 12/15/18
// Tiger Take Out
// RateOrder.cs - holds event for closing the review page

namespace TigerTakeOut
{
    public partial class RateOrder : Form
    {
        public RateOrder()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
