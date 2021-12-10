using Microsoft.AspNetCore.Mvc;

namespace PashaMarket.web.Areas.Admin.ViewComponents
{
    public class AdminRightSideViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("AdminRightSide");
        }
    }
}
