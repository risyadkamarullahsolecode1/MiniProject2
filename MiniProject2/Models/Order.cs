using System.ComponentModel.DataAnnotations;

namespace MiniProject2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        [RegularExpression("Processed|Delivered|Canceled")]
        public string OrderStatus { get; set; }
        public string Note { get; set; }
        public List<Menu> OrderedItem { get; set; }

        public Order() { }

        public Order(int id, int customerId, DateTime orderDate, int totalPrice, string orderStatus, string note)
        {
            Id = id;
            CustomerId = customerId;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            OrderStatus = orderStatus;
            Note = note;
            OrderedItem = new List<Menu>();
        }

        public void CalculateTotalOrder()
        {
            TotalPrice = OrderedItem.Sum(item => item.Price);
        }
    }
}
