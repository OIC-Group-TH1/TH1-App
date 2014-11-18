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
    public partial class Customerchange : Form
    {
        public Customerchange()
        {
            InitializeComponent();
        }

        private void CustomerchangeBack_button_Click(object sender, EventArgs e)
        {
            Customer Back = new Customer();
            Back.Show();
            this.Close();
        }

        private void CustomerchangeChange_button_Click(object sender, EventArgs e)
        {
            Customerecheck Custcheck = new Customerecheck();
            Custcheck.Show();
            this.Close();
        }

        private void CustomerchangeDelete_button_Click(object sender, EventArgs e)
        {
            //メッセージダイアログ(YES,NO)の表示
            DialogResult result = MessageBox.Show("削除してもよろしいですか？","",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                //デフォルトの選択ボタンは「いいえ」で設定
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                //「はい」が選択された時の処理を書く
                Customerlist Custlist = new Customerlist();
                Custlist.Show();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                //「いいえ」が選択された時の処理を書く
            }
        }
    }
}
