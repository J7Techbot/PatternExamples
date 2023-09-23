using Facade.Models;

namespace Facade.SubSystems
{
    internal class ShoppingCart
    {
        public double GetTotalCount()
        {
            return new Random().Next(1, 10000);
        }

        public void Add(Product product)
        {
            //add product into cart
        }

        public void Remove(Product product)
        {
            //remove product from cart
        }
    }
}
