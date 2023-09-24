using Iterator.Collections;
using Iterator.Interfaces;
using Iterator.Iterators;

namespace Iterator.Factory
{
    internal class IdIteratorFactory : IIteratorFactory
    {
        public IIterator Create(MetadataCollection collection, bool reverse)
        {
            return new IdIterator(collection, reverse);
        }
    }
}
