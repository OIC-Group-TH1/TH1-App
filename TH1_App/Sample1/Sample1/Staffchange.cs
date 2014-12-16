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
                //「はい」が選択された時の処理を書く
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
            Staff.NAME = Staffchange_Name.Text; 
            Staff.KANA = Staffchange_Kana.Text;
            Staff.SEX = Staffchange_Sex.Text;
            Staff.AGE = Staffchange_Age.Text;
            Staff.POSITION = Staffchange_Position.Text;
            Staff.TEL = Staffchange_Tel.Text;
            Staff.MAIL = Staffchange_Mail.Text;
            Staff.ADDRESS = Staffchange_Address.Text; 

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
            Staffchange_Name.Text = Staff.NAME;
            Staffchange_Kana.Text = Staff.KANA;
            Staffchange_Sex.Text = Staff.SEX;
            Staffchange_Age.Text = Staff.AGE;
            Staffchange_Position.Text = Staff.POSITION;
            Staffchange_Tel.Text = Staff.TEL;
            Staffchange_Mail.Text = Staff.MAIL;
            Staffchange_Address.Text = Staff.ADDRESS;
           
        }
    }
}
