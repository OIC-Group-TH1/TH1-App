using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample1
{
    //呼び出し例:
    //get:
        //string str = Staff.CODE;
    //set:
        //Staff.CODE = dataGridView1.CurrentRow.Cells[0].Value.ToString();
    class Customer_Class
    {
        //DataGridViewから取得したデータを保持する変数
        public static int _customer_id;
        public static string _customer_name;
        public static string _customer_kana;
        public static string _customer_sex;
        public static string _customer_tel;
        public static string _customer_post;
        public static string _customer_address;
        public static string _customer_note;

        public static int CUSTOMER_ID
        {
            set { _customer_id = value; }
            get { return _customer_id; }
        }
        public static string CUSTOMER_NAME
        {
            set { _customer_name = value; }
            get { return _customer_name; }
        }

        public static string CUSTOMER_KANA
        {
            set { _customer_kana = value; }
            get { return _customer_kana; }
        }
        public static string CUSTOMER_SEX
        {
            set { _customer_sex = value; }
            get { return _customer_sex; }
        }
        public static string CUSTOMER_TEL
        {
            set { _customer_tel = value; }
            get { return _customer_tel; }
        }
        public static string CUSTOMER_POST
        {
            set { _customer_post = value; }
            get { return _customer_post; }
        }
        public static string CUSTOMER_ADDRESS
        {
            set { _customer_address = value; }
            get { return _customer_address; }
        }
        public static string CUSTOMER_NOTE
        {
            set { _customer_note = value; }
            get { return _customer_note; }
        }
    }
}
