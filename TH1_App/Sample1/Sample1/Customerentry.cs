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
