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
    public partial class Staffcheck : Form
    {
        public Staffcheck()
        {
            InitializeComponent();
        }

        private void StaffcheckYes_button_Click(object sender, EventArgs e)
        {
            Stafflist Scheckok = new Stafflist();
            Scheckok.Show();
            this.Close();
        }

        private void StaffcheckNo_button_Click(object sender, EventArgs e)
        {
            Staffentry Scheckno = new Staffentry();
            Scheckno.Show();
            this.Close();
        }
    }
}
