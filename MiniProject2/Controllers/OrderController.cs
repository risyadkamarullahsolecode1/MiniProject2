using Microsoft.AspNetCore.Mvc;
using MiniProject2.Interfaces;
using MiniProject2.Models;
using MiniProject2.Services;

namespace MiniProject2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServices _orderServices;

        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        [HttpPost]
        public IActionResult PlaceOrder([FromBody] OrderRequest orderRequest)
        {
            var order = _orderServices.PlaceOrder(orderRequest.CustomerId, orderRequest.MenuId, orderRequest.Note);
            return Ok(order);
        }

        [HttpGet("{id}")]
        public IActionResult DisplayOrderDetails(int id)
        {
            var order = _orderServices.DisplayOrderDetails(id);
            if (order == null)
            {
                return BadRequest();
            }
            return Ok(order);
        }

        [HttpGet("{id}/orderStatus")]
        public IActionResult GetOrderStatus(int id) 
        {
            var orderStatus = _orderServices.GetOrderStatus(id);
            return Ok(orderStatus);
        }

        [HttpPut("{id}/orderStatus")]
        public IActionResult UpdateOrderStatus(int id, [FromBody] string orderStatus)
        {
            _orderServices.UpdateOrderStatus(id, orderStatus);
            return Ok("Data order telah di update");
        }

        [HttpDelete("{id}")]
        public IActionResult CancelOrder(int id)
        {
            _orderServices.CancelOrder(id);
            return Ok("Data order telah di cancel");
        }
    }
}
