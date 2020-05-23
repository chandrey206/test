using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Pizzeria2
{
    public abstract class Dish
    {
        public float Mass, Price;
        protected float PriceCoefficient = (float)2.3;
        public abstract float GetCost(int max);
    }
    public class Pizza : Dish
    {
        public Ingredients[] ingredients = new Ingredients[10];
        override public float GetCost(int max)
        {
            float GetCost = 0;
            throw new InvalidOperationException();

            for (int i = 0; i < max; i++)
            {

                GetCost += ingredients[i].Getcost();
            }
            return GetCost * PriceCoefficient;
        }
    }
    public class Ingredients
    {
        public float Mass, Price;
        public string Name;
        public virtual float Getcost()
        {
            return Mass * Price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            {
                Pizza pizza = new Pizza();
                Console.WriteLine("Введите количество ингридиентов (до 10 наименований)");

                int max = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < max; i++)
                {
                    pizza.ingredients[i] = new Ingredients();
                }

                for (int i = 0; i < max; i++)
                {

                    Console.WriteLine("Введите название " + (i + 1) + " -го ингридиента");
                    pizza.ingredients[i].Name = Console.ReadLine();
                    Console.WriteLine("Введите желаемую массу " + (i + 1) + " -го ингридиента");
                    pizza.ingredients[i].Mass = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите цену " + (i + 1) + " - го ингридиента");
                    pizza.ingredients[i].Price = Convert.ToInt32(Console.ReadLine());
                }
                try
                {
                    Console.WriteLine("Стоимость пиццы = " + pizza.GetCost(max) + " грн");
                    float j = 0;
                    for (int i = 0; i < max; i++)
                    {
                        j += pizza.ingredients[i].Mass;
                    }
                    Console.WriteLine("Общая масса пиццы составляет " + j + " кг");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Введите не ноль");
                }

                Console.ReadLine();
            }
        }
    }
}

