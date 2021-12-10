using PashaMarket.Domain.Entities.ProductOrder;

namespace PashaMarket.Application.Services.Interfaces
{
  public interface IOrderServices
    {
        #region Order

        Order GetUserOpenOrder(int userId);

        bool AddProductToUserOrder(int userId, int productId , int count);

        #endregion
    }
}
