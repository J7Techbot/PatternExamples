using Iterator.Interfaces;
using System.Collections;

namespace Iterator.Iterators
{
    internal abstract class Iterator : IIterator
    {
        protected bool Reverse;
        object IEnumerator.Current => Current();
        public abstract object Current();
        public abstract bool MoveNext();
        public abstract void Reset();
        public void ReverseDirection()
        {                        
            Reverse = !Reverse;
            Reset();
        }

    }
}
