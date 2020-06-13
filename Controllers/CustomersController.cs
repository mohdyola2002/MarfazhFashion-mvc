using MarfazahFashion.Models;
using MarfazahFashion.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarfazahFashion.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer() { Id = 1, Name = "Shaima'u Sadis Yola" },
            new Customer() { Id = 2, Name = "Fatima Umar Khalil" },
            new Customer() { Id = 3, Name = "Maimuna Abdulkadir Yola" },
            new Customer() { Id = 4, Name = "Fatima Abdulkadir Yola" },
            new Customer() { Id = 5, Name = "Muhammad Abdulkadir Yola" }
        };
        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new IndexCustomerViewModel() { Customers = customers };
            return View(viewModel);
        }

        public ActionResult Detail(int id)
        {
            Customer viewModel = new Customer();
            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {
                    viewModel = customer;
                }
            }
            return View(viewModel);
        }
    }
}