﻿using PPPDDD.Chap20.CommandHandler.Infrastructure;
using PPPDDD.Chap20.CommandHandler.Application.Contract.BusinessUseCase;
using PPPDDD.Chap20.CommandHandler.Model.Baskets;

namespace PPPDDD.Chap20.CommandHandler.Handlers
{
    public class RemoveCouponFromBasketCommandHandler : ICommandHandler<RemoveCouponFromBasketCommand>
    {
        private readonly IBasketRepository _basket_repository;
        private readonly IBasketPricingService _basketPricingService;

        public RemoveCouponFromBasketCommandHandler(IBasketRepository basket_repository,
                                                   IBasketPricingService basketPricingService)
        {
            _basket_repository = basket_repository;
            _basketPricingService = basketPricingService;
        }

        public void action(RemoveCouponFromBasketCommand business_request)
        {
            var basket = _basket_repository.find_by(business_request.basket_id);

            basket.remove_coupon(business_request.coupon_code, _basketPricingService);

            _basket_repository.save(basket);
        }
    }
}