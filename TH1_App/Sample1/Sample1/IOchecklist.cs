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
            IOcheck IOche = new IOcheck();
            IOche.Show();
            this.Close();
        }

        private void IOchecklist_Load(object sender, EventArgs e)
        {
            //セルを行として管理
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
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
