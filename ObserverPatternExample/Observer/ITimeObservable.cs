using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample.Observer
{
    public interface ITimeObservable
    {
        void RegisterObserver(ITimeObserver observer);
        void RemoveObserver(ITimeObserver observer);
        void NotifyObservers();
    }
}
