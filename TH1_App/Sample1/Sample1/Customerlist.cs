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
            // TODO: このコード行はデータを 'globalDBDataSet4.TBL_CLIENT' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.tBL_CLIENTTableAdapter.Fill(this.globalDBDataSet4.TBL_CLIENT);
            // TODO: このコード行はデータを 'globalDBDataSet3.TBL_CLIENT' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
           
            //セルを行として管理
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            //DB接続
            DBconnection dbcn = new DBconnection();
            dbcn.DB_connect();


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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
