using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Water : Baverage
    {
        public Water()
        {
            Setdescription("water");
        }

        public override double cost()
        {
            return 1;
        }
        
    }
}
