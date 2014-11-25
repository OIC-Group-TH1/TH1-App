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
    public partial class Staffentry : Form
    {
        public Staffentry()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StaffentryBack_button_Click(object sender, EventArgs e)
        {
            Stafflist Back = new Stafflist();
            Back.Visible = true;
            this.Close();


        }

        private void StaffentryEntry_button_Click(object sender, EventArgs e)
        {
            Staffcheck Scheck = new Staffcheck();
            Scheck.Show();
            this.Close();
        }
    }
}
