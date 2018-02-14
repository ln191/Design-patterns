using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Topping : Pizza
    {
        //Holds a ref to pizza which the topping shall be adds to
        protected Pizza _Pizza;

        public Topping(Pizza pizza)
        {
            _Pizza = pizza;
        }

        // =>  in return methods, added in C# 6,  the equivalent of { return _Pizza.GetDescription() }
        public override string GetDescription() => _Pizza.GetDescription();

        public override double GetPizzaPrice() => _Pizza.GetPizzaPrice();
    }
}