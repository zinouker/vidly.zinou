using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers/Index
        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Zinou" },
                new Customer {Id = 2, Name = "Mimou" }
            };
            return View(customers);
        }

        // GET: Customers/Details/id
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            return View(customer);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Zinou" },
                new Customer {Id = 2, Name = "Mimou" }
            };

            return customers;
        }
    }
}