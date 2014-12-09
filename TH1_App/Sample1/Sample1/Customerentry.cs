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
    public partial class Customerentry : Form
    {
        public string name;
        public string kana;
        public string sex;
        public string tel;
        public string post;
        public string address;
        public string note;


        public Customerentry()
        {
            InitializeComponent();
        }

        private void CustomerentryBack_button_Click(object sender, EventArgs e)
        {
            Customerlist Back = new Customerlist();
            Back.Visible = true;
            this.Close();
        }

        private void CustomerentryTop_button_Click(object sender, EventArgs e)
        {
            Top_page Top = new Top_page();
            Top.Visible = true;
            this.Close();
        }

        private void CustomerentryEntry_button_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            name = Customerentry_Name.Text;
            kana = Customerentry_Kana.Text;
            sex = Customerentry_Sex.SelectedItem.ToString();
            tel = Customerentry_Tel.Text;
            post = Customerentry_Post.Text;
            address = Customerentry_Address.Text;
            note = Customerentry_Note.Text;
=======
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
                string name = Customerentry_Name.Text;
                string kana = Customerentry_Kana.Text;
                Boolean sex = Convert.ToBoolean(Customerentry_Sex.SelectedIndex);
                string tel = Customerentry_Tel.Text;
                string post = Customerentry_Post.Text;
                string address = Customerentry_Address.Text;
                string note = Customerentry_Note.Text;

                SqlCommand scm = new SqlCommand
                    ("insert into TBL_CLIENT values ("
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
>>>>>>> 4d88baa77b7dfa15966796c051838df109c6fa61

            Customerecheck Ccheck = new Customerecheck(this);
            Ccheck.Show();
            this.Close();

            
        }

        private void Customerentry_Load(object sender, EventArgs e)
        {
            Customerentry_Sex.Items.Add("男性");
            Customerentry_Sex.Items.Add("女性");
            this.Controls.Add(Customerentry_Sex);
            Customerentry_Sex.SelectedIndex = 0;
        }
    }
}
