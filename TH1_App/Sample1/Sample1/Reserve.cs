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
    public partial class Reserve : Form
    {
      

        public Reserve()
        {
            InitializeComponent();
            //宿泊人数コンボボックスへの値の設定
            Reserve_NcomboBox.Items.AddRange(new String[] { "１人", "２人", "３人", "４人" });
            
        }

        private void ReserveOk_button_Click(object sender, EventArgs e)
        {

           
            if (Reserve_NcomboBox.SelectedIndex >= 0)//宿泊人数を指定しているか判定
            {
                //予約確定メッセージ
                MessageBox.Show("予約が登録されました","予約確定",
                MessageBoxButtons.OK);
                
                //TOP画面へ
                Top_page Top = new Top_page();
                Top.Visible = true;
                this.Close();
            }
            else　//宿泊人数が指定されていない場合
            {
                
                MessageBox.Show("宿泊人数を選択してください", "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }


        }

        private void ReserveNo_button_Click(object sender, EventArgs e)
        {
            //カレンダーを表示
            Calendar Cal = new Calendar();
            Cal.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          /*
            //ラジオボタンによる禁煙、喫煙の判定
            if (radioButton1.Checked)　//禁煙
            {
               
            }
            else　//喫煙
            {
               
            }
          */
        }

        private void ReserveName_linkLabel_DoubleClick(object sender, EventArgs e)
        {
            //顧客一覧画面を表示
            Customerlist Clist = new Customerlist();
            Clist.Show();
            this.Close();

        }

    
   
    }
}