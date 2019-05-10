using Melidya.BLL;
using Melidya.DAL;
using Melidya.WebUI.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Admin.Controllers
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
            Employee employee = EmployeeBLL.GetEmployee(model.username, model.password);
            if (employee != null)
            {
                Session["Login"] = employee;
            }

            return View();
        }

        public ActionResult profile(LoginModel model)
        {
            Employee employee = Session["Login"] as Employee;
            return View(employee);
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