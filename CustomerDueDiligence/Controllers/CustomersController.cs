using CustomerDueDiligence.Models;
using CustomerDueDiligence.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerDueDiligence.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();


            return View(customer);
        }

        public ActionResult CustomerForm()
        {
            var AccountTypes = _context.AccountTypes.ToList();

            var viewModel = new CustomerFormViewModel()
            {
                Customer = new Customer(),
                AccountTypes = AccountTypes
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel()
                {
                    Customer = customer,
                    AccountTypes = _context.AccountTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }

            if (customer.Id == 0)
            {
                customer.Created = DateTime.Now;
                _context.Customers.Add(customer);
            }

            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

                customerInDb.Firstname = customer.Firstname;
                customerInDb.Lastname = customer.Lastname;
                customerInDb.AccountTypeId = customer.AccountTypeId;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");

        }


        public ActionResult Edit(int Id)
        {
            var customer = _context.Customers.SingleOrDefault(p => p.Id == Id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                AccountTypes = _context.AccountTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }
    }
}