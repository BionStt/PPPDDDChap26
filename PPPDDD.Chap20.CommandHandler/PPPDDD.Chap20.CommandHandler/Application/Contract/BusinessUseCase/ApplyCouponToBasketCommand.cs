using System;
using PPPDDD.Chap20.CommandHandler.Infrastructure;

namespace PPPDDD.Chap20.CommandHandler.Application.Contract.BusinessUseCase
{
    public class ApplyCouponToBasketCommand : IBusinessRequest
    {                
        public ApplyCouponToBasketCommand(Guid basket_id, string voucher_id)
        {
            this.basket_id = basket_id;
            // check to see if voucher id is null
            
            this.voucher_id = voucher_id;
        }

        public string voucher_id { get; set; }
        public Guid basket_id { get; set; }
    }      
}