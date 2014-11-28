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
    public partial class Staffentry : Form
    {
        public Staffentry()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StaffentryBack_button_Click(object sender, EventArgs e)
        {
            Stafflist Back = new Stafflist();
            Back.Visible = true;
            this.Close();


        }

        private void StaffentryEntry_button_Click(object sender, EventArgs e)
        {
            Staffcheck Scheck = new Staffcheck();
            Scheck.Show();
            this.Close();

            System.Data.SqlClient.SqlConnection scn
                   = new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\b3316\Documents\globalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                //データベースファイルオープン
                scn.Open();
                string name = Staffentry_Name.Text;
                string sex = Staffentry_Sex.Text;
                string age = Staffentry_Age.Text;
                string position = Staffentry_Position.Text;
                string tel = Staffentry_Tel.Text;
                string mail = Staffentry_Mail.Text;
                string day = Staffentry_Day.Text;
                string address = Staffentry_Address.Text;

                SqlCommand scm = new SqlCommand
                    ("insert into STAFF_TABLE values ("
                        + "'" + name + "',"
                        + "'" + sex + "',"
                        + "'" + age + "',"
                        + "'" + position + "',"
                        + "'" + tel + "',"
                        + "'" + mail + "',"
                        + "'" + day + "',"
                        + "'" + address + "," + ")", scn);

                scm.ExecuteNonQuery();
                scn.Close();
            }

            catch (Exception ex)
            {
                //データベースファイルクローズ
                scn.Close();
                MessageBox.Show(ex.Message, "エラー");
            }
        }


        private void Staffentry_Load(object sender, EventArgs e)
        {

        }
    }
}
