using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample1
{
    //画面とロジックを分割するためのクラス
    class Logic
    {
        //sample add
        public static int add(int x, int y)
        {
            //呼び出し側使用例：
            //Logic.add(10, 20);
            return x + y;
        }
    }
}
