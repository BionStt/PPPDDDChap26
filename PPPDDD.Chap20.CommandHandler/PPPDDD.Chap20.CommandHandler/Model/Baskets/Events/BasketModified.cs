using System;
using PPPDDD.Chap20.CommandHandler.Infrastructure;

namespace PPPDDD.Chap20.CommandHandler.Sales.Model.Baskets.Events
{
    public class BasketModified : IDomainEvent
    {
        public BasketModified(Guid basket_id)
        {
            this.basket_id = basket_id;
        }

        public Guid basket_id { get; set; }
    }
}