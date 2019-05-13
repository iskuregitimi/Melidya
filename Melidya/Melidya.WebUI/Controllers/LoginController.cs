using Melidya.BLL;
using Melidya.ENTITY;
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

        CustomerBLL customerbll = new CustomerBLL();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginIndex(LoginModel model)
        {
            Customer customer = customerbll.GetCustomer(model.username, model.password);
            Session["Login"] = customer;
            return RedirectToAction("OrderIndex","Order");
        }

		public ActionResult Logout()
		{
			Session.Abandon();
			return  RedirectToAction("Login","Login");
		}

    }
}