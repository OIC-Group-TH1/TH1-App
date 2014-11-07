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
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void CalendarTop_button_Click(object sender, EventArgs e)
        {
            Top_page TP = new Top_page();
            TP.Visible = true;
            this.Close();
        }
    }
}
