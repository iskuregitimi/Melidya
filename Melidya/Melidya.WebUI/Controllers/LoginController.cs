using Melidya.BLL;
using Melidya.DAL;
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
            Customer customer = CustomerBLL.getCustomer(model.username,model.password);
            if (customer != null)
            {
                Session["Login"] = customer;
                return RedirectToAction("getOrders","Order");
            }

            return RedirectToAction("Index");
        }

        public ActionResult profile(LoginModel model)
        {
            Customer  customer = Session["Login"] as Customer;          
            return View(customer);
        }

        public ActionResult update(Customer cust)
        {
            Customer customer = Session["Login"] as Customer;
            customer.CustomerID = cust.CustomerID;
            customer.Password = cust.Password;
            customer.CompanyName = cust.CompanyName;
            customer.ContactName = cust.ContactName;
            customer.ContactTitle = cust.ContactTitle;
            customer.Address = cust.Address;
            customer.City = cust.City;
            customer.Region = cust.Region;
            customer.PostalCode = cust.PostalCode;
            customer.Country = cust.Country;
            customer.Phone = cust.Phone;
            customer.Fax = cust.Fax;
            CustomerBLL.updateCustomer(customer);
            return RedirectToAction("profile");
        }

        public ActionResult logout()
        {
            Session["Login"] = null;
            return RedirectToAction("Index");
        }
    }
}