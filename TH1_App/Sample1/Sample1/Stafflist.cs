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
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //宿泊者セルのデータがある場合
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                //社員変更画面を表示
                Staffchange Schange = new Staffchange();
                Schange.Show();
                this.Close();
            }
        }


    }
}
