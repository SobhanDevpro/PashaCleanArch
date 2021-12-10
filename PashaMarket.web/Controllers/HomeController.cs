using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PashaMarket.web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PashaMarket.Application.Services.Interfaces;
using PashaMarket.Domain.Entities.Site;

namespace PashaMarket.web.Controllers
{
    public class HomeController : SiteBaseController
    {
        #region constructor

        private readonly ISiteService _siteService;

        public HomeController(ISiteService siteService)
        {
            _siteService = siteService;
        }

        #endregion

        public IActionResult Index()
        {
            ViewBag.banners = _siteService.GetSiteBannersByPlacement(new List<BannerPlacement>
            {
                BannerPlacement.Home_1,
                BannerPlacement.Home_2,
                BannerPlacement.Home_3,
                BannerPlacement.Home_4,
                BannerPlacement.Home_5,
                BannerPlacement.Home_6,
                BannerPlacement.Home_7,
                BannerPlacement.Home_8,
                BannerPlacement.Home_9,
                BannerPlacement.Home_10,
            });
            return View();
        }

       
    }
}
