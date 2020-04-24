﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    public abstract class Dish
    {
        public float mass, price;
        protected float coefficient = (float)2.3;
        public abstract float Getcost();
    }

    public class Pizza : Dish
    {
        public Ingredients[] ingredients = new Ingredients[10];

        override public float Getcost()
        {
            float getcost = 0;

            for (int i = 0; i < 2; i++)
            {

                getcost = getcost + ingredients[i].Getcost();
            }
            return getcost * coefficient;


        }
        int max;
        public void Max(int i)
        {
            max = i;
        }

    }
    public class Ingredients
    {
        public float mass, price;
        public string name;
        public virtual float Getcost()
        {
            return mass * price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {

                Pizza pizza1 = new Pizza();

                Console.WriteLine("Введите количество ингридиентов (до 10 наименований)");
                int max = Convert.ToInt32(Console.ReadLine());

                pizza1.Max(max);
                for (int i = 0; i < max; i++)
                {
                    pizza1.ingredients[i] = new Ingredients();
                }



                for (int i = 0; i < max; i++)
                {
                    Console.WriteLine("Введите название " + (i + 1) + " -го ингридиента");
                    pizza1.ingredients[i].name = Console.ReadLine();
                    Console.WriteLine("Введите желаемую массу " + (i + 1) + " -го ингридиента");
                    pizza1.ingredients[i].mass = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите цену " + (i + 1) + " - го ингридиента");
                    pizza1.ingredients[i].price = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Cost of such pizza = " + pizza1.Getcost() + " grn");
                Console.ReadLine();

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Я не могу обработать блюдо с больше чем 10 ингридиентов, прости((");
                Console.ReadLine();
            }


        }
    }
}