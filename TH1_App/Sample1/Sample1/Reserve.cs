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
    public partial class Reserve : Form
    {
        public Reserve()
        {
            InitializeComponent();
        }

        private void ReserveOk_button_Click(object sender, EventArgs e)
        {
            Top_page Top = new Top_page();
            Top.Visible = true;
            this.Close();
        }

        private void ReserveNo_button_Click(object sender, EventArgs e)
        {
            //顧客一覧を表示
            Customerlist Clist = new Customerlist();
            Clist.Show();
            this.Close();
        }
    }
}