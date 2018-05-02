using System;
using System.Collections.Generic;
using System.Text;

namespace ObservablePattern.Impl
{
    public class CurrentDisplay : IObserver, IDisplayElement
    {
        private int temp;
        private int degree;

        public CurrentDisplay(ISubject subject)
        {
            subject.registerObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"current condition : {temp}, degree:{degree}");
        }

        public void update(int a, int b)
        {
            this.temp = a;
            this.degree = b;

            Display();
        }
    }
}
