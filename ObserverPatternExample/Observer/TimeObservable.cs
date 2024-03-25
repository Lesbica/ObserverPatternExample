using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample.Observer
{
    public class TimeObservable : ITimeObservable
    {
        private List<ITimeObserver> observers = new List<ITimeObserver>();
        private TimeOfDay currentTime = TimeOfDay.Morning;

        public void RegisterObserver(ITimeObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(ITimeObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(currentTime);
            }

            MessageBox.Show("Time now: " + currentTime.ToString());
        }

        public void SetTime(TimeOfDay time)
        {
            currentTime = time;
            NotifyObservers();
        }
    }
}
