using System.Collections.Generic;
using PashaMarket.Domain.Entities.Products;
using PashaMarket.Domain.ViewModels.Admin.Products;
using PashaMarket.Domain.ViewModels.Products;

namespace PashaMarket.Application.Services.Interfaces
{
    public interface IProductService
    {
        #region categories

        List<ProductCategory> GetAllActiveProductCategories();
        void AddProductSelectedCategories(int productId, List<int> categoryIds);

        #endregion

        #region products

        CreateProductResult CreateProduct(CreateProductViewModel product);

        FilterProductViewModel FilterProduct(FilterProductViewModel filter);

        ProductDetailViewModel GetProductDetail(int productId);

        #endregion
    }
}