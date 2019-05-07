using Melidya.BLL;
using Melidya.ENTITY;
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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Login(Customers cust)
        {
            CustomerBLL customerbll = new CustomerBLL();
            if (Session["Login"] == null)
            {
                Session["Login"] = customerbll.GetCustomer(cust.CustomerID);
            }
            else
            {
                Session["Login"] = customerbll.GetCustomer(cust.CustomerID);
            }
            return RedirectToAction("Index", "Login");
        }

    }
}