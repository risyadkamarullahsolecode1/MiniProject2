using MiniProject2.Models;

namespace MiniProject2.Interfaces
{
    public interface IOrderServices
    {
        int PlaceOrder(int customerId, List<int> menuId, string note);
        Order DisplayOrderDetails(int orderId);
        string GetOrderStatus(int orderId);
        void UpdateOrderStatus(int orderId, string orderStatus);
        void CancelOrder(int orderId);
    }
}
