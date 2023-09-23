using Facade.Interface;
using Facade.Models;
using Facade.SubSystems;

namespace Facade.Facades
{
    internal class ShoppingFacade : IShoppingFacade
    {
        InventoryManagement _inventoryManagement;
        Payment _payment;
        ShoppingCart _shoppingCart;

        public ShoppingFacade()
        {
            _inventoryManagement = new InventoryManagement();
            _payment = new Payment();
            _shoppingCart = new ShoppingCart();
        }

        public void AddToCart(Guid productId)
        {
            if (_inventoryManagement.IsProductAvailable(productId))
            {
                Product product = _inventoryManagement.Get(productId);

                _shoppingCart.Add(product);
            }
        }

        public void Pay()
        {
            if (_payment.VerifyConnection())
            {
                double totalCount = _shoppingCart.GetTotalCount();

                bool paymentConfirmation = _payment.Pay(totalCount);

                if (paymentConfirmation)
                {
                    _payment.CreateInvoice(totalCount);
                }
            }
        }
    }
}
