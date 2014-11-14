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

        private void reservelist_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
        }

        private void ReservelistTop_button_Click(object sender, EventArgs e)
        {
            Top_page Top = new Top_page();
            Top.Show();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[3].Value == null)
            {
                Customerlist Clist = new Customerlist();
                Clist.Show();
                this.Visible = false;
            }
           else if (dataGridView1.CurrentRow.Cells[3].Value != null)
           {
               Reservecheck Rcheck = new Reservecheck();
               Rcheck.Show();
               this.Visible = false;
           }
        }
    }
}
