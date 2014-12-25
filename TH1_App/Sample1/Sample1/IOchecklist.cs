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
            IO_Class.IO_RCODE = int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            IO_Class.IO_CCODE = int.Parse(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            IO_Class.IO_TYPE = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            IO_Class.IO_SMOKE = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            IO_Class.IO_NAME = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            IO_Class.IO_NUMBER = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            IO_Class.IO_DATE = DateTime.Today;


            
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
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i;
                dataGridView1.Rows[i].Cells[9].Value = i;
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
                
                if (dataGridView1.CurrentRow.Cells[7].Value == null)
                {
                    //チェックボックスがチェックされる
                    dataGridView1.CurrentRow.Cells[7].Value = true;

                    int R_code = int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());

                    DBconnection DBC = new DBconnection();
                    DBC.DB_connect();
          
                    try
                    {
                        SqlCommand scm = new SqlCommand
                        ("update TBL_RESERVATION set CHECK = TRUE where RESERVATION_CODE = " + R_code +")",DBC.Get_scn());

                        scm.ExecuteNonQuery();

                        DBC.DB_DisConnect();
                    
                
                    }
                    catch (Exception ex)
                    {
                        //データベースファイルクローズ
                        DBC.DB_DisConnect();
                    
                        MessageBox.Show(ex.Message, "エラー");
                    }
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
                if (dataGridView1.CurrentRow.Cells[8].Value == null)
                {
                    //チェックボックスがチェックされる
                    dataGridView1.CurrentRow.Cells[8].Value = true;
                }
                else
                {
                    MessageBox.Show("既にチェックイン済みです", "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }

        }

        private void IOchecklistAccounts_button_Click(object sender, EventArgs e)
        {
            int cnt = dataGridView1.Rows.Count;
            int n = 0;
            int[] IO_Rcode = new int[cnt];
            for (int i = 0; i < cnt - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[6].Value != null)
                {
                    IO_Rcode[n] = int.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
                    n++;
                }

            }
            Accounts IOaccounts = new Accounts(IO_Rcode);
            IOaccounts.Show();
            this.Close();
        }




    }
}
