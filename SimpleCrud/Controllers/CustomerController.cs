﻿using Microsoft.AspNetCore.Mvc;
using SimpleCrud.BLL.Abstract;
using SimpleCrud.BLL.Models;
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

        public ViewResult Add()
        {
            return View("Edit", new Customer());
        }

        [HttpGet]
        public ViewResult Edit(int customerId) => 
            View(customerService.GetCustomerWithId(customerId));

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customerService.SaveCustomer(customer);
                TempData["message"] = $"{customer.Name} {customer.Surname} has been saved";
                return RedirectToAction("Index");
            }
            else
                return View(customer);
        }

        [HttpPost]
        public IActionResult Delete(int customerId)
        {
            var customer = customerService.DeleteCustomerWithId(customerId);
            if (customer != null)
                TempData["message"] = $"{customer.Name} {customer.Surname} has been deleted";

            return RedirectToAction("Index");
        }
    }
}
