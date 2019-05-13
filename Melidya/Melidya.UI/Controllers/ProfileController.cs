using Melidya.BusinessLayer;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.UI.Controllers
{
    public class ProfileController : Controller
    {

        CustomerManager customerManager = new CustomerManager();

        public ActionResult UserProfile()
        {
            if (Session["Login"] == null)
            {
                return RedirectToAction("LoginHata");
            }

            Customers customer = Session["Login"] as Customers;

            return View(customer);
        }

        public ActionResult EditProfile(string id)
        {
            if (Session["Login"] == null)
            {
                return RedirectToAction("LoginHata");
            }

            Customers customer = customerManager.GetCustomer(id);

            return View(customer);
        }

        [HttpPost]
        public ActionResult EditProfile(Customers editCustomer)
        {
            customerManager.Update(editCustomer);
            return RedirectToAction("UserProfile");
        }

    }
}