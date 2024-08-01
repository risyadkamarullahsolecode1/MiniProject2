using Microsoft.AspNetCore.Mvc;
using MiniProject2.Interfaces;

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
        public IActionResult PlaceOrder()
        {
            return Ok("Tampilkan Place Order");
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
