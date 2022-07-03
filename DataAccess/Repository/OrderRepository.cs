using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context = new();

        public IEnumerable<Order> GetOrders(DateTime? StartDate, DateTime? EndDate)
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

            _context.Entry(order).State = EntityState.Modified;

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

            var order = _context.Members.Find(orderId);

            if (order == null)
            {
                throw new Exception("Not found.");
            }

            _context.Remove(order);
            _context.SaveChanges();
        }
    }
}
