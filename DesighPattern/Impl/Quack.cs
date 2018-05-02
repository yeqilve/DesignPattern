using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPattern.Impl
{
    public class Quack : IQuack
    {
        void IQuack.Quack()
        {
            Console.WriteLine(" quack ");
        }
    }
}
