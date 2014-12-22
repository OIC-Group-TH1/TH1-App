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
    public partial class Customerecheck : Form
    {
        Customerentry Customerentry_main;

        public Customerecheck()
        {
            InitializeComponent();
        }
        public Customerecheck(Customerentry form)
        {
            InitializeComponent();
            Customerentry_main = form;
        }
        private void Customerecheck_Load(object sender, EventArgs e)
        {
            Customercheck_Name.Text     = Customer_Class._customer_name;
            Customercheck_Kana.Text     = Customer_Class._customer_kana;
            Customercheck_Sex.Text      = Customer_Class._customer_sex;
            Customercheck_Tel.Text      = Customer_Class._customer_tel;
            Customercheck_Post.Text     = Customer_Class._customer_post;
            Customercheck_Address.Text  = Customer_Class._customer_address;
            Customercheck_Note.Text     = Customer_Class._customer_note;
            //Customercheck_reservation.Text = Customer_Class._customer_reservation;

        }


        private void CustomercheckNo_button_Click(object sender, EventArgs e)
        {
            //Customerlist Custlist = new Customerlist(); エントリ画面に行くはずなのにリスト画面に行く。変更済み。確認要
            //Custlist.Show();
            Customerentry Customerentry = new Customerentry();
            Customerentry.Show();
            this.Close();
        }

        private void CustomercheckYes_button_Click(object sender, EventArgs e)
        {

            DBconnection DBC = new DBconnection();
            DBC.DB_connect();
            try
            {
                //データベースファイルオープン
                SqlCommand scm = new SqlCommand
                    ("insert into TBL_CLIENT (CLIENT_NAME, CLIENT_KANA, CLIENT_SEX, CLIENT_TEL, CLIENT_POST, CLIENT_ADDRESS, CLIENT_NOTE)values ("      //TBL_STAFFだったけどこれで大丈夫？現在TBL_CLIENTに変更
                        + "'" + Customer_Class._customer_name +    "',"
                        + "'" + Customer_Class._customer_kana +    "',"
                        + "'" + Customer_Class._customer_sex +     "',"
                        + "'" + Customer_Class._customer_tel +     "',"
                        + "'" + Customer_Class._customer_post +    "',"
                        + "'" + Customer_Class._customer_address + "',"
                        + "'" + Customer_Class._customer_note + "'" + ")", DBC.Get_scn());

                scm.ExecuteNonQuery();
                DBC.DB_DisConnect();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //データベースファイルクローズ
                MessageBox.Show(ex.Message);
                DBC.DB_DisConnect();
            }
            //Customerecheck Ccheck = new Customerecheck(); おかしい。確認要
            //Ccheck.Show();
            //this.Close();
            Customerlist Custlist = new Customerlist();
            Custlist.Show();
            this.Close();
        }
    }
}
