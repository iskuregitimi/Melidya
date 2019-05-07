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

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (Session["CustomerID"] == null)
            {
                Session.Add("CustomerID", model.CustomerID);
            }
            Session["CustomerID"] = model.CustomerID;

            string CustomerID = model.CustomerID;

            return RedirectToAction("Index");
        }
    }
}