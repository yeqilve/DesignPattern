using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        private Baverage baverage;

        public Mocha(Baverage _baverage)
        {
            this.baverage = _baverage;
        }
        public override double cost()
        {
            return baverage.cost() + 5;
        }

        public override string getDescription()
        {
            return baverage.GetDescription() + "， Mocha";
        }
    }
}
