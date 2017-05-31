using SimpleCrud.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using SimpleCrud.BLL.Models;

namespace SimpleCrud.BLL
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customerRepository.Customers;
        }
    }
}
