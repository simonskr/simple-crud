using Microsoft.EntityFrameworkCore;
using SimpleCrud.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCrud.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
