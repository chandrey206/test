using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate string StrMod(string str);
class DelegateTest
{

    static string ReplaceSpaces(string s)
    {
        Console.WriteLine("Замена пробелов дефисами.");
        return s.Replace(' ', '-');
    }

    static string RemoveSpaces(string s)
    {
        string temp = "";
        int i;
        Console.WriteLine("Удаление пробелов.");
        for (i = 0; i < s.Length; i++)
            if (s[i] != ' ') temp += s[i];

        return temp;
    }

    static string Reverse(string s)
    {
        string temp = "";
        int i, j;
        Console.WriteLine("Обращение строки.");
        for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
            temp += s[i];
        return temp;
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        StrMod strOp = new StrMod(ReplaceSpaces);
        string str;

        str = strOp("Это простой тест.");
        Console.WriteLine("Результирующая строка: " + str);
        Console.WriteLine();
        strOp = new StrMod(RemoveSpaces);
        str = strOp("Это простой тест.");
        Console.WriteLine("Результирующая строка: " + str);
        Console.WriteLine();
        strOp = new StrMod(Reverse);
        str = strOp("Это простой тест.");
        Console.WriteLine("Результирующая строка: " + str);
        Console.ReadLine();
    }
}