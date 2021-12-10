using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PashaMarket.web.Areas.User.Controllers
{
    public class HomeController : UserBaseController
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
