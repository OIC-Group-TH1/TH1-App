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
    public partial class Staffchange : Form
    {

        Stafflist _Staffchange;
        public Staffchange()
        {
            InitializeComponent();
        }
        public Staffchange(Stafflist Sc_form)
        {
            InitializeComponent();
            _Staffchange = Sc_form;
        }

        private void StaffchangeDelete_button_Click(object sender, EventArgs e)
        {
            //メッセージダイアログ(YES,NO)の表示
            DialogResult result = MessageBox.Show("削除してもよろしいですか？", "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                //デフォルトの選択ボタンは「いいえ」で設定
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {

                DBconnection DBC = new DBconnection();
                DBC.DB_connect();

                try
                {
                    //データベースファイルオープン
                    
                    SqlCommand scm = new SqlCommand
                        ("delete from TBL_STAFF where STAFF_CODE =" + Staff_Class.STAFF_CODE, DBC.Get_scn());

                    scm.ExecuteNonQuery();
                    DBC.DB_DisConnect();
                }

                catch (Exception ex)
                {
                    //データベースファイルクローズ
                    DBC.DB_DisConnect();
                    MessageBox.Show(ex.Message, "エラー");
                }

                Stafflist Sdelete = new Stafflist();
                Sdelete.Show();
                this.Close();

            }
            else if (result == DialogResult.No)
            {
                //「いいえ」が選択された時の処理を書く
            }
            

        }

        private void StaffchangeOk_button_Click(object sender, EventArgs e)
        {
            //変更したデータを変数で保持
            Staff_Class.STAFF_NAME = Staffchange_Name.Text;
            Staff_Class.STAFF_KANA = Staffchange_Kana.Text;
            Staff_Class.STAFF_SEX = Staffchange_Sex.Text;
            Staff_Class.STAFF_AGE = Staffchange_Age.Text;
            Staff_Class.STAFF_POSITION = Staffchange_Position.Text;
            Staff_Class.STAFF_TEL = Staffchange_Tel.Text;
            Staff_Class.STAFF_MAIL = Staffchange_Mail.Text;
            Staff_Class.STAFF_ADDRESS = Staffchange_Address.Text; 

            Staffcheck Scheck = new Staffcheck(this,"Staffchange");
            Scheck.Show();
            this.Hide();
        }

        private void StaffchangeBack_button_Click(object sender, EventArgs e)
        {
            Stafflist Slist = new Stafflist();
            Slist.Show();
            this.Close();
        }

        private void Staffchange_Load(object sender, EventArgs e)
        {
            //Stafflistからのデータをロード時に表示
            Staffchange_Name.Text = Staff_Class.STAFF_NAME;
            Staffchange_Kana.Text = Staff_Class.STAFF_KANA;
            Staffchange_Sex.Text = Staff_Class.STAFF_SEX;
            Staffchange_Age.Text = Staff_Class.STAFF_AGE;
            Staffchange_Position.Text = Staff_Class.STAFF_POSITION;
            Staffchange_Tel.Text = Staff_Class.STAFF_TEL;
            Staffchange_Mail.Text = Staff_Class.STAFF_MAIL;
            Staffchange_Address.Text = Staff_Class.STAFF_ADDRESS;
           
        }
    }
}
