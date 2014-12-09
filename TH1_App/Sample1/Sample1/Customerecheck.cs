using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sample1
{
    public partial class Customerecheck : Form
    {
        public Customerecheck()
        {
            InitializeComponent();
        }

        private void CustomercheckNo_button_Click(object sender, EventArgs e)
        {
            Customerlist Custlist = new Customerlist();
            Custlist.Show();
            this.Close();
        }

        private void CustomercheckYes_button_Click(object sender, EventArgs e)
        {
            Customer Cust = new Customer();
            Cust.Show();
            this.Close();
        }

    }
}
