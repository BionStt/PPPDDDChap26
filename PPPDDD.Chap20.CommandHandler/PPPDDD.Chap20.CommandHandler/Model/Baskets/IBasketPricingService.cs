using System;
using System.Collections.Generic;
using PPPDDD.Chap20.CommandHandler.Model.Promotions;

namespace PPPDDD.Chap20.CommandHandler.Model.Baskets
{
    public interface IBasketPricingService
    {
        BasketPricingBreakdown calculate_total_price_for(IEnumerable<BasketItem> items, IEnumerable<Coupon> coupons );
    }
}