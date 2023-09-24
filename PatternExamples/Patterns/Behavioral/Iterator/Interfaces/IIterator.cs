using System.Collections;

namespace Iterator.Interfaces
{
    /// <summary>
    /// This layer bridges communication between collection and iterator
    /// </summary>
    internal interface IIterator : IEnumerator
    {
        public void ReverseDirection();
    }
}
