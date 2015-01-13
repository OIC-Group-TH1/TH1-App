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
    public partial class IOcheck : Form
    {
        IOchecklist IOcheck_main;

        public IOcheck()
        {
            InitializeComponent();
        }
        public IOcheck(IOchecklist form)
        {
            InitializeComponent();
            IOcheck_main = form;
        }

        private void IOcheckBack_button_Click(object sender, EventArgs e)
        {
            IOchecklist Back = new IOchecklist();
            Back.Show();
            this.Close();
        }

        private void IOcheck_Load(object sender, EventArgs e)
        {
            //データベースからの取得
            DBconnection DBC = new DBconnection();
            DBC.DB_connect();

            try
            {
                //データベースファイルオープン
                SqlCommand client_command = new SqlCommand();
                //SQL文の入力
                client_command.CommandText = "select Ro.ROOM_CODE,Ro.ROOM_NAME,Ro.ROOM_CIGARETTE,Re.RESERVATION_NUM,Ro.ROOM_VALUE,Cl.CLIENT_NAME,Cl.CLIENT_KANA,Cl.CLIENT_SEX,Cl.CLIENT_TEL,Cl.CLIENT_POST,Cl.CLIENT_ADDRESS,Cl.CLIENT_NOTE from TBL_ROOM Ro inner join TBL_RESERVATION Re on Ro.ROOM_CODE = Re.ROOM_CODE inner join TBL_CLIENT Cl on Re.CLIENT_CODE = Cl.CLIENT_CODE where Re.RESERVATION_CODE =" + IO_Class.IO_RCODE;
                // SQLを実行
                client_command.Connection = DBC.Get_scn();
                SqlDataReader client_reader = client_command.ExecuteReader();
                while (client_reader.Read())
                {
                    IOcheck_No.Text = client_reader.GetValue(0).ToString();
                    IOcheck_Type.Text = client_reader.GetValue(1).ToString();
                    IOcheck_Smoke.Text = client_reader.GetValue(2).ToString();
                    IOcheck_Number.Text = client_reader.GetValue(3).ToString();
                    IOcheck_Rate.Text = client_reader.GetValue(4).ToString();
                    IOcheck_Name.Text = client_reader.GetValue(5).ToString();
                    IOcheck_Kana.Text = client_reader.GetValue(6).ToString();
                    IOcheck_Sex.Text = client_reader.GetValue(7).ToString();
                    IOcheck_Tel.Text = client_reader.GetValue(8).ToString();
                    IOcheck_Post.Text = client_reader.GetValue(9).ToString();
                    IOcheck_Address.Text = client_reader.GetValue(10).ToString();
                    IOcheck_Note.Text = client_reader.GetValue(11).ToString();
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
        }

        private void IOcheckOut_button_Click(object sender, EventArgs e)
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
                DBC.DB_connect();

                try
                {
                    //予約コードを用いて、入退室状況にtrueを入れる
                    SqlCommand scm = new SqlCommand
                    ("update TBL_RESERVATION set [CHECK2] = 'False' where RESERVATION_CODE = " + IO_Class.IO_RCODE, DBC.Get_scn());

                    scm.ExecuteNonQuery();
                    DBC.DB_DisConnect();
                }
                catch (Exception ex)
                {
                    //データベースファイルクローズ
                    DBC.DB_DisConnect();
                    MessageBox.Show(ex.Message, "エラー");
                }
            }
            else if (result == DialogResult.No)
            {
                //「いいえ」が選択された時の処理を書く
            }
        }
    }
}
