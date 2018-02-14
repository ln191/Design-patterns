using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //create new pizza order,  which is a large pizza type
            Pizza pizzaOrder = new LargePizza();

            //adds Kebab to the large pizza
            pizzaOrder = new Kebab(pizzaOrder);

            //adds Pepperoni to the large pizza with kebab
            pizzaOrder = new Pepperoni(pizzaOrder);

            Console.WriteLine(pizzaOrder.GetDescription());

            //$"{}" is from C# 6,  do the same as ("Name ={name}", name),  C2 adds the currency Kr. or $ depending on you location
            Console.WriteLine($"{pizzaOrder.GetPizzaPrice():C2}");
            Console.Read();
        }
    }
}