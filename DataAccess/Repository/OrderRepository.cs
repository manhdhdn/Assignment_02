using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context = new();

        public IEnumerable<Order> GetOrders(DateTime? StartDate, DateTime? EndDate, int? memberId)
        {
            if (_context.Orders == null)
            {
                throw new Exception("Connection failed.");
            }

            var orders = _context.Orders.AsQueryable();

            if (StartDate != null)
            {
                orders = orders.Where(o => o.ShippedDate > StartDate);
            }

            if (memberId != null)
            {
                orders = orders.Where(o => o.MemberId == memberId);
            }

            return orders.ToList();
        }

        public Order GetOrder(int orderId)
        {
            if (_context.Members == null)
            {
                throw new Exception("Connection failed.");
            }

            var order = _context.Orders.Find(orderId);

            if (order == null)
            {
                throw new Exception("Not found.");
            }

            return order;
        }

        public void InsertOrder(Order order)
        {
            if (_context.Orders == null)
            {
                throw new Exception("Connection failed.");
            }

            _context.Orders.Add(order);

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateOrder(Order order)
        {
            if (_context.Orders == null)
            {
                throw new Exception("Connection failed.");
            }

            var updateOrder = _context.Orders.FirstOrDefault(o => o.OrderId == order.OrderId);

            if (updateOrder != null)
            {
                updateOrder.MemberId = order.MemberId;
                updateOrder.OrderDate = order.OrderDate;
                updateOrder.RequiredDate = order.RequiredDate;
                updateOrder.ShippedDate = order.ShippedDate;
                updateOrder.Freight = order.Freight;
            }
            else
            {
                throw new Exception("Nothing up-to-date");
            }

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteOrder(int orderId)
        {
            if (_context.Orders == null)
            {
                throw new Exception("Connection failed.");
            }

            var order = _context.Orders.Find(orderId);

            if (order == null)
            {
                throw new Exception("Not found.");
            }

            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }
}
