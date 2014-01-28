using System;
using PPPDDD.Chap20.CommandHandler.Infrastructure;

namespace PPPDDD.Chap20.CommandHandler.Application.Contract.BusinessUseCase
{
    public class RemoveProductFromBasketCommand : IBusinessRequest
    {
        public RemoveProductFromBasketCommand(Guid get_basket_id, int product_id)
        {
            this.get_basket_id = get_basket_id;
            this.product_id = product_id;
        }

        public Guid get_basket_id { get; set; }
        public int product_id { get; set; }
    }
}