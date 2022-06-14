using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        //We need a dbcontect to access the database
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }


        //Represent the new form
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };
            return View("CustomerForm",viewModel);
        }

        //Save the new record by passing viewModel as an object or I can pass the Customer as an object since the MVC framework
        //smart enough to know this is customer data since each object in the viewModel initialized with Customer
        //[HttpPost]
        //public ActionResult Save(CustomerFormViewModel viewModel)
        //{
        //    var cus = new Customer()
        //    {
        //        Name = viewModel.Customer.Name,
        //        BirthDate = viewModel.Customer.BirthDate,
        //        IsSubscribedToNewsLetter = viewModel.Customer.IsSubscribedToNewsLetter,
        //        MembershipTypeId = viewModel.Customer.MembershipTypeId
        //    };
        //    _context.Customers.Add(cus);

        //    _context.SaveChanges();
        //    return RedirectToAction("Index", "Customers");
        //}
        //since DbContext is a disposable object, so we need properly dispose this object
        //there is another way is by using dependency injection framework so we can delegate instaintiating and disposing object
        //protected override void Dispose(bool disposing)
        //{
        //    _context.Dispose();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    //we need to intialize the MembershipType from the database
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("CustomerForm",viewModel);
            }

            var cus = _context.Customers.SingleOrDefault(c => c.Id == customer.Id);

            if (cus == null)
            {
                _context.Customers.Add(customer);
            }
            
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                    customerInDb.Name = customer.Name;
                    customerInDb.BirthDate = customer.BirthDate;
                    customerInDb.MembershipTypeId = customer.MembershipTypeId;
                    customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }

        // GET: Customers
        public ViewResult Index()
        {
            return View();
        }


        // GET: Customers/Details/5/
        public ActionResult Details(int id)
        {
            //var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        //Save a Customer Edit Action
        public ActionResult Edit(int id)
        {
           var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm", viewModel);
        }

        // Delete: Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id)
        {

            var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);
            if (customer == null)
                return HttpNotFound();
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
            //var customers = _context.Customers.SingleOrDefault(c => c.Id == Id);
            //_context.Customers.Remove(_context.Customers.Remove.Id);

            //_context.SaveChanges();
            //return RedirectToAction("Index", "Customers");
            //else
            //{
            //    var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
            //    customerInDb.Name = customer.Name;
            //    customerInDb.BirthDate = customer.BirthDate;
            //    customerInDb.MembershipTypeId = customer.MembershipTypeId;
            //    customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            //}
            //_context.SaveChanges();
            //return RedirectToAction("Index", "Customers");

            //var customers = _context.Customers.Remove(_context.Customers.SingleOrDefault(c => c.Id == id));
            //var customers = _context.Customers.SingleOrDefault(c => c.Id == Id);
            //_context.Customers.Remove(customers);
            // //_context.Customers.Remove(_context.Customers.Single(c => c.Id == Id));

            // _context.SaveChanges();
            //return RedirectToAction("Index", "Customers");
        }


        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //{
        //    new Customer { Id = 1, Name = "John Smith" },
        //    new Customer { Id = 2, Name = "Mary Williams" },
        //    new Customer { Id = 3, Name = "Wassem Sabri" },
        //    new Customer { Id = 4, Name = "Sally Sabri"},
        //    new Customer { Id = 5, Name = "Suzanne Sabri"}
        //};
        //}
    }
}

