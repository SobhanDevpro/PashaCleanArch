using Microsoft.AspNetCore.Mvc;

namespace PashaMarket.web.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
