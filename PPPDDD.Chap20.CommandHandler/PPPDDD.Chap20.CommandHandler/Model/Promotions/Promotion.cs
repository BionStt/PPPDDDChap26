using System;
using System.Collections.Generic;
using PPPDDD.Chap20.CommandHandler.Common;
using PPPDDD.Chap20.CommandHandler.Model.Baskets;

namespace PPPDDD.Chap20.CommandHandler.Model.Promotions
{
    public class Promotion
    {
        private readonly string _voucher_code;
        private readonly Money _discount;
        private readonly Money _threshold;       

        private Promotion()
        {
        }

        public Promotion(string voucher_code, Money discount, Money threshold)
        {
            // TODO: Check for null values and invalid data
            _voucher_code = voucher_code;
            _discount = discount;
            _threshold = threshold;
        }

        public string id { get { return _voucher_code; } }        

        public bool is_still_active()
        {
            return true;
        }

        public string voucher_code
        {
            get { return _voucher_code; }
        }

        public CouponIssues reason_why_cannot_be_applied_to(IEnumerable<BasketItem> items)
        {
            throw new NotImplementedException();
        }

        public Money calculate_discount_for(IEnumerable<BasketItem> items)
        {
            throw new NotImplementedException();
        }

        public bool is_applicable_for(IEnumerable<BasketItem> items)
        {
            return true;
        }

        public Coupon create_coupon_for(Guid basket_id)
        {
            return new Coupon();
        }
    }
}