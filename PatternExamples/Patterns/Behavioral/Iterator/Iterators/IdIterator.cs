using Iterator.Collections;
using Iterator.Models;

namespace Iterator.Iterators
{
    internal class IdIterator : Iterator
    {
        private MetadataCollection _collection;

        private int _position = -1;

        public IdIterator(MetadataCollection collection, bool reverse = false)
        {
            this._collection = collection;
            this.Reverse = reverse;
        }
        public override object Current()
        {
            if (this._collection.GetItems().Count > 0)
            {
                if (_position == -1)
                    return this._collection.GetItems()[0];
                else
                    return this._collection.GetItems()[_position];
            }
            else
                return null;
        }

        public override bool MoveNext()
        {
            var collection = this._collection.GetItems();

            int updatedPosition = 0;
           
            if (_position == -1)
            {
                ///select first item 
                int firstId = Reverse ? collection.Max(item => item.Id) : collection.Min(item => item.Id);

                ///and find its position in collection
                updatedPosition = collection.FindIndex(item => item.Id == firstId);
            }
            else
            {
                int currentId = collection[_position].Id;

                Metadata? closestObject = null;

                ///If the Reverse is true, it will search for all IDs lower than the currentId,
                ///sort them in descending order, and select the first one.
                if (Reverse)
                    closestObject = collection
                       .Where(obj => obj.Id < currentId)
                       .OrderByDescending(obj => obj.Id)
                       .FirstOrDefault();

                ///search for all IDs higher than the currentId, sort and select the first one.
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
