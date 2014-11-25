using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Sample1
{
    public class DBconnection
    {
        // SQLServer
        public void DB_Open()
        {
            SqlConnection scn = new SqlConnection();

            scn.ConnectionString = (@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\b3316\Documents\globalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            
            // 接続します。
            scn.Open();    
        }

        public void DB_Close()
        {
            SqlConnection scn = new SqlConnection();

            scn.ConnectionString = (@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\b3316\Documents\globalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

            //切断します。
            scn.Close();
        }



    }
}

