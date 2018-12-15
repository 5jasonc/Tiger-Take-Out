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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        private void passlabel_Click(object sender, EventArgs e)
        {
            int passwordlength = this.passText.TextLength;
            int usernamelength = this.userText.TextLength;

            if (passwordlength > 0 && usernamelength > 0)
            {
                //Selection selection = new Selection();
                //selection.ShowDialog();

                this.Hide();
            }
        }
       
    }
}
