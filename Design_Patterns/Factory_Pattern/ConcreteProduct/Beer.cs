using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Beer : Drink
    {
        public Beer()
        {
            AlcoholContent = 4.7;
        }
    }
}