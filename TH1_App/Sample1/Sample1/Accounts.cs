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
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void AcountsTop_button_Click(object sender, EventArgs e)
        {
            Top_page Top = new Top_page();
            Top.Show();
            this.Close();
        }

        private void AcountsBack_button_Click(object sender, EventArgs e)
        {
            IOcheck Back = new IOcheck();
            Back.Show();
            this.Close();
        }

        private void AcountsOk_button_Click(object sender, EventArgs e)
        {
            Accountscheck Acheck = new Accountscheck();
            Acheck.Show();
            this.Close();
        }
    }
}
