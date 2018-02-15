using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Rum : Drink
    {
        public Rum()
        {
            AlcoholContent = 40.0;
        }
    }
}