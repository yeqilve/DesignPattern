using System;
using System.Collections.Generic;
using System.Text;

namespace ObservablePattern
{
    public interface IObserver
    {
        void update(int a, int b);
    }
}
