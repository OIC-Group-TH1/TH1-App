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
        private static string _code;
        private static string _name;
        private static string _kana;
        private static string _sex;
        private static string _age;
        private static string _position;
        private static string _tel;
        private static string _mail;
        private static string _day;
        private static string _address;

        public static string CODE
        {
            set { _code = value; }
            get { return _code; }
        }

        public static string NAME
        {
            set { _name = value; }
            get { return _name; }
        }
        public static string KANA
        {
            set { _kana = value; }
            get { return _kana; }
        }
        public static string SEX
        {
            set { _sex = value; }
            get { return _sex; }
        }
        public static string AGE
        {
            set { _age = value; }
            get { return _age; }
        }
        public static string POSITION
        {
            set { _position = value; }
            get { return _position; }
        }
        public static string TEL
        {
            set { _tel = value; }
            get { return _tel; }
        }
        public static string MAIL
        {
            set { _mail = value; }
            get { return _mail; }
        }
        public static string DAY
        {
            set { _day = value; }
            get { return _day; }
        }
        public static string ADDRESS
        {
            set { _address = value; }
            get { return _address; }
        }
    }
}
