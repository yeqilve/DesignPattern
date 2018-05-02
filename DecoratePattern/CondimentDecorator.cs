using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class CondimentDecorator:Baverage
    {
        public abstract string getDescription();
    }
}
