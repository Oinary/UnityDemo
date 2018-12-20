using System;

namespace DemoProject_Science
{
    class Program
    {
        static int MyID;
        static string MyName;
        static float MyShoesSize;

        static void Main(string[] args)
        {
            MyID = 114514;
            MyName = "高輪ゲートウェイ";
            MyShoesSize = 26.5f;

            Console.WriteLine("IDは" + MyID);
            Console.WriteLine("名前は" + MyName);
            Console.WriteLine("靴のサイズは" + MyShoesSize + "cm");

            MyID = 24;
            Console.WriteLine("本当のIDは" + MyID + "でした…");
        }
    }
}