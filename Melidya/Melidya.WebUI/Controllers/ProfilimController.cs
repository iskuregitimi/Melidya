using Melidya_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Controllers
{
    public class ProfilimController : Controller
    {
        // GET: Profilim
        public ActionResult Profilim()
        {
            string User = Session["User"].ToString();
            string Password = Session["Password"].ToString();
            var customer=   _Customer.GetCustomer(User, Password);
            return View(customer);
        }
    }
}