using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var factory = new DrinkFactory() as IDrinkFactory;
            var rum = factory.GetAlcoholContent("rum");
            var beer = factory.GetAlcoholContent("beer");

            Console.WriteLine($"The Beers alcohol content is {beer.AlcoholContent}%" +
                $" and rum has {rum.AlcoholContent}%");
        }
    }
}