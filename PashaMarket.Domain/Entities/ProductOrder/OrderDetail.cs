using PashaMarket.Domain.Entities.Base;

namespace PashaMarket.Domain.Entities.ProductOrder
{
  public  class OrderDetail:BaseEntity
    {
        #region properties

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public int PayablePrice { get; set; }

        #endregion

        #region Relations

        public Order Order { get; set; }

        #endregion
    }
}
