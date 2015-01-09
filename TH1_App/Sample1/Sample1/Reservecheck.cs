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
                
                command.CommandText =
                  "SELECT RE.RESERVATION_DATE,RO.ROOM_CODE,RO.ROOM_NAME,RO.ROOM_CIGARETTE,RE.RESERVATION_NUM,RO.ROOM_VALUE,CL.CLIENT_NAME,CL.CLIENT_KANA,CL.CLIENT_SEX,CL.CLIENT_TEL,CL.CLIENT_POST,CL.CLIENT_ADDRESS,CL.CLIENT_NOTE FROM TBL_CLIENT CL JOIN TBL_RESERVATION RE ON (RE.CLIENT_CODE = CL.CLIENT_CODE) JOIN TBL_ROOM RO ON (RE.ROOM_CODE = RO.ROOM_CODE) WHERE RE.RESERVATION_CODE =" + "'" + reservelist_main.r_code.ToString() + "'";
                command.Connection = DBC.Get_scn();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Reservecheck_Date.Text = reader.GetValue(0).ToString();
                    Reservecheck_No.Text = reader.GetValue(1).ToString();
                    Reservecheck_Type.Text = reader.GetValue(2).ToString();
                    Reservecheck_Smoke.Text = reader.GetValue(3).ToString();
                    Reservecheck_Number.Text = reader.GetValue(4).ToString();
                    Reservecheck_Value.Text = reader.GetValue(5).ToString();

                    Reservecheck_Name.Text = reader.GetValue(6).ToString();
                    Reservecheck_Kana.Text = reader.GetValue(7).ToString();
                    Reservecheck_Sex.Text = reader.GetValue(8).ToString();
                    Reservecheck_Tel.Text = reader.GetValue(9).ToString();
                    Reservecheck_Post.Text = reader.GetValue(10).ToString();
                    Reservecheck_Address.Text = reader.GetValue(11).ToString();
                    Reservecheck_Note.Text = reader.GetValue(12).ToString();
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
                //「はい」が選択された時の処理を書く
                DBconnection DBC = new DBconnection();
                try
                {
                    //データベースファイルオープン
                    DBC.DB_connect();
                    SqlCommand command = new SqlCommand();

                    command.CommandText =
                      "DELETE FROM TBL_RESERVATION WHERE RESERVATION_CODE =" + "'" + reservelist_main.r_code.ToString() + "'";
                    command.Connection = DBC.Get_scn();
                    SqlDataReader reader = command.ExecuteReader();
                    //TOP画面へ
                    Top_page Top = new Top_page();
                    Top.Visible = true;
                    this.Close();
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //データベースファイルクローズ
                    DBC.DB_DisConnect();
                }
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
