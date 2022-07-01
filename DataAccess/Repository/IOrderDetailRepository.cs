using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrderDetails();

        OrderDetail GetOrderDetail(int orderDetailId);

        void InsertOrderDetail(OrderDetail orderDetail);

        void UpdateOrderDetail(OrderDetail orderDetail);

        void DeleteOrderDetail(int orderDetailId);
    }
}
