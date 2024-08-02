using MiniProject2.Interfaces;
using MiniProject2.Models;

namespace MiniProject2.Services
{
    public class CustomerServices:ICustomerServices
    {
        private List<Customer> _customers = new List<Customer>();

        //Add Customer
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        //Get All
        public List<Customer> GetAllCustomer()
        {
            return _customers;
        }

        //Get customerById
        public Customer GetCustomerById(int id)
        {
            return _customers.FirstOrDefault(c => c.CustomerId == id);
        }

        //Update
        public void UpdateCustomer(Customer customer)
        {
            var daftarCustomer = GetCustomerById(customer.CustomerId);
            if (daftarCustomer != null)
            {
                return;
            }
            daftarCustomer.CustomerId = customer.CustomerId;
            daftarCustomer.Name = customer.Name;
            daftarCustomer.Email = customer.Email;
            daftarCustomer.PhoneNumber = customer.PhoneNumber;
            daftarCustomer.Email = customer.Email;
            daftarCustomer.Address = customer.Address;
        }

        //Delete
        public void DeleteCustomer(int id)
        {
            var customer= GetCustomerById(id);
            if (customer != null)
            {
                _customers.Remove(customer);
            }
        }
    }
}
