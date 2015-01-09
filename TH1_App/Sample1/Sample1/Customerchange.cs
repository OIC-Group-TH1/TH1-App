using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sample1
{
    public partial class Customerchange : Form
    {
        public Customerchange()
        {
            InitializeComponent();
        }

        private void CustomerchangeBack_button_Click(object sender, EventArgs e)
        {
            Customer Back = new Customer();
            Back.Show();
            this.Close();
        }

        private void CustomerchangeChange_button_Click(object sender, EventArgs e)
        {
            Customerecheck Custcheck = new Customerecheck();
            Custcheck.Show();
            this.Close();
        }

        private void Customerchange_Load(object sender, EventArgs e)
        {

        }
    }
}
