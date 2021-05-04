using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FacadePattern
{
    public interface IShoppingFacade
    {
        string BuyItem();
    }

    public class ShoppingFacade : IShoppingFacade
    {
        public string BuyItem()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.CheckItemAvailability();
            shoppingCart.CheckPriceVariation();
            shoppingCart.LockItem();
            shoppingCart.MoveItemToQueue();
            shoppingCart.MarkPurchased();
            //This will do all the needfull and provides only simplified result
            return "Successfully purchased";
        }
    }
}