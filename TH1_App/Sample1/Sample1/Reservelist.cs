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

            Logic.add(10, 20);

            //行の追加（TEST用）↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓★後で消して！

            // DataGridViewの行追加
            dataGridView1.Rows.Add();//一回書く事で項目が一行ずつ増える
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[7].Value = "不可";
            dataGridView1.Rows[1].Cells[7].Value = "可";
            dataGridView1.Rows[2].Cells[7].Value = "不可";
            dataGridView1.Rows[2].Cells[3].Value = "namae";
            dataGridView1.Rows[3].Cells[7].Value = "不可";
            dataGridView1.Rows[4].Cells[7].Value = "可";
            //行の追加（TEST用）↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑★後で消して！



            //セルの数の分色を付ける
            for(int i = 0 ; i < dataGridView1.RowCount-1; i++)
            {
                //仮で色を指定
                if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "可")
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.YellowGreen;
                else if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "不可" && dataGridView1.Rows[i].Cells[3].Value == null)
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                else if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "不可")
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
            }
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
    }
}
