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
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void AcountsBack_button_Click(object sender, EventArgs e)
        {
            IOcheck Back = new IOcheck();
            Back.Show();
            this.Close();
        }

        private void AcountsOk_button_Click(object sender, EventArgs e)
        {
            Accountscheck Acheck = new Accountscheck();
            Acheck.Show();
            this.Close();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            //サンプルデータ
            dataGridView1.Rows.Add();//一回書く事で項目が一行ずつ増える
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[4].Value = 2000;
            dataGridView1.Rows[1].Cells[4].Value = 3000;
            dataGridView1.Rows[2].Cells[4].Value = 4000;

            //表の行数を取得
            int cnt = dataGridView1.Rows.Count;

            int i;
            int total = 0;
            int value;
            for (i = 0; i < cnt - 1; i++)
            {
                value = (int)dataGridView1.Rows[i].Cells[4].Value;
                total = total + value;
            }

            Accounts_Alltotal.Text = total.ToString();
            
        }

        private void Acounts_Recieve_TextChanged(object sender, EventArgs e)
        {
            //預り金に入力された金額
            int recieve = int.Parse(Accounts_Recieve.Text);
            //合計金額
            int total = int.Parse(Accounts_Alltotal.Text);
            //お釣りを表示
            Accounts_Change.Text = (recieve - total).ToString();
        }
    }
}
