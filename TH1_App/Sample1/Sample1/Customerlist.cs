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
                Customer_Class._customer_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Customer_Class._customer_name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Customer_Class._customer_kana = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Customer_Class._customer_sex = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Customer_Class._customer_tel = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Customer_Class._customer_post = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Customer_Class._customer_address = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Customer_Class._customer_note = dataGridView1.CurrentRow.Cells[7].Value.ToString();


                Customer Cust = new Customer();
                Cust.Show();
                this.Close();
            }
            //－－－－－elseの場合まだ未入力－－－－－
        }

        private void Customerlist_Load(object sender, EventArgs e)
        {
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
            DBconnection DBC = new DBconnection();
            DBC.DB_connect();

            try
            {
                dataGridView1.Rows.Clear();
                //データベースファイルオープン
                SqlCommand command = new SqlCommand();

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
    }
}
