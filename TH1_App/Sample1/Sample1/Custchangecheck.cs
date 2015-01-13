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
    public partial class Custchangecheck : Form
    {
        public Custchangecheck()
        {
            InitializeComponent();
        }

        private void Custchangecheck_Load(object sender, EventArgs e)
        {
            Custchangecheck_Name.Text = Customer_Class._customer_name;
            Custchangecheck_Kana.Text = Customer_Class._customer_kana;
            Custchangecheck_Sex.Text = Customer_Class._customer_sex;
            Custchangecheck_Tel.Text = Customer_Class._customer_tel;
            Custchangecheck_Post.Text = Customer_Class._customer_post;
            Custchangecheck_Address.Text = Customer_Class._customer_address;
            Custchangecheck_Note.Text = Customer_Class._customer_note;
        }

        private void CustchangecheckOk_button_Click(object sender, EventArgs e)
        {
            DBconnection DBC = new DBconnection();
            DBC.DB_connect();

            try
            {
                SqlCommand scm = new SqlCommand
                   ("update TBL_CLIENT set "
                + "CLIENT_NAME = '" + Customer_Class._customer_name + "',"
                + "CLIENT_KANA = '" + Customer_Class._customer_kana + "',"
                + "CLIENT_SEX = '" + Customer_Class._customer_sex + "',"
                + "CLIENT_TEL = '" + Customer_Class._customer_tel + "',"
                + "CLIENT_POST = '" + Customer_Class._customer_post + "',"
                + "CLIENT_ADDRESS = '" + Customer_Class._customer_address + "',"
                + "CLIENT_NOTE = '" + Customer_Class._customer_note + "'"
                + "where CLIENT_CODE = '" + Customer_Class._customer_id + "'"
                , DBC.Get_scn());

                scm.ExecuteNonQuery();
                DBC.DB_DisConnect();
            }

            catch (Exception ex)
            {
                //データベースファイルクローズ
                DBC.DB_DisConnect();
                MessageBox.Show(ex.Message, "エラー");
            }

            Customerlist Clist = new Customerlist();
            Clist.Show();
            this.Close();

        }

        private void CustchangecheckNo_button_Click(object sender, EventArgs e)
        {
            Customerchange Cback = new Customerchange();
            Cback.Show();
            this.Close();
        }
    }
}
