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
    public static class Staff_Class
    {
        //DataGridViewから取得したデータを保持する変数
        private static string _staff_code;
        private static string _staff_name;
        private static string _staff_kana;
        private static string _staff_sex;
        private static string _staff_age;
        private static string _staff_position;
        private static string _staff_tel;
        private static string _staff_mail;
        private static string _staff_day;
        private static string _staff_address;

        public static string STAFF_CODE
        {
            set { _staff_code = value; }
            get { return _staff_code; }
        }

        public static string STAFF_NAME
        {
            set { _staff_name = value; }
            get { return _staff_name; }
        }
        public static string STAFF_KANA
        {
            set { _staff_kana = value; }
            get { return _staff_kana; }
        }
        public static string STAFF_SEX
        {
            set { _staff_sex = value; }
            get { return _staff_sex; }
        }
        public static string STAFF_AGE
        {
            set { _staff_age = value; }
            get { return _staff_age; }
        }
        public static string STAFF_POSITION
        {
            set { _staff_position = value; }
            get { return _staff_position; }
        }
        public static string STAFF_TEL
        {
            set { _staff_tel = value; }
            get { return _staff_tel; }
        }
        public static string STAFF_MAIL
        {
            set { _staff_mail = value; }
            get { return _staff_mail; }
        }
        public static string STAFF_DAY
        {
            set { _staff_day = value; }
            get { return _staff_day; }
        }
        public static string STAFF_ADDRESS
        {
            set { _staff_address = value; }
            get { return _staff_address; }
        }
    }
}
