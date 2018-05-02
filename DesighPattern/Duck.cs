using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPattern
{
    public class Duck
    {
        internal IQuack quack;
        internal IFly fly;

        public void DuckFly()
        {
            fly.fly();
        }

        public void Quack()
        {
            quack.Quack();
        }

        /// <summary>
        /// use combination to replace inherit
        /// </summary>
        /// <param name="quack"></param>
        public void SetQuack(IQuack quack)
        {
            this.quack = quack;
        }
        public void SetFly(IFly fly)
        {
            this.fly = fly;
        }
    }
}
