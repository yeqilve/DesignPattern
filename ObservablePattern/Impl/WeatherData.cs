using System;
using System.Collections.Generic;
using System.Text;

namespace ObservablePattern.Impl
{
    public class WeatherData : ISubject
    {
        private List<IObserver> list;

        public int a;
        public int b;

        public WeatherData()
        {
            list = new List<IObserver>();
        }

        public void notify()
        {
            foreach (var item in list)
            {
                item.update(a, b);
            }
        }

        public void registerObserver(IObserver o)
        {
            list.Add(o);    
        }

        public void removeObserver(IObserver o)
        {
            list.Remove(o);
        }

        public void Set(int z, int x)
        {
            this.a = z;
            this.b = x;
            notify();
        }
    }
}
