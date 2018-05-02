using DesighPattern.Impl;
using System;

namespace DesighPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new NormalDuck();
            duck.DuckFly();
            duck.SetFly(new FlyWithWing());
            duck.DuckFly();
            Console.Read();
        }
    }
}
