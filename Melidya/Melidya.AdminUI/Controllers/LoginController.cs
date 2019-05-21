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
		public ActionResult Login(LoginModel model )
		{
			CustomerManager cstmr = new CustomerManager();

			var customer = cstmr.GetCustomer(model.username);
			if (customer != null && customer.Password == model.password)
			{
				Session.Add("User", customer);
				return RedirectToAction("Index");
			}

			else{
				return RedirectToAction("LoginHata");
			}
		
		}
		public ActionResult LoginHata()
		{
			return View();
		}



	}


}