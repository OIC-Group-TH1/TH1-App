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
            IO_Class.IO_RCODE = int.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            IOcheck IOche = new IOcheck();
            IOche.Show();
            this.Close();
        }

        private void IOchecklist_Load(object sender, EventArgs e)
        {
            //セルを行として管理
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

            DateTime dNow = System.DateTime.Today;
            IO_Class.IO_DATE = dNow.ToShortDateString();
            DBconnection DBC = new DBconnection();
            DBC.DB_connect();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT RO.ROOM_CODE,RO.ROOM_NAME,RO.ROOM_CIGARETTE,CL.CLIENT_NAME,CL.CLIENT_KANA,CL.CLIENT_TEL,RE.RESERVATION_NUM,RE.RESERVATION_CODE,CL.CLIENT_CODE,RE.[CHECK] FROM TBL_ROOM RO,TBL_RESERVATION RE,TBL_CLIENT CL WHERE RE.ROOM_CODE = RO.ROOM_CODE and RE.CLIENT_CODE = CL.CLIENT_CODE and RESERVATION_DATE =" + "'" + IO_Class.IO_DATE + "'";

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

            for (int dRow = 0; dRow < dataGridView1.Rows.Count-1; dRow++)
            {
                //チェックイン列がtrueならば会計列を使用不可に
                if (dataGridView1.Rows[dRow].Cells[9].Value.ToString() == "true")
                {
                    dataGridView1.Rows[dRow].Cells[10].ReadOnly = false;
                }
                else
                {
                    dataGridView1.Rows[dRow].Cells[10].ReadOnly = true;
                }
            }
        }

        private void IOchecklistAccounts_button_Click(object sender, EventArgs e)
        {
            int cnt = dataGridView1.Rows.Count;
            int m = 0, n = 0;

            //このループで値の入っているデータだけカウントする
            for (int i = 0; i < cnt - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[10].Value != null)
                {
                    m++;
                }
            }

            //配列の範囲は上でカウントされた分だけ
            int[] IO_Rcode = new int[m];

            //IO_Rcodeに可変で値を入れるループ
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
