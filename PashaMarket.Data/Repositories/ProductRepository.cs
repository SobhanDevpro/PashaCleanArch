using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PashaMarket.Data.Context;
using PashaMarket.Domain.Entities.Products;
using PashaMarket.Domain.IRepositories;
using PashaMarket.Domain.ViewModels.Paging;
using PashaMarket.Domain.ViewModels.Products;

namespace PashaMarket.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        #region constructor

        private readonly PashaContext _context;

        public ProductRepository(PashaContext context)
        {
            _context = context;
        }

        #endregion

        #region categories

        public List<ProductCategory> GetAllActiveProductCategories()
        {
            return _context.ProductCategories
                .Where(s => s.IsActive && !s.IsDelete)
                .ToList();
        }

        public void AddProductSelectedCategories(List<ProductSelectedCategory> categories)
        {
            _context.AddRange(categories);
        }

        public List<ProductCategory> GetProductSelectedCategories(int productId)
        {
            return _context.ProductSelectedCategories
                .Include(s => s.ProductCategory)
                .Select(s => s.ProductCategory)
                .ToList();
        }

        #endregion

        #region products

        public void AddProduct(Product product)
        {
            _context.Add(product);
        }

        public FilterProductViewModel FilterProducts(FilterProductViewModel filter)
        {
            var query = _context.Products.AsQueryable();


            switch (filter.OrderBy)
            {
                case FilterProductOrder.CreateDate_Asc:
                    query = query.OrderBy(s => s.CreateDate);
                    break;
                case FilterProductOrder.CreateDate_Dec:
                    query = query.OrderByDescending(s => s.CreateDate);
                    break;
                case FilterProductOrder.Price_Asc:
                    query = query.OrderBy(s => s.Price);
                    break;
                case FilterProductOrder.Price_Des:
                    query = query.OrderByDescending(s => s.Price);
                    break;
                case FilterProductOrder.ExistsProduct:
                    query = query.OrderByDescending(s => s.Inventory);
                    break;
            }

            switch (filter.State)
            {
                case FilterProductState.All:
                    break;
                case FilterProductState.DeletedProducts:
                    query = query.Where(s => s.IsDelete);
                    break;
                case FilterProductState.ActiveProducts:
                    query = query.Where(s => s.IsActive);
                    break;
                case FilterProductState.ExistsProducts:
                    query = query.Where(s => s.Inventory > 0);
                    break;
            }

            // AutoMapper

            if (!string.IsNullOrEmpty(filter.Title))
            {
                // query = query.Where(s => EF.Functions.Like(s.Title, $"%{filter.Title}%"));
                query = query.Where(s => s.Title.Contains(filter.Title));
            }

            var allEntitiesCount = query.Count();

            var pager = Pager.Build(filter.Page, allEntitiesCount, filter.Take, filter.HowManyPagesShowAfterBefore);

            var products = query.Paging(pager).ToList();

            filter.Products = products;

            return filter.SetPaging(pager);
        }

        public Product GetProductById(int productId)
        {
            return _context.Products
                .SingleOrDefault(s => s.Id == productId);

        }

        #endregion

        #region save changes

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        #endregion
    }
}
