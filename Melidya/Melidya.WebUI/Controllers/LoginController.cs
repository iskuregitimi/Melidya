using Melidya.BLL;
using Melidya.DAL;
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
        public ActionResult Login(LoginModel model)
        {

            Customers customer = LoginBLL.LoginCustomers(model.UserName);
            if (customer.Password == model.Password)
            {
                Session["Login"] = customer;

                return RedirectToAction("Order", "Order");
            }


            return RedirectToAction("Index");
        }


    }
}