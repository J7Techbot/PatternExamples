using Iterator.Collections;
using Iterator.Factory;
using Iterator.Interfaces;
using Iterator.Iterators;
using Iterator.Models;

namespace Iterator
{
    internal class Main
    {
        MetadataCollection _metadataCollection;
        public Main()
        {
            _metadataCollection = new MetadataCollection(new StandardIteratorFactory());
            _metadataCollection.AddItem(new Metadata(2, "Author"));
            _metadataCollection.AddItem(new Metadata(1, "DateIssued"));
            _metadataCollection.AddItem(new Metadata(3, "Language"));
        }

        public void MainMethod()
        {
            //_metadataCollection = new MetadataCollection(new StandardIteratorFactory());
            //_metadataCollection.AddItem(new Metadata(2, "Author"));
            //_metadataCollection.AddItem(new Metadata(1, "DateIssued"));
            //_metadataCollection.AddItem(new Metadata(3, "Language"));
            //StandardIterator si = new StandardIterator(_metadataCollection);
            //si.Reset();
            //var s = si.Current();

            Console.WriteLine("Straight standard traversal:");

            foreach (var element in _metadataCollection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse standard traversal:");

            _metadataCollection.ReverseDirection();

            foreach (var element in _metadataCollection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nStraight ID traversal:");

            _metadataCollection.SetIterator(new IdIteratorFactory());

            foreach (var element in _metadataCollection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse ID traversal:");

            _metadataCollection.ReverseDirection();

            foreach (var element in _metadataCollection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
