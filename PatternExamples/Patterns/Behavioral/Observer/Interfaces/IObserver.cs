using Observer.Models;

namespace Observer.Interfaces
{
    internal interface IObserver
    {
        void Update(Event e);
    }
}
