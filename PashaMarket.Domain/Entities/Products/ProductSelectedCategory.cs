using PashaMarket.Domain.Entities.Base;

namespace PashaMarket.Domain.Entities.Products
{
    public class ProductSelectedCategory : BaseEntity
    {
        #region properties

        public int ProductId { get; set; }

        public int ProductCategoryId { get; set; }

        #endregion

        #region relations

        public Product Product { get; set; }

        public ProductCategory ProductCategory { get; set; }

        #endregion
    }
}
