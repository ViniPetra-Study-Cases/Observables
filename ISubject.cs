using System;
using System.Collections.Generic;
using System.Text;

namespace Observables
{
    interface ISubject
    {
        public void AddObervable(IObervables obervable);
        public void RemoveObervable(IObervables obervable);
        public void PushObservables();
    }
}
