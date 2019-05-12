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
        public ActionResult Index()
        {
            return View();
        }

        CustomerBLL customerBLL = new CustomerBLL();
        public ActionResult Login(LoginModel loginModel)
        {
            Customers customer = customerBLL.GetCustomer(loginModel.Username, loginModel.Password);

            if (customer != null)
            {
                Session.Add("User", customer);

                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Login");
        }
    }
}