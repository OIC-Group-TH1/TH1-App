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
            //SQL SERVERを開いてるときにコメントアウト
            DBconnection DBC = new DBconnection();
            try
            {
                //データベースファイルオープン
                DBC.DB_connect();
                SqlCommand command = new SqlCommand();
                //SQL未完成！完成したらコメントを消して！
                command.CommandText =
                    "SELECT RE.RESERVATION_DATE,RO.ROOM_CODE,RO.ROOM_NAME,RO.ROOM_CIGARETTE,RE.RESERVATION_NUM,RO.ROOM_VALUE,CL.CLIENT_NAME,CL.CLIENT_KANA,CL.CLIENT_SEX,CL.CLIENT_TEL,CL.CLIENT_POST,CL.CLIENT_ADDRESS,CL.CLIENT_NOTE FROM TBL_CLIENT CL,TBL_RESERVATION RE,TBL_ROOM RO WHERE RE.ROOM_CODE = RO.ROOM_CODE and RE.CLIENT_CODE = CL.CLIENT_CODE and RESERVATION_CODE = " + "'" + reservelist_main.r_code.ToString() + "'";
                command.Connection = DBC.Get_scn();
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    Reservecheck_Date.Text = (string)reader.GetValue(0);
                    Reservecheck_No.Text = (string)reader.GetValue(1);
                    Reservecheck_Type.Text = (string)reader.GetValue(2);
                    Reservecheck_Smoke.Text = (string)reader.GetValue(3);
                    Reservecheck_Number.Text = (string)reader.GetValue(4);
                    Reservecheck_Value.Text = (string)reader.GetValue(5);

                    Reservecheck_Name.Text = (string)reader.GetValue(6);
                    Reservecheck_Kana.Text = (string)reader.GetValue(7);
                    Reservecheck_Sex.Text = (string)reader.GetValue(8);
                    Reservecheck_Tel.Text = (string)reader.GetValue(9);
                    Reservecheck_Post.Text = (string)reader.GetValue(10);
                    Reservecheck_Address.Text = (string)reader.GetValue(11);
                    Reservecheck_Note.Text = (string)reader.GetValue(12);
                }

            }
            //できなかったらクローズしてエラー
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //データベースファイルクローズ
                DBC.DB_DisConnect();              
            }
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
