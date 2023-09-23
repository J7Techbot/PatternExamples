using Facade.Models;

namespace Facade.SubSystems
{
    internal class InventoryManagement
    {
        public bool IsProductAvailable(Guid productId)
        {
            //Check if product is available
            return true;
        }
        public Product Get(Guid productId)
        {
            //for simplicity returns random product
            return new Product() { Id = productId, Price = new Random().Next(1, 1000) };
        }
    }
}
