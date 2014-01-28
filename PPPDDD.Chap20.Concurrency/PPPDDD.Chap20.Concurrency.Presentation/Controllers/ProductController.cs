using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPPDDD.Chap20.Concurrency.Presentation.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            var apply_coupon_to_basket_command = new ApplyCouponToBasketCommand(get_basket_id(), voucher_code);

            handle_domain_exception(() =>
            {
                _application.action_request_to(apply_coupon_to_basket_command);
            });

            return Redirect("Index");

            return View();
        }

    }
}
