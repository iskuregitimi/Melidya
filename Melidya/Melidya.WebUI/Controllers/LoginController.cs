using Melidya.BLL;
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

        public ActionResult login(LoginModel model)
        {
            if (Session["username"] == null || Session["password"] == null)
            {
                Session.Add("username", model.username);
                Session.Add("password", model.password);
            }

            Session["username"] = model.username;
            Session["password"] = model.password;

            var contactName = CustomerBLL.getContactName(Session["username"], Session["password"]);
            if (contactName != null)
            {
                Session["Login"] = contactName;
                return RedirectToAction("getOrders","Order");
            }

            return RedirectToAction("Index");
        }

        public ActionResult profile(LoginModel model)
        {
            return View();
        }
    }
}