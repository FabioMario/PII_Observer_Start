using System;
using System.Collections.Generic;
using System.Text;
namespace Observer
{
    public interface IObservable
    {        
        void Subscribe(IObserver Observer);
        void Unsubscribe (IObserver Observer);

    }
}