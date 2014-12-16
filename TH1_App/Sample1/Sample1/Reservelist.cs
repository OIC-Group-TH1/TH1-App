using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sample1
{
    public partial class reservelist : Form
    {
        public string r_code;
        public string c_name;
        public string c_tel;


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

        public void reservelist_Load(object sender, EventArgs e)
        {
            //セルを行として管理
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

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
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                //仮で色を指定
                if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "可")

                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                else if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "不可" && dataGridView1.Rows[i].Cells[3].Value == null)
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.YellowGreen;
                else if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "不可")
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
            }
        }

        private void ReservelistTop_button_Click(object sender, EventArgs e)
        {
            //トップページへ戻る
            Top_page Top = new Top_page();
            Top.Show();
            this.Close();
        }

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //宿泊者セルのデータがない場合
            if (dataGridView1.CurrentRow.Cells[3].Value == null)
            {
                //顧客一覧を表示
                Customerlist Clist = new Customerlist();
                Clist.Show();
                this.Close();
            }
            //宿泊者セルのデータがある場合
            else if (dataGridView1.CurrentRow.Cells[3].Value != null)
            {

                //値の取得(これをselect文で検索し、情報をReservecheckで)
                r_code = (string)dataGridView1.CurrentRow.Cells[0].Value;
                c_name = (string)dataGridView1.CurrentRow.Cells[3].Value;
                c_tel = (string)dataGridView1.CurrentRow.Cells[5].Value;
                
                 // //データベースからの取得
                 // System.Data.SqlClient.SqlConnection scn
                 //   = new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\b3316\Documents\globalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                
                 // try
                 //{
                 //    //データベースファイルオープン
                 //    scn.Open();
                 //    SqlCommand command = new SqlCommand();
                 //    command.CommandText = "SELECT * FROM TBL_CLIENT WHERE ";
                 //    // SQLを実行
                 //    SqlDataReader reader = command.ExecuteReader();
                 //    while (reader.Read())
                 //        {
                 //            string id = (string)reader.GetValue(0);
                 //            string name = (string)reader.GetValue(1);
                 //            scn.Close();
                 //        }

                 //}

                 //catch (Exception ex)
                 //{
                 //    //データベースファイルクローズ
                 //    scn.Close();
                 //    MessageBox.Show(ex.Message, "エラー");
                 //}
                 



                //情報を持って予約情報を表示
                Reservecheck Rcheck = new Reservecheck(this);
                Rcheck.Show();
                this.Close();


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
