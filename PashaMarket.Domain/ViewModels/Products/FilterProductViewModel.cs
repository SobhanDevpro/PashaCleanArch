using System.Collections.Generic;
using PashaMarket.Domain.Entities.Products;
using PashaMarket.Domain.ViewModels.Paging;

namespace PashaMarket.Domain.ViewModels.Products
{
    public class FilterProductViewModel : BasePaging
    {
        public FilterProductViewModel()
        {
            OrderBy = FilterProductOrder.CreateDate_Asc;
            State = FilterProductState.All;
        }

        public string Title { get; set; }

        public FilterProductOrder OrderBy { get; set; }

        public FilterProductState State { get; set; }

        public List<Product> Products { get; set; }

        public FilterProductViewModel SetPaging(BasePaging pager)
        {
            Page = pager.Page;
            Take = pager.Take;
            Skip = pager.Skip;
            StartPage = pager.StartPage;
            EndPage = pager.EndPage;
            HowManyPagesShowAfterBefore = pager.HowManyPagesShowAfterBefore;
            AllEntitiesCount = pager.AllEntitiesCount;
            AllPagesCount = pager.AllPagesCount;

            return this;
        }
    }

    public enum FilterProductOrder
    {
        CreateDate_Asc,
        CreateDate_Dec,
        Price_Asc,
        Price_Des,
        ExistsProduct
    }

    public enum FilterProductState
    {
        All,
        ActiveProducts,
        DeletedProducts,
        ExistsProducts,
    }
}
