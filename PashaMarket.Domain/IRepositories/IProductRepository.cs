using System.Collections.Generic;
using PashaMarket.Domain.Entities.Products;
using PashaMarket.Domain.ViewModels.Products;

namespace PashaMarket.Domain.IRepositories
{
    public interface IProductRepository : ISaveChangesRepository
    {
        #region categories

        List<ProductCategory> GetAllActiveProductCategories();
        void AddProductSelectedCategories(List<ProductSelectedCategory> categories);

        List<ProductCategory> GetProductSelectedCategories(int productId);
        #endregion

        #region products

        void AddProduct(Product product);
        FilterProductViewModel FilterProducts(FilterProductViewModel filter);

        Product GetProductById(int productId);

        #endregion
    }
}