using Melidy.BLL;
using Melidya.Entity;
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
        CustomerBLL customerbll = new CustomerBLL();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginIndex(LoginModel model)
        {
            Customers customer = customerbll.GetCustomer(model.customerID, model.password);
            if (customer != null)
            {
                Session["Login"] = customer;
                return RedirectToAction("Order", "Order");
            }

            return RedirectToAction("Index");
        }
        CustomerBLL cstbll = new CustomerBLL();
        public ActionResult profile(string id)
        {
            Customers customer = customerbll.GetCustomersID(id);

            return View(customer);

        }

        public ActionResult update(Customers customer)
        {
            Customers cust = Session["Login"] as Customers;
            cust.Address = customer.Address;
            cust.City = customer.City;
            cust.CompanyName = customer.CompanyName;
            cust.ContactName = customer.ContactName;
            cust.ContactTitle = customer.ContactTitle;
            cust.Country = customer.Country;
            cust.CustomerDemographics = customer.CustomerDemographics;
            cust.Fax = customer.Fax;
            cust.Region = customer.Region;
            cust.PostalCode = customer.PostalCode;
            cust.Phone = customer.Phone;
            cust.Password = customer.Password;
            customerbll.Update(cust);
            return View("profile");

        }
        public ActionResult Logout()
        {
            Session["Login"] = null;
            return View("Index");
        }
        ProductBLL productbll = new ProductBLL();
        public ActionResult ProductList()
        {
            List<Products> product = productbll.GetProduct();
            
            return View(product);
        }


    }
    
}