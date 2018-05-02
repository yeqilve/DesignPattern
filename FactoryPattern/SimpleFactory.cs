using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class SimpleFactory
    {
        public IFactory GetFactory(string type)
        {
            switch (type)
            {
                case "1":
                    return new Test();
                case "2":
                    return new Simple();
                default:
                    return new Test();
            }
        }
    }

    public interface IFactory
    {
    }

    public class Test : IFactory
    {
    }
    public class Simple : IFactory
    {
    }
}
