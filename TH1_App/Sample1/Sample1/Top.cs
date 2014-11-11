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
    public partial class Top_page : Form
    {
        public Top_page()
        {
            InitializeComponent();
        }

        private void Yoyaku_button_Click(object sender, EventArgs e)
        {
            Calendar Cal = new Calendar();
            Cal.Show();
            this.Visible = false;           

        }

        private void Kokyaku_button_Click(object sender, EventArgs e)
        {
            Customerlist Cust = new Customerlist();
            Cust.Show();
            this.Visible = false;
        }

        private void Room_button_Click(object sender, EventArgs e)
        {
            IOchecklist IO = new IOchecklist();
            IO.Show();
            this.Visible = false;
        }

        private void Syain_button_Click(object sender, EventArgs e)
        {
            Stafflist Staff = new Stafflist();
            Staff.Show();
            this.Visible = false;
        }
    }
}
