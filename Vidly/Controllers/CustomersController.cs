using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customers/Index
        public ActionResult Index()
        {
            //List<Customer> customers = new List<Customer>
            //{
            //    new Customer {Id = 1, Name = "Zinou" },
            //    new Customer {Id = 2, Name = "Mimou" }
            //};
            var customers = GetAllCustomers();
            return View(customers);
        }

        // GET: Customers/Details/id
        public ActionResult Details(int id)
        {
            //var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            var customer = GetAllCustomers().SingleOrDefault(c => c.Id == id);
            return View(customer);
        }

        public ActionResult New()
        {
            var MembershipTypes = _context.MembershipTypes.ToList();
            return View(MembershipTypes);
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

        public IEnumerable<Customer> GetAllCustomers()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return customers;
        }
    }
}