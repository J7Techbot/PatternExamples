using Iterator.Collections;

namespace Iterator.Iterators
{
    internal class StandardIterator : Iterator
    {
        private MetadataCollection _collection;

        private int _position = -1;

        public StandardIterator(MetadataCollection collection, bool reverse = false)
        {
            this._collection = collection;
            this.Reverse = reverse;

            if (reverse)
            {
                this._position = collection.GetItems().Count;
            }
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
            int updatedPosition = this._position + (this.Reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._collection.GetItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            if (Reverse)
            {
                this._position = _collection.GetItems().Count;
            }
            else
                this._position = -1;
        }
    }
}
