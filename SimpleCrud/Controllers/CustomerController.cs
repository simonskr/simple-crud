using Microsoft.AspNetCore.Mvc;
using SimpleCrud.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrud.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        public ViewResult Index()
        {
            return View(customerService.GetAllCustomers());
        }
    }
}
