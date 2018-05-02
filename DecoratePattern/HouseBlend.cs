using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class HouseBlend : Baverage
    {
        public HouseBlend()
        {
            Setdescription("HouseBlend");
        }

        public override double cost()
        {
            return 22;
        }
        
    }
}
