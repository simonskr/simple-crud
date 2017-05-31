using SimpleCrud.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using SimpleCrud.BLL.Models;

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
    }
}
