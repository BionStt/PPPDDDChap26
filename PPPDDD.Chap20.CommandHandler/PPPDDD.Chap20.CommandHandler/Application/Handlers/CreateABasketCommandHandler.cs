using PPPDDD.Chap20.CommandHandler.Infrastructure;
using PPPDDD.Chap20.CommandHandler.Application.Contract.BusinessUseCase;
using PPPDDD.Chap20.CommandHandler.Model.Baskets;

namespace PPPDDD.Chap20.CommandHandler.Handlers
{
    public class CreateABasketCommandHandler : ICommandHandler<CreateABasketCommand>
    {
        private readonly IBasketRepository _basket_repository;

        public CreateABasketCommandHandler(IBasketRepository basket_repository)
        {
            _basket_repository = basket_repository;
        }

        public void action(CreateABasketCommand business_request)
        {
            var basket = new Basket(business_request.basket_id);

            _basket_repository.add(basket);
        }
    }
}