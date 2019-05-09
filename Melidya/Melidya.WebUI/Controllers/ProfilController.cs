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
            Customers login = Session["Login"] as Customers;

            Customers customer = CustommerBLL.getcustomer(login.CustomerID);



            return View(customer);

        }

        public ActionResult Update()
        {
            Customers login = Session["Login"] as Customers;

            Customers customer = CustommerBLL.getcustomer(login.CustomerID);



            return View(customer);
        }

        [HttpPost]
        public ActionResult Update(Customers customer)
        {
            Customers cust = CustommerBLL.getcustomer(customer.CustomerID);

            cust.ContactName = customer.ContactName;
            cust.CompanyName = customer.CompanyName;
            cust.Address = customer.Address;
            cust.City = customer.City;
            cust.ContactTitle = customer.ContactTitle;
            cust.Country = customer.Country;
            cust.Fax = customer.Fax;
            cust.Password = customer.Password;
            cust.PostalCode = customer.PostalCode;
            cust.Region = customer.Region;
            cust.Phone = customer.Phone;
            cust.CustomerID = customer.CustomerID;

            CustommerBLL.updateCustomers(cust);
            return RedirectToAction("Profill");
        }
        public ActionResult Logout()
        {
            Session["Login"] = null;

            return RedirectToAction("Index", "Home");
        }
    }
}