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
            Top_page Top = new Top_page();
            Top.Show();
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //クリックした日付を代入
            String Today = this.monthCalendar1.SelectionRange.Start.ToString();
            reservelist Rlist = new reservelist(Today);
            Rlist.Show();
            this.Visible = false;
        }
    }
}
