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
    public partial class IOchecklist : Form
    {

        //public string IO_r_code;
        //public string IO_r_no;
        //public string IO_c_name;
        //public string IO_c_tel;

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
            //IO_r_code = (string)dataGridView1.CurrentRow.Cells[8].Value;
            //IO_r_no = (string)dataGridView1.CurrentRow.Cells[0].Value;
            //IO_c_name = (string)dataGridView1.CurrentRow.Cells[3].Value;
            //IO_c_tel = (string)dataGridView1.CurrentRow.Cells[5].Value;

            
            IOcheck IOche = new IOcheck(this);
            IOche.Show();
            this.Close();
        }

        private void IOchecklist_Load(object sender, EventArgs e)
        {
            //セルを行として管理
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

            //サンプルデータ
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = 1234;
            }
        }

        private void IOchecklistCI_button_Click(object sender, EventArgs e)
        {
            //メッセージダイアログ(YES,NO)の表示
            DialogResult result = MessageBox.Show("チェックイン処理しますか？", "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                //デフォルトの選択ボタンは「いいえ」で設定
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                
                if (dataGridView1.CurrentRow.Cells[6].Value == null)
                {
                    //チェックボックスがチェックされる
                    dataGridView1.CurrentRow.Cells[6].Value = true;
                }
                else
                {
                    MessageBox.Show("既にチェックイン済みです", "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                
            }

            
        }

        private void IOchecklistCO_button_Click(object sender, EventArgs e)
        {
            //メッセージダイアログ(YES,NO)の表示
            DialogResult result = MessageBox.Show("チェックアウト処理しますか？", "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                //デフォルトの選択ボタンは「いいえ」で設定
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                if (dataGridView1.CurrentRow.Cells[7].Value == null)
                {
                    //チェックボックスがチェックされる
                    dataGridView1.CurrentRow.Cells[7].Value = true;
                }
                else
                {
                    MessageBox.Show("既にチェックイン済みです", "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }

        }




    }
}
