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
			List<Customer> customers = customerbll.GetCustomerId(customer.CustomerID);
			
			
			return View(customers);
		}



	
	}
}