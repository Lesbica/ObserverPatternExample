using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObserverPatternExample.Observer
{
    public interface ITimeObserver
    {
        void Update(TimeOfDay time);
    }   
}
