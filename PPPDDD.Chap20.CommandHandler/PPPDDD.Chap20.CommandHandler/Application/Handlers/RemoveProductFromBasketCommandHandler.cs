﻿using PPPDDD.Chap20.CommandHandler.Infrastructure;
using PPPDDD.Chap20.CommandHandler.Application.Contract.BusinessUseCase;
using PPPDDD.Chap20.CommandHandler.Model.Baskets;

namespace PPPDDD.Chap20.CommandHandler.Handlers
{
    public class RemoveProductFromBasketCommandHandler : ICommandHandler<RemoveProductFromBasketCommand>
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IBasketPricingService _basketPricingService;

        public RemoveProductFromBasketCommandHandler(IBasketRepository basket_repository,
                                                     IBasketPricingService basket_pricing_service)
        {
            _basketRepository = basket_repository;
            _basketPricingService = basket_pricing_service;
        }

        public void action(RemoveProductFromBasketCommand business_request)
        {
            var basket = _basketRepository.find_by(business_request.get_basket_id);

            basket.remove_product_with_id_of(business_request.product_id, _basketPricingService);
        }
    }
}