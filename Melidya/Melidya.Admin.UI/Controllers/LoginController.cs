using Melidya.Admin.UI.Models;
using Melidya.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.Admin.UI.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Index()
        {

            return View();
        }
        public ActionResult LoginHata()
        {

            return View();
        }
        public ActionResult Login(LoginModel loginModel)
        {
            CustomerManager cmgr = new CustomerManager();
            var customer = cmgr.GetCustomer(loginModel.UserName);
            if (customer.Password == loginModel.Password)
            {
                Session.Add("User", customer);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("LoginHata");
            }
            
        }

    }
}