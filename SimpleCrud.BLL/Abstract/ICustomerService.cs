using SimpleCrud.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCrud.BLL.Abstract
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        void SaveCustomer(Customer customer);
        Customer GetCustomerWithId(int customerId);
    }
}
