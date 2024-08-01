using MiniProject2.Interfaces;
using MiniProject2.Models;

namespace MiniProject2.Services
{
    public class OrderServices:IOrderServices
    {
        private List<Order> _orders = new List<Order>();
        private readonly ICustomerServices _customerServices;
        private readonly IMenuServices _menuServices;

        public OrderServices(ICustomerServices customerServices, IMenuServices menuServices)
        {
            _customerServices = customerServices;
            _menuServices = menuServices;
        }

        public int PlaceOrder()
        {
            return _orders.Count;
        }
        public Order DisplayOrderDetails(int orderId)
        {
            return _orders.FirstOrDefault(o => o.Id == orderId);
        }
        public string GetOrderStatus(int orderId)
        {
            var order = DisplayOrderDetails(orderId);
            if (order == null)
            {
                throw new Exception("Order tidak ada.");
            }
            return order.OrderStatus;
        }

        public void UpdateOrderStatus(int orderId, string orderStatus)
        {
            var order = DisplayOrderDetails(orderId);
            if (order == null)
            {
                throw new Exception("Order tidak ada");
            }
            order.OrderStatus = orderStatus;
        }
        public void CancelOrder(int orderId)
        {
            var order = DisplayOrderDetails(orderId);
            if (order == null)
            {
                throw new Exception("Order tidak ada.");
            }
        }
    }
}
