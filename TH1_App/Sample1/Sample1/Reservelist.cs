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
    public partial class reservelist : Form
    {
        public string r_code;
        public string c_name;
        public string c_tel;
        public string r_no;
        public string r_date; //指定日付格納変数


        public reservelist()
        {
            InitializeComponent();
        }
        //表示日時キャスト　関数
        public reservelist(DateTime str)
        {
            InitializeComponent();
            dateTimePicker1.Value = str;
            r_date = str.ToString("yyyy/MM/dd");
        }

        private void ReservelistBack_button_Click(object sender, EventArgs e)
        {
            //カレンダーへ戻る
            Calendar Back = new Calendar();
            Back.Visible = true;
            this.Close();
        }

        public void reservelist_Load(object sender, EventArgs e)
        {
            //セルを行として管理
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

            dataGridView1.Rows.Clear();
            //SQL Serverからリストを取得
            DBconnection DBC = new DBconnection();
            SqlCommand command = new SqlCommand();
            try
            {
                DBC.DB_connect();
                command.CommandText = " SELECT RO.ROOM_CODE,RO.ROOM_NAME,RO.ROOM_CIGARETTE,CL.CLIENT_NAME,CL.CLIENT_KANA,CL.CLIENT_TEL,RE.RESERVATION_NUM,RE.RESERVATION_CODE FROM TBL_ROOM RO LEFT OUTER JOIN (SELECT * FROM TBL_RESERVATION WHERE RESERVATION_DATE =" + "'" + r_date + "') RE ON (RE.ROOM_CODE = RO.ROOM_CODE) LEFT OUTER JOIN TBL_CLIENT CL ON (RE.CLIENT_CODE = CL.CLIENT_CODE)";
                    
                // SQLを実行
                command.Connection = DBC.Get_scn();
                SqlDataReader reader = command.ExecuteReader();
                int m, n;
                for (m = 0; reader.Read(); m++)
                {
                    dataGridView1.Rows.Add();
                    for (n = 0; n < 8; n++)
                    {
                        reader.GetValue(n);
                        if (reader.GetValue(n) != DBNull.Value)
                        {
                            if (n == 0)
                            {
                                dataGridView1.Rows[m].Cells[n].Value = reader.GetValue(n).ToString();
                            }
                            else if (n == 6)
                            {
                                dataGridView1.Rows[m].Cells[n].Value = reader.GetValue(n).ToString();
                            }
                            else if (n == 7)
                            {
                                dataGridView1.Rows[m].Cells[n].Value = reader.GetValue(n).ToString();
                            }
                            else
                            {
                                dataGridView1.Rows[m].Cells[n].Value = reader.GetValue(n);
                            }
                        }
                    }
                }
                DBC.DB_DisConnect();
            }
            catch (Exception ex)
            {
                DBC.DB_DisConnect();
                MessageBox.Show(ex.Message);
            }

            //セルの数の分色を付ける
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                //仮で色を指定
                if (dataGridView1.Rows[i].Cells[7].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "True")
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    else if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "False" && dataGridView1.Rows[i].Cells[3].Value == null)
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.YellowGreen;
                    else if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "False")
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                }
            }
        }

        private void ReservelistTop_button_Click(object sender, EventArgs e)
        {
            //トップページへ戻る
            Top_page Top = new Top_page();
            Top.Show();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //宿泊者セルのデータがない場合
            if (dataGridView1.CurrentRow.Cells[3].Value == null)
            {
                //ダブルクリックのnull選択のエラー対策
                if (dataGridView1.CurrentRow.Cells[1].Value != null)
                {
                    //部屋情報のセッティング（Reserve.cs)
                    Reserve_Class._Reserve_date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                    Reserve_Class._Reserve_room_code = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    //Reserve_Class._Reserve_customer_id  =   dataGridView1.Rows[i].Cells[].Value.ToString();
                    //Reserve_Class._Reserve_date =   dataGridView1.Rows[].Cells[0].Value.ToString();
                    //Reserve_Class._Reserve_date =   dataGridView1.Rows[].Cells[1].Value.ToString();
                    //Reserve_Class._Reserve_date =   dataGridView1.Rows[].Cells[2].Value.ToString();

                    //顧客一覧を表示
                    Customerlist Clist = new Customerlist();
                    Clist.Show();
                    this.Close();
                }
            }

            //宿泊者セルのデータがある場合
            else if (dataGridView1.CurrentRow.Cells[3].Value != null)
            {

                //値の取得(これをselect文で検索し、情報をReservecheckで)
                r_code = dataGridView1.CurrentRow.Cells[7].Value.ToString();

                //情報を持って予約情報を表示
                Reservecheck Rcheck = new Reservecheck(this);
                Rcheck.Show();
                this.Close();
            }
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            r_date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            dataGridView1.Rows.Clear();
            //SQL Serverからリストを取得
            DBconnection DBC = new DBconnection();
            SqlCommand command = new SqlCommand();
            try
            {
                DBC.DB_connect();
                command.CommandText = "SELECT RO.ROOM_CODE,RO.ROOM_NAME,RO.ROOM_CIGARETTE,CL.CLIENT_NAME,CL.CLIENT_KANA,CL.CLIENT_TEL,RE.RESERVATION_NUM,RE.RESERVATION_CODE FROM TBL_ROOM RO LEFT OUTER JOIN (SELECT * FROM TBL_RESERVATION WHERE RESERVATION_DATE =" + "'" + r_date + "') RE ON (RE.ROOM_CODE = RO.ROOM_CODE) LEFT OUTER JOIN TBL_CLIENT CL ON (RE.CLIENT_CODE = CL.CLIENT_CODE)";

                // SQLを実行
                command.Connection = DBC.Get_scn();
                SqlDataReader reader = command.ExecuteReader();
                int m, n;
                for (m = 0; reader.Read(); m++)
                {
                    dataGridView1.Rows.Add();
                    for (n = 0; n < 8; n++)
                    {
                        reader.GetValue(n);
                        if (reader.GetValue(n) != DBNull.Value)
                        {
                            if (n == 0)
                            {
                                dataGridView1.Rows[m].Cells[n].Value = reader.GetValue(n).ToString();
                            }
                            else if (n == 6)
                            {
                                dataGridView1.Rows[m].Cells[n].Value = reader.GetValue(n).ToString();
                            }
                            else if (n == 7)
                            {
                                dataGridView1.Rows[m].Cells[n].Value = reader.GetValue(n).ToString();
                            }
                            else
                            {
                                dataGridView1.Rows[m].Cells[n].Value = reader.GetValue(n);
                            }
                        }
                    }
                }
                DBC.DB_DisConnect();
            }
            catch (Exception ex)
            {
                DBC.DB_DisConnect();
                MessageBox.Show(ex.Message);
            }

            //セルの数の分色を付ける
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                //仮で色を指定
                if (dataGridView1.Rows[i].Cells[7].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "True")
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    else if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "False" && dataGridView1.Rows[i].Cells[3].Value == null)
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.YellowGreen;
                    else if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "False")
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                }
            }
        }
    }
}
