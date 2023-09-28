using Observer.Models;

namespace Observer.Interfaces
{
    internal interface IObservable
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(Event e);
    }
}
