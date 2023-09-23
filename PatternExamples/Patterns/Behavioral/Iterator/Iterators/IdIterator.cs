using Iterator.Collections;
using Iterator.Models;

namespace Iterator.Iterators
{
    internal class IdIterator : Iterator
    {
        private MetadataCollection _collection;

        private int _position = -1;

        private bool _reverse = false;

        public IdIterator(MetadataCollection collection, bool reverse = false)
        {
            this._collection = collection;
            this._reverse = reverse;
        }
        public override object Current()
        {
            return this._collection.GetItems()[_position];
        }

        public override bool MoveNext()
        {
            var collection = this._collection.GetItems();

            int updatedPosition = 0;
           
            if (_position == -1)
            {
                int firstId = _reverse ? collection.Max(item => item.Id) : collection.Min(item => item.Id);

                updatedPosition = collection.FindIndex(item => item.Id == firstId);
            }
            else
            {
                int currentId = collection[_position].Id;

                Metadata? closestObject = null;

                if (_reverse)
                    closestObject = collection
                       .Where(obj => obj.Id < currentId)
                       .OrderByDescending(obj => obj.Id)
                       .FirstOrDefault();
                else
                    closestObject = collection
                        .Where(obj => obj.Id > currentId)
                        .OrderBy(obj => obj.Id)
                        .FirstOrDefault();

                updatedPosition = collection.IndexOf(closestObject);

            }

            this._position = updatedPosition;

            return updatedPosition >= 0;            
        }

        public override void Reset()
        {
            this._position = -1;
        }
    }
}
