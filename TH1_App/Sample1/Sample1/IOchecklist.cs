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
    public partial class IOchecklist : Form
    {

        public IOchecklist()
        {
            InitializeComponent();
 
        }

        private void IOchecklistTop_button_Click(object sender, EventArgs e)
        {
            Top_page Top = new Top_page();
            Top.Visible = true;
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //情報の取得(これをselect文で検索し、IOcheck情報をで)
            IO_Class.IO_NO = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            IO_Class.IO_RCODE = int.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            IO_Class.IO_CCODE = int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            //IO_Class.IO_TYPE = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //IO_Class.IO_SMOKE = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //IO_Class.IO_NAME = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //IO_Class.IO_NUMBER = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //IO_Class.IO_KANA = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            

            
            IOcheck IOche = new IOcheck();
            IOche.Show();
            this.Close();
        }

        private void IOchecklist_Load(object sender, EventArgs e)
        {
            //セルを行として管理
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

            //サンプルデータ

            //dataGridView1.Rows.Add();
            //dataGridView1.Rows[0].Cells[0].Value = 1;
            //dataGridView1.Rows[0].Cells[9].Value = false;
            //dataGridView1.Rows[0].Cells[7].Value = 2;
            //dataGridView1.Rows[0].Cells[8].Value = 3;
            //dataGridView1.Rows.Add();
            //dataGridView1.Rows[1].Cells[0].Value = 2;
            //dataGridView1.Rows[1].Cells[9].Value = false;
            //dataGridView1.Rows.Add();
            //dataGridView1.Rows[2].Cells[0].Value = 3;
            //dataGridView1.Rows[2].Cells[9].Value = true;

            DateTime dNow = System.DateTime.Today;
            IO_Class.IO_DATE = dNow.ToShortDateString();
            DBconnection DBC = new DBconnection();
            DBC.DB_connect();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT RO.ROOM_CODE,RO.ROOM_NAME,RO.ROOM_CIGARETTE,CL.CLIENT_NAME,CL.CLIENT_KANA,CL.CLIENT_TEL,RE.RESERVATION_NUM,RE.RESERVATION_CODE,CL.CLIENT_CODE,RE.[CHECK]"
                                   + "FROM TBL_ROOM RO INNER JOIN TBL_RESERVATION RE ON RO.ROOM_CODE = RE.ROOM_CODE"
                                   + "INNER JOIN TBL_CLIENT CL ON RE.CLIENT_CODE = CL.CLIENT_CODE"
                                   + "WHERE RE.RESERVATION_DATE =" + "'" + IO_Class.IO_DATE + "'";
            //// SQLを実行
            command.Connection = DBC.Get_scn();
            SqlDataReader reader = command.ExecuteReader();
            int m, n;
            for (m = 0; reader.Read(); m++)
            {
                dataGridView1.Rows.Add();
                for (n = 0; n < 10; n++)
                {
                    reader.GetValue(n);
                    if (reader.GetValue(n) != DBNull.Value)
                    {

                        if (n == 0)
                        {
                            dataGridView1.Rows[m].Cells[n].Value = reader.GetValue(n).ToString();
                        }
                        else if (n == 7)
                        {
                            dataGridView1.Rows[m].Cells[n].Value = reader.GetValue(n).ToString();
                        }
                        else if (n == 8)
                        {
                            dataGridView1.Rows[m].Cells[n].Value = reader.GetValue(n).ToString();
                        }
                        else if (n == 9)
                        {
                            dataGridView1.Rows[m].Cells[n].Value = reader.GetValue(n).ToString();
                        }
                        else
                        {
                            dataGridView1.Rows[m].Cells[n].Value = (string)reader.GetValue(n);
                        }
                    }

                }
            }
            DBC.DB_DisConnect();


            //チェックボックスの判定がうまくいかない！！！！！！！！！！

            //for (int dRow = 0; dRow < dataGridView1.Rows.Count; dRow++)
            //{
            //    //チェックイン列がtrueならば会計列を使用不可に
            //    if ((bool)dataGridView1.Rows[dRow].Cells[9].Value == true)
            //    {
            //        dataGridView1.Rows[dRow].Cells[10].ReadOnly = true;
            //    }
            //    else
            //    {
            //        dataGridView1.Rows[dRow].Cells[10].ReadOnly = false;
            //    }
            //}
        }


        //チェックイン列は会計終了時に予約テーブルの[CHECK]をtrueにする
        //private void IOchecklistCI_button_Click(object sender, EventArgs e)
        //{
        //    //メッセージダイアログ(YES,NO)の表示
        //    DialogResult result = MessageBox.Show("チェックイン処理しますか？", "",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Exclamation,
        //        //デフォルトの選択ボタンは「いいえ」で設定
        //        MessageBoxDefaultButton.Button2);

        //    if (result == DialogResult.Yes)
        //    {
        //        //チェックイン列のチェックボックスの判定
        //        if (dataGridView1.CurrentRow.Cells[9].Value == null)
        //        {
        //            //予約コードの取得
        //            int R_code = int.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());

        //            DBconnection DBC = new DBconnection();
        //            DBC.DB_connect();
          
        //            try
        //            {
        //                //予約コードを用いて、入退室状況にtrueを入れる
        //                SqlCommand scm = new SqlCommand
        //                ("update TBL_RESERVATION set CHECK = 'True' where RESERVATION_CODE = " + R_code +")",DBC.Get_scn());

        //                scm.ExecuteNonQuery();

        //                DBC.DB_DisConnect();
                    
                
        //            }
        //            catch (Exception ex)
        //            {
        //                //データベースファイルクローズ
        //                DBC.DB_DisConnect();
                    
        //                MessageBox.Show(ex.Message, "エラー");
        //            }

        //            //フォームのリロード
        //            IOchecklist IO = new IOchecklist();
        //            IO.Show();
        //            this.Visible = false;
        //        }   
        //        else
        //        {
        //            MessageBox.Show("既にチェックイン済みです", "エラー",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //        }
                
        //    }

            
        //}

        //private void IOchecklistCO_button_Click(object sender, EventArgs e)
        //{
        //    //メッセージダイアログ(YES,NO)の表示
        //    DialogResult result = MessageBox.Show("チェックアウト処理しますか？", "",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Exclamation,
        //        //デフォルトの選択ボタンは「いいえ」で設定
        //        MessageBoxDefaultButton.Button2);

        //    if (result == DialogResult.Yes)
        //    {
        //        if (dataGridView1.CurrentRow.Cells[9].Value == null)
        //        {
        //            //チェックボックスがチェックされる
        //            dataGridView1.CurrentRow.Cells[9].Value = true;
        //        }
        //        else
        //        {
        //            MessageBox.Show("既にチェックイン済みです", "エラー",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //        }
        //    }

        //}

        private void IOchecklistAccounts_button_Click(object sender, EventArgs e)
        {
            int cnt = dataGridView1.Rows.Count;
            int m = 0,n = 0;

            for (int i = 0; i < cnt - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[10].Value != null)
                {
                    m++;
                }
            }

            int[] IO_Rcode = new int[m];
            for (int i = 0; i < cnt - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[10].Value != null)
                {
                    IO_Rcode[n] = int.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                    n++;
                }
            }
            Accounts IOaccounts = new Accounts(IO_Rcode);
            IOaccounts.Show();
            this.Close();
        }




    }
}
