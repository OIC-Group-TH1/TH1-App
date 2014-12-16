using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample1
{
    //画面とロジックを分割するためのクラス
    class Logic
    {
        //sample add
        public static int add(int x, int y)
        {
            //呼び出し側使用例：
            //Logic.add(10, 20);
            return x + y;
        }
    }

    //接続用クラス
    class DBconnection
    {
        //データベース接続変数　ＳＣＮ
        System.Data.SqlClient.SqlConnection scn
               = new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\b3316\Documents\globalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        
        //接続用
        public void DB_connect()
        {
            try
            {
                scn.Open();
            }
            catch (Exception ex)
            {
                
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

            }
        }
    }

}
