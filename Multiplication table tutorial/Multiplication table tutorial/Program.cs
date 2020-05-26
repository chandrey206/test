using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random random = new Random();
            Random random1 = new Random();
            Console.WriteLine("Забыли таблицу умнoжения? Потренируйтесь здесь!\n");
            int correctly = 0;
            int wrong = 0;
            for (; ; )
            {
                Console.Write("Сколько будет ");
                int value = random.Next(1, 10);
                int value1 = 0;
                for (int i = 0; i < 5; i++)
                {
                    value1 = random1.Next(0, 10);
                }
                Console.WriteLine(value + " * " + value1 + "?");

                if (value * value1 == Convert.ToInt32(Console.ReadLine()))
                {
                    Console.WriteLine("Верно! \n");
                    correctly += 1;
                }
                else
                {
                    Console.WriteLine("Не верно!\n");
                    Console.WriteLine("Подумайте лучше, сколько будет: " + value + " * " + value1 + "?");
                    if (value * value1 == Convert.ToInt32(Console.ReadLine()))
                    {
                        Console.WriteLine("Верно! \n");
                        correctly += 1;
                    }
                    else
                    {
                        Console.WriteLine("Не верно, " + value + " * " + value1 + " = " + value * value1 + "\n");
                        wrong += 1;
                    }
                    wrong += 1;
                }
                try
                {
                    if (correctly + wrong == 2)
                    {
                        Console.WriteLine("Результат:\n правильно - " + correctly + "не правильно - " + wrong);
                        Console.WriteLine("Нажмите 'enter' для продолжения, и дважды 'Выйти' для выхода");
                        
                        if (Console.ReadLine() == "Выйти") 
                        {
                            return;
                        }
                    }
                }
                catch (FormatException)
                {

                }
            }
        }
    }
}
