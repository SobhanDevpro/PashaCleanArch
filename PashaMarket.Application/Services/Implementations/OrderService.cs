using System.Linq;
using PashaMarket.Application.Services.Interfaces;
using PashaMarket.Domain.Entities.ProductOrder;
using PashaMarket.Domain.IRepositories;

namespace PashaMarket.Application.Services.Implementations
{
    public class OrderService : IOrderServices
    {
        #region constructor

        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        #endregion

        #region order

        public Order GetUserOpenOrder(int userId)
        {
            var openOrder = _orderRepository.GetUserOpenOrder(userId);

            if (openOrder == null)
            {
                var newOrder = new Order { UserId = userId };
                _orderRepository.CreateNewOrderForUser(newOrder);
                _orderRepository.SaveChanges();

                return newOrder;
            }
            return openOrder;
        }

        public bool AddProductToUserOrder(int userId, int productId, int count)
        {
            var userOpenOrder = GetUserOpenOrder(userId);

            if (userOpenOrder.OrderDetails !=null && userOpenOrder.OrderDetails
                .Any(s => s.ProductId == productId))
            {
                var similarDetail = userOpenOrder
                    .OrderDetails.SingleOrDefault(s => s.ProductId == productId);
                similarDetail.Count += count;
                _orderRepository.UpdateOrderDetail(similarDetail);

            }
            else
            {
                var orderDetail = new OrderDetail
                {
                    ProductId = productId,
                    OrderId = userOpenOrder.Id,
                    Count = count
                };
                _orderRepository.AddOrderDetail(orderDetail);

            }
            _orderRepository.SaveChanges();
            return true;
        }

        #endregion
    }
}