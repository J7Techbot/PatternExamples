using Iterator.Collections;
using Iterator.Interfaces;

namespace Iterator.Factory
{
    internal interface IIteratorFactory
    {
        public IIterator Create(MetadataCollection collection, bool reverse);
    }
}
