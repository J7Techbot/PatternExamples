using System.Collections;

namespace Iterator.Collections
{
    internal abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
