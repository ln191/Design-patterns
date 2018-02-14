using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public abstract class Pizza
    {
        public String Description { get; set; }

        public abstract String GetDescription();

        public abstract double GetPizzaPrice();
    }
}