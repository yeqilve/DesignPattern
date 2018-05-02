using System;
using System.Collections.Generic;
using System.Text;
using DesighPattern.Impl;

namespace DesighPattern
{
    public class NormalDuck:Duck
    {
        public NormalDuck()
        {
            quack = new Quack();
            fly = new FlyNoWing();

        }
    }
}
