using Iterator.Factory;
using Iterator.Interfaces;
using Iterator.Models;
using System.Collections;

namespace Iterator.Collections
{
    /// <summary>
    /// Custom collection for store metadata
    /// </summary>
    internal class MetadataCollection : IteratorAggregate
    {
        List<Metadata> _collection = new List<Metadata>();

        IIterator _iterator;

        bool _direction = false;

        public MetadataCollection(IIteratorFactory factory)
        {
            _iterator = factory.Create(this, false);
        }

        public void ReverseDirection()
        {
            _iterator.ReverseDirection();
        }

        public List<Metadata> GetItems()
        {
            return _collection;
        }

        public Metadata GetItem(int index)
        {
            return _collection[index];
        }

        public void AddItem(Metadata item)
        {
            this._collection.Add(item);
        }

        public void SetIterator(IIteratorFactory factory)
        {
            _iterator = factory.Create(this, _direction);
        }

        public override IEnumerator GetEnumerator()
        {
            return _iterator;
        }
    }
}
