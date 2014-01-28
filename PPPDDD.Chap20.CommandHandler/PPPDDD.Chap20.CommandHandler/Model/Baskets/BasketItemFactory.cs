using PPPDDD.Chap20.CommandHandler.Shopping.Baskets;

namespace PPPDDD.Chap20.CommandHandler.Model.Baskets
{
    public static class BasketItemFactory
    {
        public static BasketItem create_item_for(ProductSnapshot product_snapshot)
        {
            return new BasketItem(product_snapshot, new NonNegativeQuantity(1));
        }
    }
}