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
    public partial class Reservecheck : Form
    {
        reservelist reservelist_main;

        public Reservecheck(reservelist form)
        {
            InitializeComponent();
            reservelist_main = form;
        }

        private void Reservecheck_Load(object sender, EventArgs e)
        {
                 ////SQL SERVERを開いてるときにコメントアウト
                 ////データベースからの取得
                 //   System.Data.SqlClient.SqlConnection scn
                 //   = new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\b3316\Documents\globalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                
                 //   try
                 //   {
                 //       //データベースファイルオープン
                 //       scn.Open();
                 //       SqlCommand client_command = new SqlCommand();
                 //       SqlCommand reservation_command = new SqlCommand();
                 //       SqlCommand room_command = new SqlCommand();

                 //       //SQL文の入力
                 //       client_command.CommandText = "SELECT * FROM TBL_CLIENT WHERE CLIENT_NAME = @c_name AND CLIENT_TEL = @c_tel";
                 //       reservation_command.CommandText = "SELECT * FROM TBL_RESERVATION WHERE RESERVATION_CODE = @r_code";
                 //       room_command.CommandText = "SELECT * FROM TBL_ROOM WHERE ROOM_CODE = @r_no";
                        
                 //       // SQLを実行
                 //       SqlDataReader client_reader = client_command.ExecuteReader();
                 //       SqlDataReader reservation_reader = reservation_command.ExecuteReader();
                 //       SqlDataReader room_reader = reservation_command.ExecuteReader();
                 //       while (client_reader.Read() & reservation_reader.Read() & room_reader.Read())
                 //           {
                 //               Reservecheck_Date.Text = (string)reservation_reader.GetValue(1);
                 //               Reservecheck_No.Text = (string)room_reader.GetValue(0);
                 //               Reservecheck_Type.Text = (string)room_reader.GetValue(1);
                 //               Reservecheck_Smoke.Text = (string)room_reader.GetValue(3);
                 //               Reservecheck_Number.Text = (string)reservation_reader.GetValue(3);
                 //               Reservecheck_Value.Text = (string)room_reader.GetValue(2);

                 //               Reservecheck_Name.Text = (string)client_reader.GetValue(1);
                 //               Reservecheck_Kana.Text = (string)client_reader.GetValue(2);
                 //               Reservecheck_Sex.Text = (string)client_reader.GetValue(3);
                 //               Reservecheck_Tel.Text = (string)client_reader.GetValue(4);
                 //               Reservecheck_Post.Text = (string)client_reader.GetValue(5);
                 //               Reservecheck_Address.Text = (string)client_reader.GetValue(6);
                 //               Reservecheck_Note.Text = (string)client_reader.GetValue(7);

                 //               scn.Close();
                 //           }

                 //   }
                 //       //できなかったらクローズしてエラー
                 //   catch (Exception ex)
                 //   {
                 //       //データベースファイルクローズ
                 //       scn.Close();
                 //       MessageBox.Show(ex.Message, "エラー");
                 //   }
                
        }

        private void CustomerentryKana_label2_Click(object sender, EventArgs e)
        {

        }

        private void ReservecheckBack_button_Click(object sender, EventArgs e)
        {
            Calendar Cal = new Calendar();
            Cal.Show();
            this.Close();
        }

        private void ReservecheckTop_button_Click(object sender, EventArgs e)
        {
            Top_page Top = new Top_page();
            Top.Show();
            this.Close();
        }

        private void ReservecheckCchange_button_Click(object sender, EventArgs e)
        {
            Customerlist Custlist = new Customerlist();
            Custlist.Show();
            this.Close();
            
        }

        private void ReservecheckDelete_button_Click(object sender, EventArgs e)
        {
            //メッセージダイアログ(YES,NO)の表示
            DialogResult result = MessageBox.Show("削除してもよろしいですか？", "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                //デフォルトの選択ボタンは「いいえ」で設定
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                //「はい」が選択された時の処理を書
                System.Data.SqlClient.SqlConnection scn
                   = new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\b3316\Documents\globalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                try
                {
                    //データベースファイルオープン
                    scn.Open();
                   SqlCommand scm = new SqlCommand
                        ("DELETE FROM RESERVATION_TABLE WHERE RESERVATION_CODE = ");

                    scm.ExecuteNonQuery();
                    scn.Close();
                }

                catch (Exception ex)
                {
                    //データベースファイルクローズ
                    scn.Close();
                    MessageBox.Show(ex.Message, "エラー");
                }

                Top_page Top = new Top_page();
                Top.Show();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                //「いいえ」が選択された時の処理を書
                //Reservecheck Resback = new Reservecheck();
                //Resback.Show();
                //this.Close();
            }
        }

        private void ReservecheckRchange_button_Click(object sender, EventArgs e)
        {
            Calendar Cal = new Calendar();
            Cal.Show();
            this.Close();
        }

        
    }
}
