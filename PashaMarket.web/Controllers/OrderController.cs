using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using PashaMarket.Application.Services.Interfaces;
using PashaMarket.web.HttpContextAccessories;

namespace PashaMarket.web.Controllers
{
    public class OrderController : SiteBaseController
    {
        #region constructor

        private readonly IOrderServices _orderServices;

        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        #endregion

        #region add product to order
        [HttpGet]
        public IActionResult AddProductToOrder(int productId, int count)
        {
            if (User.Identity.IsAuthenticated)
            {

                var userId = Convert.ToInt32(User.Claims.SingleOrDefault(s => s.Type == ClaimTypes.NameIdentifier).Value);
              //  var userId = User.GetUserId();
                var res = _orderServices.AddProductToUserOrder(userId, productId, count);

                return new JsonResult(new
                {
                    message = "محصول مورد نظر با موفقیت به سبد خرید اضافه شد",
                    status = "AddSuccessfully"
                });
            }
            else
            {
                return new JsonResult(new
                {
                    message = "برای ثبت محصول در سبد خرید باید لاگین کنید ",
                    status = "MustLogin"
                });
            }
        }

        #endregion
    }
}
