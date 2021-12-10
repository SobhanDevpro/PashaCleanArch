using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PashaMarket.Application.Services.Interfaces;

namespace PashaMarket.web.ViewComponents
{
    public class SiteHeaderViewComponent:ViewComponent
    {
        #region constructor

        private readonly IProductService _productService;

        public SiteHeaderViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        #endregion
        public IViewComponentResult Invoke()
        {
            ViewBag.ProductCategories = _productService.GetAllActiveProductCategories();
            return View("SiteHeader");
        }
    }
}
