using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA17_18
{
     public interface IObserver //интерфейс для наблюдаемого объекта
    {
        void Update(Object ob);
    }

    public interface IObservable //интерфейс для наблюдателя
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();

    }
}
