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
            Customercheck_Name.Text = Customerentry_main.name;
            Customercheck_Kana.Text = Customerentry_main.kana;
            Customercheck_Sex.Text = Customerentry_main.sex;
            Customercheck_Tel.Text = Customerentry_main.tel;
            Customercheck_Post.Text = Customerentry_main.post;
            Customercheck_Address.Text = Customerentry_main.address;
            Customercheck_Note.Text = Customerentry_main.note;

        }


        private void CustomercheckNo_button_Click(object sender, EventArgs e)
        {
            Customerlist Custlist = new Customerlist();
            Custlist.Show();
            this.Close();
        }

        private void CustomercheckYes_button_Click(object sender, EventArgs e)
        {

            DBconnection DBC = new DBconnection();
            DBC.DB_connect();
            try
            {
                //データベースファイルオープン
                string name = Customercheck_Name.Text;
                string kana = Customercheck_Kana.Text;
                string sex = Customercheck_Sex.Text;
                string tel = Customercheck_Tel.Text;
                string post = Customercheck_Post.Text;
                string address = Customercheck_Address.Text;
                string note = Customercheck_Note.Text;                

                SqlCommand scm = new SqlCommand
                    ("insert into STAFF_TABLE values ("
                        + "'" + name + "',"
                        + "'" + kana + "',"
                        + "'" + sex + "',"
                        + "'" + tel + "',"
                        + "'" + post + "',"
                        + "'" + address + "',"
                        + "'" + note + "'" + ")", DBC.Get_scn());

                scm.ExecuteNonQuery();
                DBC.DB_DisConnect();
            }

            catch (Exception ex)
            {
                //データベースファイルクローズ
                DBC.DB_DisConnect();
            }
            Customerecheck Ccheck = new Customerecheck();
            Ccheck.Show();
            this.Close();
            Customerlist Custlist = new Customerlist();
            Custlist.Show();
            this.Close();
        }
    }
}
