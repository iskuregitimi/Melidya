using Melidya.BLL;
using Melidya.ENTITY;
using Melidya.WebUI.Models;
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

		CustomerBLL customerbll = new CustomerBLL();

        public ActionResult Index()
        {
            return View();
        }


		
		public ActionResult Profil()
		{

			Customer customer = Session["Login"] as Customer;
			Customer customers = customerbll.GetCustomerId(customer.CustomerID);
		
			return View(customers);
		}

        public ActionResult EditProfil(string id)
        {
            Customer customer = customerbll.GetCustomerId(id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult EditProfil(Customer cust)
        {
            Customer customer = customerbll.GetCustomerId(cust.CustomerID);
            customer.CustomerID = cust.CustomerID;
            customer.ContactName = cust.ContactName;
            customer.CompanyName = cust.CompanyName;
            customer.ContactTitle = cust.ContactTitle;
            customer.Country = cust.Country;
            customer.City = cust.City;
            customer.Fax = cust.Fax;
            //customer.Orders = cust.Orders;
            customer.Password = cust.Password;
            customer.Phone = cust.Phone;
            customer.PostalCode = cust.PostalCode;
            customer.Region = cust.Region;
            customerbll.UpdateCustomer(customer);

            return RedirectToAction("Profil");
        }



	
	}
}