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
    public partial class Reserve : Form
    {


        public Reserve()
        {
            InitializeComponent();
        }

        private void ReserveOk_button_Click(object sender, EventArgs e)
        {
            //ここでinsertを発行し、TBL_RESERVATIONに登録
            DBconnection DBC = new DBconnection();
            DBC.DB_connect();
            try
            {
                //Datatime_Parce
                //Reserve_Class._Reserve_customer_id　カスタマーリスト選択時　IDの保持用変数
                //Reserve_Class._Reserve_room_code　　リザーブリスト選択時　　ROOMID保持用変数
                //Reserve_Class._Reserve_date 日付
                //日付取得
                DateTime DATE = DateTime.Parse(Reserve_Class._Reserve_date);
                //日数取得
                string NUMBER = ReserveNumber.SelectedItem.ToString();
                    //データベースファイルオープン
                SqlCommand scm = new SqlCommand
                    ("insert into TBL_RESERVATION (RESERVATION_DATE, RESERVATION_NUM, ROOM_CODE, CLIENT_CODE)values ("
                        + "'" + DATE + "',"
                        + "'" + NUMBER + "',"
                        + "'" + Reserve_Class._Reserve_room_code + "',"
                        + "'" + Reserve_Class._Reserve_customer_id + "'" + ")", DBC.Get_scn());

                scm.ExecuteNonQuery();
                DBC.DB_DisConnect();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //データベースファイルクローズ
                MessageBox.Show(ex.Message);
                DBC.DB_DisConnect();
            }

            //予約確定メッセージ
            MessageBox.Show("予約が登録されました", "予約確定",
            MessageBoxButtons.OK);

            //TOP画面へ
            Top_page Top = new Top_page();
            Top.Visible = true;
            this.Close();
        }

        private void ReserveNo_button_Click(object sender, EventArgs e)
        {
            //カレンダーを表示
            Calendar Cal = new Calendar();
            Cal.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void ReserveName_linkLabel_DoubleClick(object sender, EventArgs e)
        {
            //顧客一覧画面を表示
            Customerlist Clist = new Customerlist();
            Clist.Show();
            this.Close();

        }

        private void Reserve_Load(object sender, EventArgs e)
        {
            ReserveNumber.Items.Add("１人");
            ReserveNumber.Items.Add("２人");
            ReserveNumber.Items.Add("３人");
            ReserveNumber.Items.Add("４人");
            this.Controls.Add(ReserveNumber);
            ReserveNumber.SelectedIndex = 0;

            //SQL SERVERを開いてるときにコメントアウト
            DBconnection DBC = new DBconnection();
            try
            {
                //データベースファイルオープン
                DBC.DB_connect();
                SqlCommand command = new SqlCommand();

                //※SQL文発行時に使用するように！！
                //Reserve_Class._Reserve_date         選択日の日時            日付保持済み変数
                //Reserve_Class._Reserve_customer_id　カスタマーリスト選択時　IDの保持済み変数
                //Reserve_Class._Reserve_room_code　　リザーブリスト選択時　　ROOMID保持済み変数
                
                //日付
                Reserve_Date.Text = Reserve_Class._Reserve_date;
                //部屋NO、部屋の種類、タバコ、価格
                command.CommandText =
                       "SELECT RO.ROOM_CODE,RO.ROOM_NAME,RO.ROOM_CIGARETTE,RO.ROOM_VALUE FROM TBL_ROOM RO WHERE RO.ROOM_CODE =" + "'" + Reserve_Class._Reserve_room_code + "'";
                command.Connection = DBC.Get_scn();
                SqlDataReader reader1 = command.ExecuteReader();

                while (reader1.Read())
                {
                    Reserve_No.Text = reader1.GetValue(0).ToString();
                    ReserveType.Text = reader1.GetValue(1).ToString();
                    ReserveSmoke.Text = reader1.GetValue(2).ToString();
                    Reserve_Value.Text = reader1.GetValue(3).ToString();
                }
                DBC.DB_DisConnect();
                DBC.DB_connect();
                //名前、フリガナ、性別、電話番号、郵便番号、住所、備考
                command.CommandText =
                       "SELECT CL.CLIENT_NAME,CL.CLIENT_KANA,CL.CLIENT_SEX,CL.CLIENT_TEL,CL.CLIENT_POST,CL.CLIENT_ADDRESS,CL.CLIENT_NOTE FROM TBL_CLIENT CL WHERE CL.CLIENT_CODE =" + "'" + Reserve_Class._Reserve_customer_id + "'";
                SqlDataReader reader2 = command.ExecuteReader();
                while (reader2.Read())
                {
                    Reserve_Name.Text = reader2.GetValue(0).ToString();
                    Reserve_Kana.Text = reader2.GetValue(1).ToString();
                    Reserve_Sex.Text = reader2.GetValue(2).ToString();
                    Reserve_Tel.Text = reader2.GetValue(3).ToString();
                    Reserve_Post.Text = reader2.GetValue(4).ToString();
                    Reserve_Address.Text = reader2.GetValue(5).ToString();
                    Reserve_Note.Text = reader2.GetValue(6).ToString();
                }
                DBC.DB_DisConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DBC.DB_DisConnect();
            }

        }

        private void ReserveDate_label_Click(object sender, EventArgs e)
        {

        }
    }

}




