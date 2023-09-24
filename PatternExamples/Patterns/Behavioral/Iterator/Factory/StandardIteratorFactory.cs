using Iterator.Collections;
using Iterator.Interfaces;
using Iterator.Iterators;

namespace Iterator.Factory
{
    internal class StandardIteratorFactory : IIteratorFactory
    {
        public IIterator Create(MetadataCollection collection, bool reverse)
        {
            return new StandardIterator(collection, reverse);
        }
    }
}
