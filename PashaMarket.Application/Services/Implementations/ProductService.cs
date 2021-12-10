using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PashaMarket.Application.Extensions;
using PashaMarket.Application.Services.Interfaces;
using PashaMarket.Application.StaticItems;
using PashaMarket.Application.Utils;
using PashaMarket.Domain.Entities.Products;
using PashaMarket.Domain.IRepositories;
using PashaMarket.Domain.ViewModels.Admin.Products;
using PashaMarket.Domain.ViewModels.Products;

namespace PashaMarket.Application.Services.Implementations
{
    public class ProductService : IProductService
    {

        #region constructor

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        #endregion

        #region categories

        public List<ProductCategory> GetAllActiveProductCategories()
        {
            return _productRepository.GetAllActiveProductCategories();
        }

        public void AddProductSelectedCategories(int productId, List<int> categoryIds)
        {
            if (categoryIds != null && categoryIds.Any())
            {
                var selectedCategories = new List<ProductSelectedCategory>();
                foreach (var categoryId in categoryIds)
                {
                    selectedCategories.Add(new ProductSelectedCategory
                    {
                        ProductId = productId,
                        ProductCategoryId = categoryId
                    });
                }

                _productRepository.AddProductSelectedCategories(selectedCategories);
                _productRepository.SaveChanges();
            }
        }

        #endregion

        #region products

        public CreateProductResult CreateProduct(CreateProductViewModel product)
        {
            // add product

            var newProduct = new Product
            {
                Title = product.Title,
                ShortDescription = product.ShortDescription,
                ImageName = "",
                Description = product.Description,
                Price = product.Price
            };

            // add image
            if (product.ProductImage != null)
            {
                if (!product.ProductImage.IsImage()) return CreateProductResult.InvalidImage;

                var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(product.ProductImage.FileName);
                product.ProductImage.AddImageToServer(
                    imageName,
                    PathTools.ProductImageUploadPath,
                    150, 150,
                    PathTools.ProductThumbImageUploadPath);

                newProduct.ImageName = imageName;
            }

            _productRepository.AddProduct(newProduct);
            _productRepository.SaveChanges();

            // add categories
            AddProductSelectedCategories(newProduct.Id, product.SelectedCategories);

            return CreateProductResult.Success;
        }


        public FilterProductViewModel FilterProduct(FilterProductViewModel filter)
        {
            return _productRepository.FilterProducts(filter);
        }

        public ProductDetailViewModel GetProductDetail(int productId)
        {
            var product = _productRepository.GetProductById(productId);

            if (product == null || product.IsDelete || !product.IsActive)
            {
                return null;
            }

            return new ProductDetailViewModel
            {
                Id = product.Id,
                Description = product.Description,
                ShortDescription = product.ShortDescription,
                Title = product.Title,
                ImageName = product.ImageName,
                Price = product.Price,
                ProductCategories = _productRepository.GetProductSelectedCategories(productId)
            };

        }




        #endregion
    }
}
