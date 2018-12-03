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
// 12/3/18
// Tiger Take Out
// orderTracking.cs - holds all events on the order tracking form.

namespace TigerTakeOut
{
    public partial class orderTracking : Form
    {
        public orderTracking()
        {
            InitializeComponent();
            orderTimer.Start();
        }

        private void orderTimer_Tick(object sender, EventArgs e)
        {
            // Increases progress bar to indicate order being completed
            if (orderProgress.Value < orderProgress.Maximum)
            {
                orderProgress.Value += orderProgress.Step;
            }

            // Change flavor text below progress bar to update user
            if(orderProgress.Value < 200) { orderInfoLabel.Text = "Preparing order..."; }
            else if(orderProgress.Value < 350) { orderInfoLabel.Text = "Finishing your order..."; }
            else { orderInfoLabel.Text = "Order is on its way!"; }
        }

        private void complaintNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void orderIssueLabel_Click(object sender, EventArgs e)
        {

        }

        private void orderSummaryLabel_Click(object sender, EventArgs e)
        {

        }

        private void studentIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
