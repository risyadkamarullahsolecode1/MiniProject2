namespace MiniProject2.Models
{
    public class OrderRequest
    {
        public int CustomerId { get; set; }
        public List<int> MenuId { get; set; }
        public string Note { get; set; }

        public OrderRequest(int customerId, List<int> menuId, string note)
        {
            CustomerId = customerId;
            MenuId = menuId;
            Note = note;
        }
    }
}
