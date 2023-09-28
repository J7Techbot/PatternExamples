using Observer.Enums;
using Observer.Interfaces;

namespace Observer.Models
{
    internal class Event
    {
        public string Name { get;private set; }
        public EventType Type { get; private set; }
        public IObservable Observable { get; private set; }
        public Event(string name, EventType type, IObservable observable)
        {
            Name = name;
            Type = type;
            Observable = observable;
        }
    }
}
