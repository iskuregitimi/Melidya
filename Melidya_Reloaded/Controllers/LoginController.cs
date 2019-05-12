using Melidya_Reloaded.BLL;
using Melidya_Reloaded.DAL;
using Melidya_Reloaded.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya_Reloaded.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult KullaniciGirisi()
        {
            Customer customer = CustomerBLL.checkcustomer(Request.Params["Username"], Request.Params["Password"]);
            if (customer != null)
            {
                Session["Customer"] = customer;
                return RedirectToAction("GellAllOrdersFromID", "Order");

            }

            return View("Index");
        }

        public ActionResult Cikis()
        {
            Session["Customer"] = null;
            return View("Index");
        }
    }
}