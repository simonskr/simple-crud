using SimpleCrud.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCrud.BLL.Abstract
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> Customers { get; }

        void SaveCustomer(Customer customer);
        Customer DeleteCustomerWithId(int customerId);
    }
}
