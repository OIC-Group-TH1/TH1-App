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
    public partial class IOcheck : Form
    {
        public IOcheck()
        {
            InitializeComponent();
        }

        private void IOcheckBack_button_Click(object sender, EventArgs e)
        {
            IOchecklist Back = new IOchecklist();
            Back.Show();
            this.Close();
        }

        private void IOcheckCI_button_Click(object sender, EventArgs e)
        {
            Accounts CI = new Accounts();
            CI.Show();
            this.Close();
        }

        private void IOcheckCO_button_Click(object sender, EventArgs e)
        {
            //メッセージダイアログ(YES,NO)の表示
            DialogResult result = MessageBox.Show("チェックアウトしますか？", "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                //デフォルトの選択ボタンは「いいえ」で設定
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                //「はい」が選択された時の処理を書
                IOchecklist Checkout = new IOchecklist();
                Checkout.Show();
                this.Close();
                
            }
            else if (result == DialogResult.No)
            {
                //「いいえ」が選択された時の処理を書
                //Reservecheck Resback = new Reservecheck();
                //Resback.Show();
                //this.Close();
            }
        }
    }
}
