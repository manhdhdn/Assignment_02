using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class OrderDetailDetailRepository : IOrderDetailRepository
    {
        private readonly DataContext _context = new();

        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            if (_context.OrderDetails == null)
            {
                throw new Exception("Connection failed.");
            }

            return _context.OrderDetails.OrderBy(od => od.OrderId).ToList();
        }

        public OrderDetail GetOrderDetail(int orderId, int productId)
        {
            if (_context.Members == null)
            {
                throw new Exception("Connection failed.");
            }

            var orderDetail = _context.OrderDetails.FirstOrDefault(od => od.OrderId == orderId && od.ProductId == productId);

            if (orderDetail == null)
            {
                throw new Exception("Not found.");
            }

            return orderDetail;
        }

        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            if (_context.OrderDetails == null)
            {
                throw new Exception("Connection failed.");
            }

            _context.OrderDetails.Add(orderDetail);

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            if (_context.OrderDetails == null)
            {
                throw new Exception("Connection failed.");
            }

            var updateOrderDetail = _context.OrderDetails.FirstOrDefault(od => od.OrderId == orderDetail.OrderId && od.ProductId == orderDetail.ProductId);

            if (updateOrderDetail != null)
            {
                updateOrderDetail.Quantity = orderDetail.Quantity;
                updateOrderDetail.Discount = orderDetail.Discount;
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

        public void DeleteOrderDetail(int orderId, int productId)
        {
            if (_context.OrderDetails == null)
            {
                throw new Exception("Connection failed.");
            }

            var orderDetail = _context.OrderDetails.FirstOrDefault(od => od.OrderId == orderId && od.ProductId == productId);

            if (orderDetail == null)
            {
                throw new Exception("Not found.");
            }

            _context.OrderDetails.Remove(orderDetail);
            _context.SaveChanges();
        }
    }
}
