﻿using System;
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
            this.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //名前セルのデータ有無で判定
            if (dataGridView1.CurrentRow.Cells[1].Value != null)
            {
                //顧客情報を表示
                Customer Cust = new Customer();
                Cust.Show();
                this.Close();
            }
        }

        private void Customerlist_Load(object sender, EventArgs e)
        {
            //セルを行として管理
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
        }

        private void CustomerlistBack_button_Click(object sender, EventArgs e)
        {
            //予約状況一覧を表示
            reservelist Rlist = new reservelist();
            Rlist.Show();
            this.Close();
        }
    }
}
