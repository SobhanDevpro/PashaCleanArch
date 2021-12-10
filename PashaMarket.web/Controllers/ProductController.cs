using Microsoft.AspNetCore.Mvc;
using PashaMarket.Application.Services.Interfaces;

namespace PashaMarket.web.Controllers
{
    public class ProductController : SiteBaseController
    {
        #region constructor

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        #endregion

        [HttpGet("product/{productId}/{productTitle}")]
        public IActionResult ProductDetail(int productId, string productTitle)
        {
            var product = _productService.GetProductDetail(productId);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
