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
    public partial class Stafflist : Form
    {
        public Stafflist()
        {
            InitializeComponent();
        }

        private void StafflistTop_button_Click(object sender, EventArgs e)
        {
            Top_page Top = new Top_page();
            Top.Visible = true;
            this.Close();
        }

        private void StafflistEntry_button_Click(object sender, EventArgs e)
        {
            Staffentry Sentry = new Staffentry();
            Sentry.Show();
            this.Close();
        }
    }
}
