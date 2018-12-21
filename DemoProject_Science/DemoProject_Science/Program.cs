using System;

namespace DemoProject_Science
{
    class Program
    {
        static int MyID = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("一回目" + MyID);

            MyID = MyID + 10;
            Console.WriteLine("二回目" + MyID);

            MyID = 100 * 2;
            Console.WriteLine("三回目" + MyID);

            MyID -= 100;
            Console.WriteLine("四回目" + MyID);
        }
    }
}