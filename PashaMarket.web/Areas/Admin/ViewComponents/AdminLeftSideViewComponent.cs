using Microsoft.AspNetCore.Mvc;

namespace PashaMarket.web.Areas.Admin.ViewComponents
{
    public class AdminLeftSideViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("AdminLeftSide");
        }
    }
}
