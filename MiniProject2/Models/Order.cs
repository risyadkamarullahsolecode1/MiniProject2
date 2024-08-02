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

        public void CalculateTotalOrder()
        {
            TotalPrice = OrderedItem.Sum(item => item.Price);
        }
    }
}
