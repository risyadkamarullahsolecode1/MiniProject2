using Microsoft.AspNetCore.Mvc;
using MiniProject2.Interfaces;
using MiniProject2.Models;

namespace MiniProject2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServices _customerservices;

        public CustomerController(ICustomerServices customerservices)
        {
            _customerservices = customerservices;
        }

        //Add Customer
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerservices.AddCustomer(customer);
            return Ok(customer);
        }

        //Get All Customer
        [HttpGet]
        public List<Customer> GetAllCustomer()
        {
            return _customerservices.GetAllCustomer();
        }

        //Get CustomerById
        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id)
        {
            var customer = _customerservices.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        //Update
        [HttpPut]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerservices.UpdateCustomer(customer);
            return Ok(customer);
        }

        //Delete
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            _customerservices.DeleteCustomer(id);
            return Ok($"Data Customer dengan id {id} Telah di hapus");
        }
    }
}
