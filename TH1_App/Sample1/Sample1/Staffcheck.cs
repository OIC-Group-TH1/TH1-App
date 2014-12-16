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
        Staffentry _Staffentry;
        Staffchange _Staffchange;

        public Staffcheck()
        {
            InitializeComponent();
        }

        public Staffcheck(string form_name)
        {
            InitializeComponent();
            _form_name = form_name;
        }

        //社員登録（Staffentry）から
        public Staffcheck(Staffentry form, string form_name)
        {
            InitializeComponent();
            _form_name = form_name; //画面判定用の簡易な変数
            _Staffentry = form;
        }
        //社員変更（Staffchange）から
        public Staffcheck(Staffchange form, string form_name)
        {
            InitializeComponent();
            _form_name = form_name; //画面判定用の簡易な変数
            _Staffchange = form;
        }

        private void Staffcheck_Load(object sender, EventArgs e)
        {
            //社員登録（Staffentry）からのデータを表示
            if (_form_name == "Staffentry")
            {
                Staffcheck_Name.Text = Staff.NAME;
                Staffcheck_Kana.Text = Staff.KANA;
                Staffcheck_Sex.Text = Staff.SEX;
                Staffcheck_Age.Text = Staff.AGE;
                Staffcheck_Position.Text = Staff.POSITION;
                Staffcheck_Tel.Text = Staff.TEL;
                Staffcheck_Mail.Text = Staff.MAIL;
                Staffcheck_Day.Text = Staff.DAY;
                Staffcheck_Address.Text = Staff.ADDRESS;
            }
            //社員変更（Staffchange）からのデータを表示
            else if (_form_name == "Staffchange")
            {
                Staffcheck_Name.Text = Staff.NAME;
                Staffcheck_Kana.Text = Staff.KANA;
                Staffcheck_Sex.Text = Staff.SEX;
                Staffcheck_Age.Text = Staff.AGE;
                Staffcheck_Position.Text = Staff.POSITION;
                Staffcheck_Tel.Text = Staff.TEL;
                Staffcheck_Mail.Text = Staff.MAIL;
                Staffcheck_Day.Text = Staff.DAY;
                Staffcheck_Address.Text = Staff.ADDRESS;
            }
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
                string age = Staffcheck_Age.Text;
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

            _Staffentry.Close();    //Hide状態の登録画面（Staffentry）を閉じる
            _Staffchange.Close();   //Hide状態の変更画面（Staffchange）を閉じる
        }

        private void StaffcheckNo_button_Click(object sender, EventArgs e)
        {
            if (_form_name == "Staffentry")
            {
                _Staffentry.Show();
                
            }
            else if (_form_name == "Staffchange")
            {
                _Staffchange.Show();
                
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

