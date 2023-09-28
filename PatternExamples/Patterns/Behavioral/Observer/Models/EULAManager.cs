using Observer.Enums;
using Observer.Interfaces;

namespace Observer.Models
{
    internal class EULAManager : IObservable
    {
        private List<IObserver> _observers;
        public string ActualEULA { get; private set; }

        public EULAManager()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(Event e)
        {
            foreach (var observer in _observers)
            {
                observer.Update(e);
            }
        }

        public void UpdateEULA()
        {
            // some logic ...

            ActualEULA = "Updated information";

            Notify(new Event("Update",EventType.EULA_UPDATED,this));           
        }        
    }
}
