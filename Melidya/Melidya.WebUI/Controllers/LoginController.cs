using Melidya.WebUI.Models;
using Melidya_BLL;
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
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel mdl)
        {

            if (Session["User"] == null && Session["Password"] == null)
            {
                Session["User"] = mdl.User;
                Session.Add("Password", mdl.Password);
            }

            string User = Session["User"].ToString();
            string Password = Session["Password"].ToString();

            try
            {
                var customer = _Customer.GetCustomer(User, Password);
                Session["Contact"] = customer.ContactName;
            }
            catch
            {
                return View("Hata");

            }

            return RedirectToAction("Profilim","Profilim");

        }

    }
}