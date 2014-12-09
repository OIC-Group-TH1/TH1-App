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
            name = Customerentry_Name.Text;
            kana = Customerentry_Kana.Text;
            sex = Customerentry_Sex.SelectedItem.ToString();
            tel = Customerentry_Tel.Text;
            post = Customerentry_Post.Text;
            address = Customerentry_Address.Text;
            note = Customerentry_Note.Text;

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
