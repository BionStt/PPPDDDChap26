using System;
using PPPDDD.Chap20.RequestReply.Application.Contracts;
using PPPDDD.Chap20.RequestReply.Application.Infrastructure;

namespace PPPDDD.Chap20.RequestReply.Application.Handlers
{
    public class ApplyACouponToTheBasketHandler : IBusinessUseCaseHandler<ApplyACouponToTheBasket, OutcomeOfCouponBeingAppiled>
    {
        public OutcomeOfCouponBeingAppiled Handle(ApplyACouponToTheBasket useCase)
        {
            return new OutcomeOfCouponBeingAppiled(); // Success and you got a discount of xxxx
        }
    }
}