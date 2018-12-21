using System;

namespace DemoProject_Science
{
    class Program
    {
        static int MyPoint = 0;

        static void Main(string[] args)
        {
            MyPoint = 60;

            //例1
            if(MyPoint == 50) //MyPointが50であるかどうか。
            {
                Console.WriteLine("ポイントは50です"); //true(正しい)
            }
            else //elseはfalseと判定された時に来る
            {
                Console.WriteLine("ポイントは50じゃありません。"); //false(正しくない)
            }

            MyPoint = 180;

            //例2
            if (MyPoint > 100)//MyPointが100より大きいか。
            {
                Console.WriteLine("ポイントは100より多いです"); //true
            }
            else if (MyPoint != 0)//falseと判断された時、新たに条件分岐させる場合は else if
            {
                Console.WriteLine("ポイントは1以上100以下です");
            }
        }

        //実行結果
        //
        //例1    ポイントは50じゃありません。
        //例2    ポイントは100より多いです
        //
    }
}