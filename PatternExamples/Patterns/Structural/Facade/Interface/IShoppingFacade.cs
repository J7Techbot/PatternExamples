namespace Facade.Interface
{
    internal interface IShoppingFacade
    {
        public void AddToCart(Guid productId);
        public void Pay();
    }
}
