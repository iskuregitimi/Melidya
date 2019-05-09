using Melidya.BLL;
using Melidya.Entities;
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

        public ActionResult LoginOl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginOl(CustomerModel model)
        {
            Customer customer = CustomerManager.GetCustomer(model.UserID);

            if (customer != null)
            {
                if (customer.Password == model.Password)
                {
                    Session["Login"] = customer;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("LoginHata");
                }
            }
            else
            {
                return RedirectToAction("LoginHata");
            }

        }

        public ActionResult LoginHata()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session["Login"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}