using System;
using System.Globalization;

namespace TEST
{
    delegate int Inter(int i);
    class demo
    {
        static Inter a = delegate (int g) { return g * g; };
        static void Main()
        {
            Console.WriteLine(a(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }
    }
}
