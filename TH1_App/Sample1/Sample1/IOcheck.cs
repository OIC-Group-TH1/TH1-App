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

        private void IOcheckCI_button_Click(object sender, EventArgs e)
        {
            Accounts CI = new Accounts();
            CI.Show();
            this.Close();
        }

        private void IOcheck_Load(object sender, EventArgs e)
        {
            //SQL SERVERを開いてるときにコメントアウト
            //データベースからの取得
            
            DBconnection DBC = new DBconnection();
            DBC.DB_connect();

            try
            {
                //データベースファイルオープン
                
                SqlCommand client_command = new SqlCommand();
                SqlCommand reservation_command = new SqlCommand();
                SqlCommand room_command = new SqlCommand();

                //SQL文の入力
                client_command.CommandText = "SELECT * FROM TBL_CLIENT WHERE CLIENT_CODE = IO_Class.IO_CCODE";
                reservation_command.CommandText = "SELECT * FROM TBL_RESERVATION WHERE RESERVATION_CODE = @IO_Class.IO_RCODE";
                room_command.CommandText = "SELECT * FROM TBL_ROOM WHERE ROOM_CODE = @IO_Class.IO_NO";

                // SQLを実行
                SqlDataReader client_reader = client_command.ExecuteReader();
                SqlDataReader reservation_reader = reservation_command.ExecuteReader();
                SqlDataReader room_reader = reservation_command.ExecuteReader();
                while (client_reader.Read() & reservation_reader.Read() & room_reader.Read())
                {
                    
                    IOcheck_No.Text = room_reader.GetValue(0).ToString();
                    IOcheck_Type.Text = room_reader.GetValue(1).ToString();
                    IOcheck_Smoke.Text = room_reader.GetValue(3).ToString();
                    IOcheck_Number.Text = reservation_reader.GetValue(3).ToString();
                    IOcheck_Rate.Text = room_reader.GetValue(2).ToString();

                    IOcheck_Name.Text = client_reader.GetValue(1).ToString();
                    IOcheck_Kana.Text = client_reader.GetValue(2).ToString();
                    IOcheck_Sex.Text = client_reader.GetValue(3).ToString();
                    IOcheck_Tel.Text = client_reader.GetValue(4).ToString();
                    IOcheck_Post.Text = client_reader.GetValue(5).ToString();
                    IOcheck_Address.Text = client_reader.GetValue(6).ToString();
                    IOcheck_Note.Text = client_reader.GetValue(7).ToString();

                    DBC.DB_DisConnect();
                }

            }
            //できなかったらクローズしてエラー
            catch (Exception ex)
            {
                //データベースファイルクローズ
                DBC.DB_DisConnect();
                MessageBox.Show(ex.Message, "エラー");
            }
                
        }


        
    }
}
