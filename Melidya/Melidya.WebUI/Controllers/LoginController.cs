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
    public class LoginController : Controller
    {
        // GET: Login
        CustomerBLL customerBLL = new CustomerBLL();
        public ActionResult LoginIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginIndex(LoginModel model)
        {
            Customers customer = customerBLL.GetCustomer(model.CustomerID, model.Password);

            Session["Login"] = customer;

            return RedirectToAction("OrderIndex", "Order");
        }
    }
}