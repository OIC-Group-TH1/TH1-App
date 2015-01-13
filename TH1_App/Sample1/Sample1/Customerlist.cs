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
    public partial class Customerlist : Form
    {
        public int id;
        public string name;
        public string kana;
        public string sex;
        public string tel;
        public string post;
        public string address;
        public string note;

        public Customerlist()
        {
            InitializeComponent();
        }

        private void CustomerlistTop_button_Click(object sender, EventArgs e)
        {
            Top_page Top = new Top_page();
            Top.Visible = true;
            this.Close();
        }

        private void CustomerlistEntry_button_Click(object sender, EventArgs e)
        {
            Customerentry Centry = new Customerentry();
            Centry.Show();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //名前セルのデータ有無で判定
            if (dataGridView1.CurrentRow.Cells[1].Value != null)
            {
                //Reserver 　使用時のIDの保持
                Reserve_Class._Reserve_customer_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                //顧客情報を表示
                id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                name = (string)dataGridView1.CurrentRow.Cells[1].Value;
                kana = (string)dataGridView1.CurrentRow.Cells[2].Value;
                sex = (string)dataGridView1.CurrentRow.Cells[3].Value;
                tel = (string)dataGridView1.CurrentRow.Cells[4].Value;
                post = (string)dataGridView1.CurrentRow.Cells[5].Value;
                address = (string)dataGridView1.CurrentRow.Cells[6].Value;
                note = (string)dataGridView1.CurrentRow.Cells[7].Value;

                Customer Cust = new Customer(this);
                Cust.Show();
                this.Close();
            }
            //－－－－－elseの場合まだ未入力－－－－－
        }

        private void Customerlist_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'globalDBDataSet.TBL_CLIENT' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.tBL_CLIENTTableAdapter.Fill(this.globalDBDataSet.TBL_CLIENT);
           
            //セルを行として管理
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
        }

        private void CustomerlistBack_button_Click(object sender, EventArgs e)
        {
            //予約状況一覧を表示
            reservelist Rlist = new reservelist();
            Rlist.Show();
            this.Close();
        }

        private void CustomerlistSearch_button_Click(object sender, EventArgs e)
        {
            //検索ボタンの処理
            //検索ボタンの処理　とりあえず作った、条件式はまだ
            DBconnection DBC = new DBconnection();
            DBC.DB_connect();

            try
            {
                dataGridView1.Rows.Clear();
                //データベースファイルオープン
                SqlCommand command = new SqlCommand();

                ///////////////////////////////////////////////////////////条件式がまだ（山野）
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    command.CommandText = "SELECT CLIENT_CODE,CLIENT_NAME,CLIENT_KANA,CLIENT_SEX,CLIENT_TEL,CLIENT_POST,CLIENT_ADDRESS,CLIENT_NOTE FROM TBL_CLIENT";
                }
                else if (textBox1.Text != "" && textBox2.Text != "")
                {
                    command.CommandText = "SELECT CLIENT_CODE,CLIENT_NAME,CLIENT_KANA,CLIENT_SEX,CLIENT_TEL,CLIENT_POST,CLIENT_ADDRESS,CLIENT_NOTE FROM TBL_CLIENT WHERE CLIENT_NAME LIKE '%" + textBox1.Text + "%' AND CLIENT_TEL LIKE '%" + textBox2.Text + "%'";
                }
                else if (textBox1.Text != "")
                {
                    command.CommandText = "SELECT CLIENT_CODE,CLIENT_NAME,CLIENT_KANA,CLIENT_SEX,CLIENT_TEL,CLIENT_POST,CLIENT_ADDRESS,CLIENT_NOTE FROM TBL_CLIENT WHERE CLIENT_NAME LIKE '%" + textBox1.Text + "%'";
                }
                else if (textBox2.Text != "")
                {
                    command.CommandText = "SELECT CLIENT_CODE,CLIENT_NAME,CLIENT_KANA,CLIENT_SEX,CLIENT_TEL,CLIENT_POST,CLIENT_ADDRESS,CLIENT_NOTE FROM TBL_CLIENT WHERE CLIENT_TEL LIKE '%" + textBox2.Text + "%'";
                }
                command.Connection = DBC.Get_scn();
                SqlDataReader reader = command.ExecuteReader();

                for (int i = 0; reader.Read(); i++)
                {
                    dataGridView1.Rows.Add();
                    for (int x = 0; x < 8; x++)
                    {
                        dataGridView1.Rows[i].Cells[x].Value = reader.GetSqlValue(x).ToString();
                    }
                }
                DBC.DB_DisConnect();
            }

            catch (Exception ex)
            {
                //データベースファイルクローズ
                MessageBox.Show(ex.Message);
                DBC.DB_DisConnect();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
