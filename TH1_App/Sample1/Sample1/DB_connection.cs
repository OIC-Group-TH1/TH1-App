using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sample1
{
    //接続用クラス
    class DBconnection
    {
        //データベース接続変数　SCN
        System.Data.SqlClient.SqlConnection scn
               = new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Yasushi Furukawa\デスクトップ\globalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        //接続用
        public void DB_connect()
        {
            try
            {
                scn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //切断用
        public void DB_DisConnect()
        {
            try
            {
                scn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public SqlConnection Get_scn()
        {
            return scn;
        }
    }
}
