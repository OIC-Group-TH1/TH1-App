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
    public partial class Reservecheck : Form
    {
        reservelist reservelist_main;

        public Reservecheck(reservelist form)
        {
            InitializeComponent();
            reservelist_main = form;
        }

        private void Reservecheck_Load(object sender, EventArgs e)
        {
            Reservecheck_No.Text = reservelist_main.r_code;
            Reservecheck_Name.Text = reservelist_main.c_name;
            Reservecheck_Tel.Text = reservelist_main.c_tel;
        }

        private void CustomerentryKana_label2_Click(object sender, EventArgs e)
        {

        }

        private void ReservecheckBack_button_Click(object sender, EventArgs e)
        {
            Calendar Cal = new Calendar();
            Cal.Show();
            this.Close();
        }

        private void ReservecheckTop_button_Click(object sender, EventArgs e)
        {
            Top_page Top = new Top_page();
            Top.Show();
            this.Close();
        }

        private void ReservecheckCchange_button_Click(object sender, EventArgs e)
        {
            Customerlist Custlist = new Customerlist();
            Custlist.Show();
            this.Close();
            
        }

        private void ReservecheckDelete_button_Click(object sender, EventArgs e)
        {
            //メッセージダイアログ(YES,NO)の表示
            DialogResult result = MessageBox.Show("削除してもよろしいですか？", "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                //デフォルトの選択ボタンは「いいえ」で設定
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                //「はい」が選択された時の処理を書
                System.Data.SqlClient.SqlConnection scn
                   = new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\b3316\Documents\globalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                try
                {
                    //データベースファイルオープン
                    scn.Open();
                   SqlCommand scm = new SqlCommand
                        ("DELETE FROM RESERVATION_TABLE WHERE RESERVATION_CODE = ");

                    scm.ExecuteNonQuery();
                    scn.Close();
                }

                catch (Exception ex)
                {
                    //データベースファイルクローズ
                    scn.Close();
                    MessageBox.Show(ex.Message, "エラー");
                }

                Top_page Top = new Top_page();
                Top.Show();
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

        private void ReservecheckRchange_button_Click(object sender, EventArgs e)
        {
            Calendar Cal = new Calendar();
            Cal.Show();
            this.Close();
        }

        
    }
}
