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
            //カレンダーへ戻る
            Calendar Back = new Calendar();
            Back.Visible = true;
            this.Close();
        }

        private void reservelist_Load(object sender, EventArgs e)
        {
            //セルを行として管理
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
        }

        private void ReservelistTop_button_Click(object sender, EventArgs e)
        {
            //トップページへ戻る
            Top_page Top = new Top_page();
            Top.Show();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //宿泊者セルのデータがある場合
            if (dataGridView1.CurrentRow.Cells[3].Value == null)
            {
                //顧客一覧を表示
                Customerlist Clist = new Customerlist();
                Clist.Show();
                this.Close();
            }
            //宿泊者セルのデータがない場合
           else if (dataGridView1.CurrentRow.Cells[3].Value != null)
           {
               //予約情報を表示
               Reservecheck Rcheck = new Reservecheck();
               Rcheck.Show();
               this.Close();
           }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
