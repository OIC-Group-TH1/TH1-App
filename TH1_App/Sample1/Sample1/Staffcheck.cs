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
    public partial class Staffcheck : Form
    {
        string _form_name;
        Staffentry Staffentry_main;

        public Staffcheck()
        {
            InitializeComponent();
        }

        public Staffcheck(string form_name)
        {
            InitializeComponent();
            _form_name = form_name;
        }

        //form_nameに移動前のフォーム名を入力
        public Staffcheck(Staffentry form, string form_name)
        {
            InitializeComponent();
            _form_name = form_name; //画面判定用の簡易な変数
            Staffentry_main = form;
        }

        private void Staffcheck_Load(object sender, EventArgs e)
        {

            //Staffcheck_Name.Text = Staffentry_main.name;
            //Staffcheck_Kana.Text = Staffentry_main.kana;
            //Staffcheck_Sex.Text = Staffentry_main.sex;
            //Staffcheck_Age.Text = Staffentry_main.age;
            //Staffcheck_Position.Text = Staffentry_main.position;
            //Staffcheck_Tel.Text = Staffentry_main.tel;
            //Staffcheck_Mail.Text = Staffentry_main.mail;
            //Staffcheck_Day.Text = Staffentry_main.day;
            //Staffcheck_Address.Text = Staffentry_main.address;
        }
        private void StaffcheckYes_button_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection scn
                   = new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\b3316\Documents\globalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                //データベースファイルオープン
                scn.Open();

                string name = Staffcheck_Name.Text;
                string kana = Staffcheck_Kana.Text;
                string sex = Staffcheck_Sex.Text;
                string age = StaffcheckAge_label.Text;
                string position = Staffcheck_Position.Text;
                string tel = Staffcheck_Tel.Text;
                string mail = Staffcheck_Mail.Text;
                string day = Staffcheck_Day.Text;
                string address = Staffcheck_Address.Text;

                SqlCommand scm = new SqlCommand
                    ("insert into TBL_STAFF values ("
                        + "'" + name + "',"
                        + "'" + kana + "',"
                        + "'" + sex + "',"
                        + "'" + age + "',"
                        + "'" + position + "',"
                        + "'" + tel + "',"
                        + "'" + mail + "',"
                        + "'" + day + "',"
                        + "'" + address + "'" + ")", scn);

                scm.ExecuteNonQuery();
                scn.Close();
            }

            catch (Exception ex)
            {
                //データベースファイルクローズ
                scn.Close();
                MessageBox.Show(ex.Message, "エラー");
            }
            Stafflist Scheckok = new Stafflist();
            Scheckok.Show();
            this.Close();
        }

        private void StaffcheckNo_button_Click(object sender, EventArgs e)
        {
            if (_form_name == "Staffentry")
            {
                Staffentry Scheckno = new Staffentry();
                Scheckno.Show();
            }
            else if (_form_name == "Staffchange")
            {
                Staffchange Schange = new Staffchange();
                Schange.Show();
            }
            else
            {
                Stafflist Slist = new Stafflist();
                Slist.Show();
            }
            this.Close();
        }
    }
}

