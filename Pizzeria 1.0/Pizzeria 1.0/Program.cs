﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Pizzeria1
{
    public abstract class Dish
    {
        public decimal Mass, Price;
        protected decimal PriceCoefficient = (decimal)2.3;
        public abstract decimal GetCost();
    }

    public class Pizza : Dish
    {
        public Ingredient[] Ingredients = new Ingredient[3];
        override public decimal GetCost()
        {
            decimal sum = 0;
            for (int i = 0; i < Ingredients.Length; i++)
            {
                sum += Ingredients[i].GetCost();
            }
            return sum;
        }
    }
    
    public abstract class Ingredient
    {
        public string Name;
        public decimal Mass, Price;
        public abstract decimal GetCost();
    }
    public class Cake : Ingredient
    {
        public override decimal GetCost()
        {
            return Mass * Price;
        }
    }
    public class Meat : Ingredient
    {
        public override decimal GetCost()
        {
            return Mass * Price;
        }
    }
    public class Tomato : Ingredient
    {
        public override decimal GetCost()
        {
            return Mass * Price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Pizza onepizza = new Pizza();

            onepizza.Ingredients[0] = new Tomato();
            onepizza.Ingredients[1] = new Meat();
            onepizza.Ingredients[2] = new Cake();

            onepizza.Ingredients[0].Name = "meat";
            onepizza.Ingredients[1].Name = "cake";
            onepizza.Ingredients[2].Name = "tomaot";

            onepizza.Ingredients[0].Mass = 4;
            onepizza.Ingredients[1].Mass = 5;
            onepizza.Ingredients[2].Mass = 4;

            onepizza.Ingredients[0].Price = 145;
            onepizza.Ingredients[1].Price = 15;
            onepizza.Ingredients[2].Price = 17;

            Console.WriteLine("Pissa contains:\n Meat \n Cake \n Tomato\n");
            Console.WriteLine("Ingredients of pizza weig: \n Meat - 5 kg \n Cake - 3 kg \n Tomato - 10 kg\n");
            Console.WriteLine("Price ingridients of pizza : \n Meat - 30 grn \n Cake - 20 grn \n Tomato - 40 grn\n");
            Console.WriteLine();
            Console.WriteLine("Cost of such pizza = " + onepizza.GetCost() + " grn");
            Console.ReadLine();
        }
    }
}

