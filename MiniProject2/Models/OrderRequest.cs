namespace MiniProject2.Models
{
    public class OrderRequest
    {
        /// <summary>
        /// New Class for place order 
        /// </summary>

        /// <remarks>
        /// Get the data [FromBody] 
        ///
        /// CustomerId, MenuId, Note
        ///  
        ///  NOTE: 
        ///  
        /// Sample request:
        ///
        ///     POST api/Order/
        ///     {
        ///        "customerId": 0,
        ///            "menuId": 
        ///                 [0],
        ///        "note": "string""userId": null,
        ///     }
        /// </remarks>
        /// <param name="request"></param>
        /// <returns> This endpoint returns a list of Accounts.</returns>
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
