using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
>>>>>>> 4d88baa77b7dfa15966796c051838df109c6fa61

namespace Sample1
{
    public partial class Customerecheck : Form
    {
<<<<<<< HEAD
        Customerentry Customerentry_main;

        public Customerecheck()
=======
        public Customerecheck()
        {
            InitializeComponent();
        }

        private void CustomercheckNo_button_Click(object sender, EventArgs e)
>>>>>>> 4d88baa77b7dfa15966796c051838df109c6fa61
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
            System.Data.SqlClient.SqlConnection scn
                   = new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\b3316\Documents\globalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                //データベースファイルオープン
                scn.Open();
                char[] chararray = new char[5];
                chararray[0] = 'R';
                chararray[1] = '0';
                chararray[2] = '0';
                chararray[3] = '0';
                chararray[4] = '1';
                string name = Customercheck_Name.Text;
                string kana = Customercheck_Kana.Text;
                string sex = Customercheck_Sex.Text;
                string tel = Customercheck_Tel.Text;
                string post = Customercheck_Post.Text;
                string address = Customercheck_Address.Text;
                string note = Customercheck_Note.Text;

                SqlCommand scm = new SqlCommand
                    ("insert into STAFF_TABLE values ("
                        + "'" + chararray +"',"
                        + "'" + name + "',"
                        + "'" + kana + "',"
                        + "'" + sex + "',"
                        + "'" + tel + "',"
                        + "'" + post + "',"
                        + "'" + address + "',"
                        + "'" + note + "," + ") 'a','a'", scn);

                scm.ExecuteNonQuery();
                scn.Close();
            }

            catch (Exception ex)
            {
                //データベースファイルクローズ
                scn.Close();
                MessageBox.Show(ex.Message, "エラー");
            }
            Customerecheck Ccheck = new Customerecheck();
            Ccheck.Show();
            this.Close();
            Customerlist Custlist = new Customerlist();
            Custlist.Show();
            this.Close();
        }

<<<<<<< HEAD
        
=======
        private void CustomercheckYes_button_Click(object sender, EventArgs e)
        {
            Customer Cust = new Customer();
            Cust.Show();
            this.Close();
        }

>>>>>>> 4d88baa77b7dfa15966796c051838df109c6fa61
    }
}
