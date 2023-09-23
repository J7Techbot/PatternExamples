using Iterator.Collections;

using Iterator.Models;

namespace Iterator
{
    internal class Main
    {
        MetadataCollection _metadataCollection;
        public Main()
        {
            _metadataCollection = new MetadataCollection();
            _metadataCollection.AddItem(new Metadata(2, "Author"));
            _metadataCollection.AddItem(new Metadata(1, "DateIssued"));
            _metadataCollection.AddItem(new Metadata(3, "Language"));          
        }

        public void MainMethod()
        {
            Console.WriteLine("Straight traversal:");

            foreach (var element in _metadataCollection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");

            _metadataCollection.ReverseDirection();

            _metadataCollection.SetIterator(Enums.IteratorTypes.ID_ITERATOR);

            foreach (var element in _metadataCollection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
