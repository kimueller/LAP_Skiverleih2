using LAP_Skiverleih.Data;
using LAP_Skiverleih.Models;
using LAP_Skiverleih.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LAP_Skiverleih.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext dbc;

        public CustomerService(ApplicationDbContext dbc) 
        {
            this.dbc = dbc;
        }

        public void CreateCustomer(Customer customer)
        {
            dbc.Add(customer);
            dbc.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            dbc.Remove(customer);
            dbc.SaveChanges();
        }

        public List<Customer> GetCustomers()
        {
            var customers = dbc.Customers
                            .Include(c => c.Loans)
                            .ToList();
            return customers;
        }

        public void UpdateCustomer(Customer customer)
        {
            dbc.Update(customer);
            dbc.SaveChanges();
        }
    }
}
