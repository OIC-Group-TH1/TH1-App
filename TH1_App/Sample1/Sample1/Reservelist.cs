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
    public partial class reservelist : Form
    {
        public reservelist()
        {
            InitializeComponent();
        }
        public reservelist(string str)
        {
            InitializeComponent();
            dateTimePicker1.Text = str;
        }

        private void ReservelistBack_button_Click(object sender, EventArgs e)
        {
            Calendar Back = new Calendar();
            Back.Visible = true;
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void reservelist_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime();
        }

        private void ReservelistTop_button_Click(object sender, EventArgs e)
        {
            Top_page Top = new Top_page();
            Top.Show();
            this.Close();
        }
    }
}
