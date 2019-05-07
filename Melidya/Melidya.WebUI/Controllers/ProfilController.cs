using Melidya.BLL;
using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Controllers
{
    public class ProfilController : Controller
    {
        // GET: Profil
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Profill()
        {
            Customers customer = Session["Login"] as Customers;



            return View(customer);

        }
        public ActionResult Update()
        {
            //Customers customer = CustommerBLL.getCustomer(Id);

            //return View(customer);
            Customers customer = Session["Login"] as Customers;
            CustommerBLL.updateCustomers(customer);
            return View("Profill");
        }
        public ActionResult Logout()
        {
            Session["Login"] = null;

            return RedirectToAction("Index", "Home");
        }
    }
}