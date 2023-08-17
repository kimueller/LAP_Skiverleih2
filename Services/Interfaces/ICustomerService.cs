using LAP_Skiverleih.Models;

namespace LAP_Skiverleih.Services.Interfaces
{
    public interface ICustomerService
    {
        public List<Customer> GetCustomers();

        public void CreateCustomer(Customer customer);

        public void UpdateCustomer(Customer customer);

        public void DeleteCustomer(Customer customer);

    }
}
