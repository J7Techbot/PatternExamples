using System.Collections;

namespace Iterator.Collections
{
    /// <summary>
    /// Define that object can be enumerated.
    /// </summary>
    internal abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
