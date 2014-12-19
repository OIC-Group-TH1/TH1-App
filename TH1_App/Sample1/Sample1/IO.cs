using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample1
{
    public static class IO
    {
        private static DateTime _date;
        private static int _no;
        private static int _ccode;
        private static int _rcode;
        private static string _type;
        private static string _smoke;
        private static string _name;
        private static string _number;
        private static string _value;
        private static string _total;
        private static string _receive;
        private static string _change;
        private static string _kana;
        private static string _sex;
        private static string _tel;
        private static string _post;
        private static string _address;
        private static string _note;

       


        public static DateTime DATE
        {
            set { _date = value; }
            get { return _date; }
        }
        public static int NO
        {
            set { _no = value; }
            get { return _no; }
        }
        public static int CCODE
        {
            set { _ccode = value; }
            get { return _ccode; }
        }
        public static int RCODE
        {
            set { _rcode = value; }
            get { return _rcode; }
        }
        public static string TYPE
        {
            set { _type = value; }
            get { return _type; }
        }
        public static string SMOKE
        {
            set { _smoke = value; }
            get { return _smoke; }
        }
        public static string NAME
        {
            set { _name = value; }
            get { return _name; }
        }
        public static string NUMBER
        {
            set { _number = value; }
            get { return _number; }
        }
        public static string VALUE
        {
            set { _value = value; }
            get { return _value; }
        }
        public static string TOTAL
        {
            set { _total = value; }
            get { return _total; }
        }
        public static string RECEIVE
        {
            set { _receive = value; }
            get { return _receive; }
        }
        public static string CHAGE
        {
            set { _change = value; }
            get { return _change; }
        }
    }
}
