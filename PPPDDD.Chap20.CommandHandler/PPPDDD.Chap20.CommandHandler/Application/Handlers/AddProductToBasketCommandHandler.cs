
using PPPDDD.Chap20.CommandHandler.Model.Baskets;

namespace PPPDDD.Chap20.CommandHandler.Application.Handlers
{
    public class AddProductToBasketCommandHandler : ICommandHandler<AddProductToBasketCommand>
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IBasketPricingService _basketPricingService;

        public AddProductToBasketCommandHandler(IBasketRepository basketRepository,
                                                ReadModel product_repository,
                                                IBasketPricingService basket_pricing_service)
        {
            _basketRepository = basketRepository;
            _basketPricingService = basket_pricing_service;
        }

        public void action(AddProductToBasketCommand business_request)
        {
            var basket = _basketRepository.find_by(business_request.basket_id);            

            // var product = _product_repository.find_by(business_request.productid);
            var product = new ProductSnapshot();

            basket.add(product, _basketPricingService);                                    
        }
    }
}