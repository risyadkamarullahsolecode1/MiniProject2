using Microsoft.AspNetCore.Mvc;
using MiniProject2.Interfaces;
using MiniProject2.Services;

namespace MiniProject2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServices _orderServices;

        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        [HttpPost("PlaceOrder")]
        public IActionResult PlaceOrder(int customerId, [FromBody] List<int> menuId, string note)
        {
            var orderId = _orderServices.PlaceOrder(customerId, menuId, note);
            return Ok(orderId);
        }

        [HttpGet("DisplayOrderDetails/{id}")]
        public IActionResult DisplayOrderDetails(int id)
        {
            var order = _orderServices.DisplayOrderDetails(id);
            if (order == null)
            {
                return BadRequest();
            }
            return Ok(order);
        }

        [HttpGet("GetOrderStatus/{id}/orderStatus")]
        public IActionResult GetOrderStatus(int id) 
        {
            var orderStatus = _orderServices.GetOrderStatus(id);
            return Ok(orderStatus);
        }

        [HttpPut("UpdateOrderStatus/{id}/orderStatus")]
        public IActionResult UpdateOrderStatus(int id, [FromBody] string orderStatus)
        {
            _orderServices.UpdateOrderStatus(id, orderStatus);
            return Ok("Data order telah di update");
        }

        [HttpDelete("CancelOrder/{id}")]
        public IActionResult CancelOrder(int id)
        {
            _orderServices.CancelOrder(id);
            return Ok("Data order telah dihapus");
        }
    }
}
