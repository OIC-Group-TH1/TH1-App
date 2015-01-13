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
    public partial class Customerchange : Form
    {
        public Customerchange()
        {
            InitializeComponent();
        }

        private void CustomerchangeBack_button_Click(object sender, EventArgs e)
        {
            Customer Back = new Customer();
            Back.Show();
            this.Close();
        }

        private void CustomerchangeChange_button_Click(object sender, EventArgs e)
        {

            Customer_Class._customer_name = Customerchange_Name.Text;
            Customer_Class._customer_kana = Customerchange_Kana.Text;
            Customer_Class._customer_sex = Customerchange_Sex.Text;
            Customer_Class._customer_tel = Customerchange_Tel.Text;
            Customer_Class._customer_post = Customerchange_Post.Text;
            Customer_Class._customer_address = Customerchange_Address.Text;
            Customer_Class._customer_note = Customerchange_Note.Text;
            
            Custchangecheck Cchange = new Custchangecheck();
            Cchange.Show();
            this.Close();

        }

        private void Customerchange_Load(object sender, EventArgs e)
        {
            Customerchange_Name.Text = Customer_Class._customer_name;
            Customerchange_Kana.Text = Customer_Class._customer_kana;
            Customerchange_Sex.Text = Customer_Class._customer_sex;
            Customerchange_Tel.Text = Customer_Class._customer_tel;
            Customerchange_Post.Text = Customer_Class._customer_post;
            Customerchange_Address.Text = Customer_Class._customer_address;
            Customerchange_Note.Text = Customer_Class._customer_note;

        }
    }
}
