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
    public partial class SampleDB : Form
    {
        System.Data.SqlClient.SqlConnection scn
                = new System.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\b3316\Documents\globalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        
        public SampleDB()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                scn.Open();
                MessageBox.Show("接続しました", "通知");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                scn.Close();
                MessageBox.Show("追加しました", "結果通知");

            }
            catch (Exception ex)
            {
                //データベースファイルクローズ
                scn.Close();
                MessageBox.Show(ex.Message, "エラー");
            }
        }
    }
}
