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
            //       client_command.CommandText = "SELECT * FROM TBL_CLIENT WHERE CLIENT_NAME = @IO_c_name AND CLIENT_TEL = @IO_c_tel";
            //       reservation_command.CommandText = "SELECT * FROM TBL_RESERVATION WHERE RESERVATION_CODE = @IO_r_code";
            //       room_command.CommandText = "SELECT * FROM TBL_ROOM WHERE ROOM_CODE = @IO_r_no";

            //       // SQLを実行
            //       SqlDataReader client_reader = client_command.ExecuteReader();
            //       SqlDataReader reservation_reader = reservation_command.ExecuteReader();
            //       SqlDataReader room_reader = reservation_command.ExecuteReader();
            //       while (client_reader.Read() & reservation_reader.Read() & room_reader.Read())
            //           {
            //               Reservecheck_Date.Text = (string)reservation_reader.GetValue(1);
            //               IOcheck_No.Text = (string)room_reader.GetValue(0);
            //               IOcheck_Type.Text = (string)room_reader.GetValue(1);
            //               IOcheck_Smoke.Text = (string)room_reader.GetValue(3);
            //               IOcheck_Number.Text = (string)reservation_reader.GetValue(3);
            //               IOcheck_Rate.Text = (string)room_reader.GetValue(2);

            //               IOcheck_Name.Text = (string)client_reader.GetValue(1);
            //               IOcheck_Kana.Text = (string)client_reader.GetValue(2);
            //               IOcheck_Sex.Text = (string)client_reader.GetValue(3);
            //               IOcheck_Tel.Text = (string)client_reader.GetValue(4);
            //               IOcheck_Post.Text = (string)client_reader.GetValue(5);
            //               IOcheck_Address.Text = (string)client_reader.GetValue(6);
            //               IOcheck_Note.Text = (string)client_reader.GetValue(7);

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


        
    }
}
