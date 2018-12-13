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
// 12/5/18
// Tiger Take Out
// CancelOrder.cs - holds all events on the order tracking form.

namespace TigerTakeOut
{
    public partial class CancelOrder : Form
    {
        // Fields //
        private bool orderCancelled;

        // Constructor //
        public CancelOrder()
        {
            InitializeComponent();
            orderCancelled = false;
        }

        // Methods //

        // Returns to parent form whether user cancelled order or not
        public bool IsOrderCancelled()
        {
            return orderCancelled;
        }

        // Events //
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            orderCancelled = true;
            this.Close();
        }
    }
}
