using Iterator.Enums;
using Iterator.Iterators;
using Iterator.Models;
using System.Collections;

namespace Iterator.Collections
{
    internal class MetadataCollection : IteratorAggregate
    {
        List<Metadata> _collection = new List<Metadata>();

        IEnumerator _iterator;

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

        public void SetIterator(IteratorTypes iteratorType)
        {
            switch(iteratorType)
            {
                case IteratorTypes.STANDARD_ITERATOR:
                    _iterator = new StandardIterator(this, _direction);
                    break;
                case IteratorTypes.ID_ITERATOR:
                    _iterator = new IdIterator(this, _direction);
                    break;
            }
        }

        public override IEnumerator GetEnumerator()
        {
            if (_iterator != null)
                return _iterator;
            else 
                return new StandardIterator(this, _direction);
        }
    }
}
