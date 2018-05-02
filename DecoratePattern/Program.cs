using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Baverage baverage = new HouseBlend();
            Console.WriteLine(baverage.GetDescription() + " " + baverage.cost());

            Baverage baverage2 = new Mocha(baverage);
            Console.WriteLine($"{baverage2.GetDescription()},cost: {baverage2.cost()}");
            Console.Read();
        }
    }
}
