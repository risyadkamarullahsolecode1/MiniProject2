using MiniProject2.Models;

namespace MiniProject2.Interfaces
{
    public interface ICustomerServices
    {
        void AddCustomer(Customer customer);
        List<Customer> GetAllCustomer();
        Customer GetCustomerById(int id);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
