using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Sample1
{

    public class DBconnection
    {
         System.Data.SqlClient.SqlConnection scn
                = new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\b3316\Documents\globalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        // SQLServer


        public void DB_Open()
        {
            try
            {
                scn.Open();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Connect Error", ex);
            }
        }

        public void DB_Close()
        {
            try
            {
                scn.Open();

            }
            catch (Exception ex)
            {
                throw new Exception("Disconnect Error", ex);
            }
        }
    }
}