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
    public partial class Customerlist : Form
    {
        public Customerlist()
        {
            InitializeComponent();
        }


        private void CustomerlistTop_button_Click(object sender, EventArgs e)
        {
            Top_page Top = new Top_page();
            Top.Visible = true;
            this.Close();
        }

        private void CustomerlistEntry_button_Click(object sender, EventArgs e)
        {
            Customerentry Centry = new Customerentry();
            Centry.Show();
            this.Visible = false;

        }
    }
}
