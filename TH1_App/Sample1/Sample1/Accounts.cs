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
    public partial class Accounts : Form
    {
        public int[] Array;
        public string A_Rcode = "";

        public Accounts()
        {
            InitializeComponent();
        }
        public Accounts(int[] Rcode)
        {
            Array = Rcode;
            InitializeComponent();
        }

        private void AcountsBack_button_Click(object sender, EventArgs e)
        {
            IOcheck Back = new IOcheck();
            Back.Show();
            this.Close();
        }

        private void AcountsOk_button_Click(object sender, EventArgs e)
        {
            DBconnection DBC = new DBconnection();
            DBC.DB_connect();

            try
            {
                //予約コードを用いて、入退室状況にtrueを入れる
                SqlCommand scm = new SqlCommand
                ("update TBL_RESERVATION set [CHECK] = 'True' where RESERVATION_CODE in(" + A_Rcode + ")", DBC.Get_scn());

                scm.ExecuteNonQuery();

                DBC.DB_DisConnect();


            }
            catch (Exception ex)
            {
                //データベースファイルクローズ
                DBC.DB_DisConnect();

                MessageBox.Show(ex.Message, "エラー");
            }
            
            Accountscheck Acheck = new Accountscheck();
            Acheck.Show();
            this.Close();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            
            ////サンプルデータ
            ////一回書く事で項目が一行ずつ増える
            //dataGridView1.Rows.Add();
            //dataGridView1.Rows[0].Cells[3].Value = 2000;
            //dataGridView1.Rows[0].Cells[5].Value = 2;
            //dataGridView1.Rows.Add();
            //dataGridView1.Rows[1].Cells[3].Value = 3000;
            //dataGridView1.Rows[1].Cells[5].Value = 1;
            //dataGridView1.Rows.Add();
            //dataGridView1.Rows[2].Cells[3].Value = 4000;
            //dataGridView1.Rows[2].Cells[5].Value = 3;

            //SQL SERVERを開いてるときにコメントアウト
            //データベースからの取得
            
            DBconnection DBC = new DBconnection();
            DBC.DB_connect();
            try
            {
            
            //予約コードの入った配列を変数strに","区切りで入れる
            
            

            for (int y = 0; y < Array.Length; y++)
            {
                if (y == Array.Length - 1)
                {
                    A_Rcode += Array[y].ToString();
                }
                else
                {
                    A_Rcode += Array[y].ToString() + ",";
                }
            }

            

                //データベースファイルオープン

                SqlCommand client_command = new SqlCommand();

                //SQL文の入力
                client_command.CommandText = "select Re.ROOM_CODE,Ro.ROOM_NAME,Cl.CLIENT_NAME,Ro.ROOM_VALUE,Re.RESERVATION_NUM,Re.RESERVATION_DAY"
                       + "from TBL_RESERVATION Re inner join TBL_ROOM Ro on Re.ROOM_CODE = Ro.ROOM_CODE"
                       + "inner join TBL_CLIENT Cl on Re.CLIENT_CODE = Cl.CLIENT_CODE"
                       + "where Re.RESERVATION_CODE in(" + A_Rcode + ")";
                // SQLを実行
                SqlDataReader client_reader = client_command.ExecuteReader();
                for(int x = 0; client_reader.Read(); x++)
                {
                    dataGridView1.Rows.Add();
                    for (int n = 0; n < 7; n++)
                    {
                        dataGridView1.Rows[x].Cells[n].Value = client_reader.GetValue(n);
                    }
                }
                    DBC.DB_DisConnect();
            }
            //できなかったらクローズしてエラー
            catch (Exception ex)
            {
                //データベースファイルクローズ
                DBC.DB_DisConnect();
                MessageBox.Show(ex.Message, "エラー");
            }




            int i;
            int total = 0;
            int value;
            int date;
            int cnt = dataGridView1.Rows.Count;//表の行数を取得

            for (i = 0; i < cnt - 1; i++)
            {
                value = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                date = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                dataGridView1.Rows[i].Cells[6].Value = date * value;
                total = total + int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }

            Accounts_Alltotal.Text = total.ToString();
            
        }

        private void Acounts_Recieve_TextChanged(object sender, EventArgs e)
        {
            //預り金に入力された金額
            int recieve = int.Parse(Accounts_Recieve.Text);
            //合計金額
            int total = int.Parse(Accounts_Alltotal.Text);
            //お釣りを表示
            Accounts_Change.Text = (recieve - total).ToString();
        }

        private void Accounts_Recieve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b') //数字とバックスペースのみ有効に
            {
                e.Handled = true;
            }
        }
    }
}
