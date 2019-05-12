using Melidya.BLL;
using Melidya.Entity;
using Melidya.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        CustomerBLL customerBLL = new CustomerBLL();
        public ActionResult CustomerList()
        {
            List<Customers> customer = customerBLL.GetCustomers();

            return View(customer);
        }

    }
}