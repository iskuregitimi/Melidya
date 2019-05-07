using Melidya.BLL;
using Melidya.DAL;
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
        public ActionResult Login(string UserName, string password)
        {

            Customers customer= LoginBLL.LoginCustomers(UserName);
            if (customer.Password==password)
            {
                Session["Login"] = customer;

                return RedirectToAction("Order", "Order");
            }


            return RedirectToAction("Index");
        }

       
    }
}