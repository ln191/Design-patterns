using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Pepperoni : Topping
    {
        public Pepperoni(Pizza pizza) : base(pizza)
        {
            Description = "Pepperoni";
        }

        // adds topping description to the pizza existing description
        public override string GetDescription() => $"{_Pizza.GetDescription()}, {Description}";

        // adds the topping price to the existing pizza price
        public override double GetPizzaPrice() => _Pizza.GetPizzaPrice() + 5.00;
    }
}