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
    public partial class Stafflist : Form
    {
        public Stafflist()
        {
            InitializeComponent();
        }

        private void StafflistTop_button_Click(object sender, EventArgs e)
        {
            Top_page Top = new Top_page();
            Top.Visible = true;
            this.Close();
        }

        private void StafflistEntry_button_Click(object sender, EventArgs e)
        {
            Staffentry Sentry = new Staffentry();
            Sentry.Show();
            this.Close();
        }

        private void StafflistDelete_button_Click(object sender, EventArgs e)
        {
            //メッセージダイアログ(YES,NO)の表示
            DialogResult result = MessageBox.Show("削除してもよろしいですか？", "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                //デフォルトの選択ボタンは「いいえ」で設定
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                //「はい」が選択された時の処理を書く
            }
            else if (result == DialogResult.No)
            {
                //「いいえ」が選択された時の処理を書く
            }
        }

        private void Stafflist_Load(object sender, EventArgs e)
        {
            //セルを行として管理
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            // DataGridViewの行追加
            dataGridView1.Rows.Add();//一回書く事で項目が一行ずつ増える
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "S0001";
            dataGridView1.Rows[0].Cells[1].Value = "藤田知樹";
            dataGridView1.Rows[0].Cells[2].Value = "フジタトモキ";
            dataGridView1.Rows[0].Cells[3].Value = "男";
            dataGridView1.Rows[0].Cells[4].Value = "24";
            dataGridView1.Rows[0].Cells[5].Value = "Y01";
            dataGridView1.Rows[0].Cells[6].Value = "0611112222";
            dataGridView1.Rows[0].Cells[7].Value = "tomokilove@hotmail.com";
            dataGridView1.Rows[0].Cells[8].Value = "20140401";
            dataGridView1.Rows[0].Cells[9].Value = "山口県";


            dataGridView1.Rows[1].Cells[0].Value = "S0002";
            dataGridView1.Rows[1].Cells[1].Value = "古川康";
            dataGridView1.Rows[1].Cells[2].Value = "フルカワヤスシ";
            dataGridView1.Rows[1].Cells[3].Value = "男";
            dataGridView1.Rows[1].Cells[4].Value = "24";
            dataGridView1.Rows[1].Cells[5].Value = "Y02";
            dataGridView1.Rows[1].Cells[6].Value = "0611134222";
            dataGridView1.Rows[1].Cells[7].Value = "furukawalove@hotmail.com";
            dataGridView1.Rows[1].Cells[8].Value = "20130401";
            dataGridView1.Rows[1].Cells[9].Value = "奈良県";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //宿泊者セルのデータがある場合
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                //DataGridViewの各セルのデータを取得
                
                Staff.CODE = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Staff.NAME = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Staff.KANA = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Staff.SEX = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Staff.AGE = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Staff.POSITION = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Staff.TEL = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Staff.MAIL = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                Staff.DAY = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                Staff.ADDRESS = dataGridView1.CurrentRow.Cells[9].Value.ToString();



                //社員変更画面を表示
                //String StaffInform = this.dataGridView1.
                Staffchange Schange = new Staffchange(this);
                Schange.Show();
                this.Close();
            }
        }


    }
}
