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

           
           
                //予約確定メッセージ
                MessageBox.Show("予約が登録されました","予約確定",
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
          /*
            //ラジオボタンによる禁煙、喫煙の判定
            if (radioButton1.Checked)　//禁煙
            {
               
            }
            else　//喫煙
            {
               
            }
          */
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
                
                
                //作成途中
                command.CommandText = "SELECT  RE.RESERVATION_DATE,RO.ROOM_CODE,RO.ROOM_NAME,RO.ROOM_CIGARETTE,RE.RESERVATION_NUM,RO.ROOM_VALUE,CL.CLIENT_NAME,CL.CLIENT_KANA,CL.CLIENT_SEX,CL.CLIENT_TEL,CL.CLIENT_POST,CL.CLIENT_ADDRESS,CL.CLIENT_NOTE"
                                     +"";
                command.Connection = DBC.Get_scn();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DBC.DB_DisConnect();
            }
        }
       }

    
   
}