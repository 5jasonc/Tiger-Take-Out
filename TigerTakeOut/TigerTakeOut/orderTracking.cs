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
// OrderTracking.cs - holds all events on the order tracking form.

namespace TigerTakeOut
{
    public partial class OrderTracking : Form
    {
        // Fields //
        CancelOrder cancelForm = new CancelOrder();
        RateOrder rateForm = new RateOrder();

        // Constructor //
        public OrderTracking()
        {
            InitializeComponent();
            orderTimer.Start();

            email.Text = Variables.email;
            street.Text = Variables.street;
            apt.Text = Variables.apptNum;
            city.Text = Variables.city;
            zip.Text = Variables.zip;
        }

        // Events //

        // Progresses order progress bar and updates information about progress of order
        private void orderTimer_Tick(object sender, EventArgs e)
        {
            // Increases progress bar to indicate order being completed
            if (orderProgress.Value < orderProgress.Maximum)
            {
                orderProgress.Value += orderProgress.Step;
            }

            // Change flavor text below progress bar to update user, opens order review form when order is delivered
            if(orderProgress.Value < 200) { orderInfoLabel.Text = "Preparing order..."; }
            else if(orderProgress.Value < 350) { orderInfoLabel.Text = "Finishing your order..."; }
            else if(orderProgress.Value < orderProgress.Maximum) { orderInfoLabel.Text = "Order is on its way!"; }
            else
            {
                orderInfoLabel.Text = "Order delivered!";
                orderTimer.Stop();
                rateForm.ShowDialog();            
                this.Close();
            }
        }

        // Opens new form to confirm user wants to cancel order, acts accordingly based on user choice
        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            if (!cancelForm.IsOrderCancelled() && orderProgress.Value < orderProgress.Maximum)
            {
                cancelForm.ShowDialog();

                if (cancelForm.IsOrderCancelled())
                {
                    orderTimer.Stop();
                    orderInfoLabel.Text = "Order cancelled...";
                }
            }
            else if(!cancelForm.IsOrderCancelled()) { MessageBox.Show("Your order has already been delivered!"); }
            else { MessageBox.Show("Order has already been cancelled!"); }
        }
    }
}
