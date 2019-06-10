using Melidya.AdminUI.Models;
using Melidya.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.AdminUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult LoginHata()
        {
            return View();
        }


        public ActionResult Login(LoginModel loginmodel)
        {
            CustomerManager cmgr = new CustomerManager();
            var customer = cmgr.GetCustomer(loginmodel.UserName);
            if(    customer!=null && customer.Password==loginmodel.Password  )
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