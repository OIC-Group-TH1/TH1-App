﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sample1
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Name2_Click(object sender, EventArgs e)
        {

        }

        private void sex_Click(object sender, EventArgs e)
        {

        }

        private void Tel_Click(object sender, EventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void RoomType_Click(object sender, EventArgs e)
        {

        }

        private void Smoke_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CusomerChange_button_Click(object sender, EventArgs e)
        {
            Customerchange Cchange = new Customerchange();
            Cchange.Show();
            this.Close();
        }

        private void CustomerBack_button_Click(object sender, EventArgs e)
        {
            Customerlist Cchange = new Customerlist();
            Cchange.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
