using SimpleCrud.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using SimpleCrud.BLL.Models;
using System.Linq;

namespace SimpleCrud.DAL
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext context;

        public EFCustomerRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Customer> Customers => context.Customers;

        public Customer DeleteCustomerWithId(int customerId)
        {
            var dbCustomer = context.Customers.FirstOrDefault(x => x.CustomerID == customerId);

            if (dbCustomer != null)
            {
                context.Customers.Remove(dbCustomer);
                context.SaveChanges();
            }

            return dbCustomer;
        }

        public void SaveCustomer(Customer customer)
        {
            if (customer.CustomerID == 0)
                context.Customers.Add(customer);
            else
            {
                var dbCustomer = context.Customers.FirstOrDefault(x => x.CustomerID == customer.CustomerID);
                if (dbCustomer != null)
                {
                    dbCustomer.Name = customer.Name;
                    dbCustomer.Surname = customer.Surname;
                    dbCustomer.Address = customer.Address;
                    dbCustomer.PhoneNumber = customer.PhoneNumber;
                }
            }

            context.SaveChanges();
        }
    }
}
