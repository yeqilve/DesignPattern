using System;
using System.Collections.Generic;
using System.Text;

namespace ObservablePattern
{
    public interface ISubject
    {
        void registerObserver(IObserver o);
        void removeObserver(IObserver o);
        void notify();
    }
}
