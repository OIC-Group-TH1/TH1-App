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
        public Staffchange()
        {
            InitializeComponent();
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
            Staffcheck Scheck = new Staffcheck("Staffchange");
            Scheck.Show();
            this.Close();
        }

        private void StaffchangeBack_button_Click(object sender, EventArgs e)
        {
            Stafflist Slist = new Stafflist();
            Slist.Show();
            this.Close();
        }
    }
}
