using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Data.SqlClient;

namespace Sample1
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Top_page());

            //Db動作をする時は下をコメントアウト
            //Application.Run(new Staffentry());

            //SampleDBの確認のためフォームを呼び出す
            //Application.Run(new SampleDB());
        }
    }
}
