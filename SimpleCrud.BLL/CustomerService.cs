using SimpleCrud.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using SimpleCrud.BLL.Models;
using System.Linq;

namespace SimpleCrud.BLL
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public void SaveCustomer(Customer customer)
        {
            customerRepository.SaveCustomer(customer);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customerRepository.Customers;
        }

        public Customer GetCustomerWithId(int customerId)
        {
            return customerRepository.Customers.FirstOrDefault(c => c.CustomerID == customerId);
        }
    }
}
