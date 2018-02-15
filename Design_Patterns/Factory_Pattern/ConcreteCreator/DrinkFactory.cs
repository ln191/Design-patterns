using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class DrinkFactory : IDrinkFactory
    {
        public Drink GetAlcoholContent(string drink)
        {
            if (drink == "beer")
            {
                return new Beer();
            }
            else
            if (drink == "rum")
            {
                return new Rum();
            }
            else
                throw new ArgumentException("The Drink is not in the system");
        }
    }
}