using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders(DateTime? StartDate, DateTime? EndDate);

        Order GetOrder(int orderId);

        void InsertOrder(Order order);

        void UpdateOrder(Order order);

        void DeleteOrder(int orderId);
    }
}
