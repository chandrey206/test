using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public abstract class Dish
    {
        public float mass, price;
        protected float coefficient = (float)2.3;
        public abstract float Getcost();
    }

    public class pizza : Dish
    {


        public Ingredients[] ingredients = new Ingredients[3];

        override public float Getcost()
        {
            return (ingredients[1].Getcost() + ingredients[2].Getcost() + ingredients[3].Getcost()) * coefficient;


        }
    }
    public abstract class Ingredients
    {
        public string name;
        public float mass, price;
        public abstract float Getcost();

    }
    public class Cake : Ingredients
    {
        public override float Getcost()
        {
            return mass * price;
        }
    }
    public class Meat : Ingredients
    {
        public override float Getcost()
        {
            return mass * price;
        }
    }
    public class Tomato : Ingredients
    {
        public override float Getcost()
        {
            return mass * price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            pizza onepizza = new pizza();

            onepizza.ingredients[0] = new Ingredients();
            onepizza.ingredients[1] = new Ingredients();
            onepizza.ingredients[2] = new Ingredients();

            onepizza.ingredients[0].name = "meat";
            onepizza.ingredients[1].name = "cake";
            onepizza.ingredients[2].name = "tomaot";

            onepizza.ingredients[0].mass = 4;
            onepizza.ingredients[1].mass = 5;
            onepizza.ingredients[2].mass = 4;

            onepizza.ingredients[0].price = 145;
            onepizza.ingredients[1].price = 15;
            onepizza.ingredients[2].price = 17;



            Console.WriteLine("Pissa contains:\n Meat \n Cake \n Tomato\n");
            Console.WriteLine("Ingredients of pizza weig: \n Meat - 5 kg \n Cake - 3 kg \n Tomato - 10 kg\n");
            Console.WriteLine("Price ingridients of pizza : \n Meat - 30 grn \n Cake - 20 grn \n Tomato - 40 grn\n");
            Console.WriteLine();
            Console.WriteLine("Cost of such pizza = " + onepizza.Getcost() + " grn");
            Console.ReadLine();
        }
    }
}
