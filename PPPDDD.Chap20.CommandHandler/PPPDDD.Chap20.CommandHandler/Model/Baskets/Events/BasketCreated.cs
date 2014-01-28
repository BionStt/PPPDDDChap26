using System;
using PPPDDD.Chap20.CommandHandler.Common;
using PPPDDD.Chap20.CommandHandler.Infrastructure;

namespace PPPDDD.Chap20.CommandHandler.Shopping.Baskets.Events
{
    public class BasketCreated : IDomainEvent
    {        
        public BasketCreated(Guid id, Money amountToPay)
        {
            Id = id;
            AmountToPay = amountToPay;
        }

        public Guid Id { get; set; }
        public Money AmountToPay { get; set; }
    }
}
