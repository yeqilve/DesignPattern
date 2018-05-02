using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Baverage
    {
        internal string baverageName = "Unknow ";
        public string GetDescription()
        {
            return baverageName;
        }

        public void Setdescription(string name)
        {
            this.baverageName = name;
        }

        public abstract double cost();
    }
}
