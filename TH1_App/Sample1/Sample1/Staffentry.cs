﻿using System;
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
        public string name;
        public string kana;
        public string sex;
        public string age;
        public string position;
        public string tel;
        public string mail;
        public string day;
        public string address;

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
<<<<<<< HEAD
                name = Staffentry_Name.Text;
                kana = Staffentry_Kana.Text;
                sex = Staffentry_Sex.SelectedItem.ToString();
                age = Staffentry_Age.Text;
                position = Staffentry_Position.Text;
                tel = Staffentry_Tel.Text;
                mail = Staffentry_Mail.Text;
                day = Staffentry_Day.Text;
                address = Staffentry_Address.Text;
=======
            System.Data.SqlClient.SqlConnection scn
                   = new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\b3316\Documents\globalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                //データベースファイルオープン
                scn.Open();
                char[] chararray = new char[6];
                chararray[0] = 'S';
                chararray[1] = '0';
                chararray[2] = '0';
                chararray[3] = '0';
                chararray[4] = '0';
                chararray[5] = '1';
                string name = Staffentry_Name.Text;
                Boolean sex = Convert.ToBoolean(Staffentry_Sex.SelectedIndex);
                string age = Staffentry_Age.Text;
                string position = Staffentry_Position.Text;
                string tel = Staffentry_Tel.Text;
                string mail = Staffentry_Mail.Text;
                string day = Staffentry_Day.Text;
                string address = Staffentry_Address.Text;

                SqlCommand scm = new SqlCommand
                    ("insert into TBL_STAFF values ("
                        + "'" + chararray + "',"
                        + "'" + name + "',"
                        + "'" + sex + "',"
                        + "'" + age + "',"
                        + "'" + position + "',"
                        + "'" + tel + "',"
                        + "'" + mail + "',"
                        + "'" + day + "',"
                        + "'" + address + "')", scn);
>>>>>>> 4d88baa77b7dfa15966796c051838df109c6fa61

            Staffcheck Scheck = new Staffcheck(this);
            Scheck.Show();
            this.Close();
           
        }


        private void Staffentry_Load(object sender, EventArgs e)
        {
            
            Staffentry_Sex.Items.Add("男性");
            Staffentry_Sex.Items.Add("女性");
            this.Controls.Add(Staffentry_Sex);
            Staffentry_Sex.SelectedIndex = 0;
        }

        private void Staffentry_Sex_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
