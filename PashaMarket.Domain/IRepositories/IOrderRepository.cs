using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PashaMarket.Domain.Entities.ProductOrder;
using PashaMarket.Domain.IRepositories;


namespace PashaMarket.Domain.IRepositories
{
    public interface IOrderRepository : ISaveChangesRepository
    {
        #region order

        Order GetUserOpenOrder(int userId);
        void CreateNewOrderForUser(Order order);

        #endregion

        #region order detail

        void AddOrderDetail(OrderDetail detail);
        void UpdateOrderDetail(OrderDetail detail);

        #endregion
    }
}
