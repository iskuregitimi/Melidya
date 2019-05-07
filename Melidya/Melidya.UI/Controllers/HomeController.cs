using Melidya.BusinessLayer;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.UI.Controllers
{
    public class HomeController : Controller
    {
        CustomerManager customerManager = new CustomerManager();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Customers customer)
        {
           Customers Login =  customerManager.GetCustomer(customer.CustomerID);

            return View();
        }
    }
}