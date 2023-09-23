using Facade.Interface;

namespace Facade
{
    internal class Main
    {
        IShoppingFacade _shoppingFacade;

        public Main(IShoppingFacade shoppingFacade)
        {
            _shoppingFacade = shoppingFacade;
        }

        public void MainMethod()
        {
            ProductSelected(Guid.NewGuid());
            Pay();
        }

        public void ProductSelected(Guid productId)
        {
            _shoppingFacade.AddToCart(productId);
        }

        public void Pay()
        {
            _shoppingFacade.Pay();
        }
    }
}
