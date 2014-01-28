using System;
using PPPDDD.Chap20.CommandHandler.Infrastructure;

namespace PPPDDD.Chap20.CommandHandler.Application.Contract.BusinessUseCase
{
    public class CreateABasketCommand : IBusinessRequest
    {
        public Guid basket_id { get; set; }

        public CreateABasketCommand(Guid basket_id)
        {
            this.basket_id = basket_id;
        }
    }
}