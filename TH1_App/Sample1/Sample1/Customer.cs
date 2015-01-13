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
    public partial class Customer : Form
    {
        Customerlist custmerlist_main;

        public Customer()
        {
            InitializeComponent();
        }

        public Customer(Customerlist form)
        {
            InitializeComponent();
            custmerlist_main = form;
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
                DBconnection DBC = new DBconnection();
                try
                {
                    //データベースファイルオープン
                    DBC.DB_connect();
                    SqlCommand command = new SqlCommand();

                    command.CommandText =
                      "DELETE FROM TBL_CLIENT WHERE CLIENT_CODE =" + "'" + Customer_Class._customer_id + "'";
                    command.Connection = DBC.Get_scn();
                    SqlDataReader reader = command.ExecuteReader();
                    //TOP画面へ
                    Top_page Top = new Top_page();
                    Top.Visible = true;
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //データベースファイルクローズ
                    DBC.DB_DisConnect();
                }
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

        private void Customer_Load(object sender, EventArgs e)
        {
            Customer_Name.Text = Customer_Class._customer_name;
            Customer_Kana.Text = Customer_Class._customer_kana;
            Customer_Sex.Text = Customer_Class._customer_sex;
            Customer_Tel.Text = Customer_Class._customer_tel;
            Customer_Post.Text = Customer_Class._customer_post;
            Customer_Address.Text = Customer_Class._customer_address;
            Customer_Note.Text = Customer_Class._customer_note;

        }

        private void CustomerReserve_button_Click(object sender, EventArgs e)
        {
            Reserve Rserv = new Reserve();
            Rserv.Show();
            this.Close();
        }
    }
}
