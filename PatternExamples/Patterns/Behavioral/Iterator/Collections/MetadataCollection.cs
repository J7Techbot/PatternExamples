using Iterator.Iterators;
using Iterator.Models;
using System.Collections;

namespace Iterator.Collections
{
    internal class MetadataCollection : IteratorAggregate
    {
        List<Metadata> _collection = new List<Metadata>();

        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
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

        public override IEnumerator GetEnumerator()
        {
            //return new StandardIterator(this, _direction);

            return new IdIterator(this, _direction);
        }
    }
}
