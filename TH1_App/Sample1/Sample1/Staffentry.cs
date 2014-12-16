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
                Staff.NAME = Staffentry_Name.Text;
                Staff.KANA = Staffentry_Kana.Text;
                Staff.SEX = Staffentry_Sex.SelectedItem.ToString();
                Staff.AGE = Staffentry_Age.Text;
                Staff.POSITION = Staffentry_Position.Text;
                Staff.TEL = Staffentry_Tel.Text;
                Staff.MAIL = Staffentry_Mail.Text;
                Staff.DAY = Staffentry_Day.Text;
                Staff.ADDRESS = Staffentry_Address.Text;

            Staffcheck Scheck = new Staffcheck(this,"Staffentry");
            Scheck.Show();
            this.Hide();
           
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
