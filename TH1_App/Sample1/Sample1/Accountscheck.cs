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
    public partial class Accountscheck : Form
    {
        public Accountscheck()
        {
            InitializeComponent();
        }


        private void AcountscheckOk_button_Click(object sender, EventArgs e)
        {
            IOchecklist Checkin = new IOchecklist();
            Checkin.Show();
            this.Close();
        }

        private void AcountscheckBack_button_Click(object sender, EventArgs e)
        {
            Accounts Back = new Accounts();
            Back.Show();
            this.Close();
        }
    }
}
