using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PashaMarket.Domain.Entities.ProductOrder;
using PashaMarket.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
using PashaMarket.Data.Context;


namespace PashaMarket.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        #region constructor

        private readonly PashaContext _context;

        public OrderRepository(PashaContext context)
        {
            _context = context;
        }


        #endregion


        #region order

        public void CreateNewOrderForUser(Order order)
        {
            _context.Add(order);
        }

       

        public Order GetUserOpenOrder(int userId)
        {
            return _context.Orders
                .Include(s=>s.OrderDetails)
                .SingleOrDefault(s => s.UserId == userId && !s.IsPay);
        }

        #endregion


        #region order detail

        public void AddOrderDetail(OrderDetail detail)
        {
            _context.Add(detail);
        }

        public void UpdateOrderDetail(OrderDetail detail)
        {
          _context.Update(detail);
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
