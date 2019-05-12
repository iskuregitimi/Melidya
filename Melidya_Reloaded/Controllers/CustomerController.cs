using Melidya_Reloaded.BLL;
using Melidya_Reloaded.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya_Reloaded.Controllers
{
    public class CustomerController : Controller
    {
        Customer musteri = null;
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerDetail()
        {
            musteri = Session["Customer"] as Customer;
            Customer customer = CustomerBLL.GetCustomerDetail(musteri.CustomerID);
            return View(customer);
        }

        public ActionResult UpdateCustomer(Customer updatedcustomer)
        {
            Customer customer = Session["Customer"] as Customer;
            customer.Address = updatedcustomer.Address;
            customer.City = updatedcustomer.City;
            customer.CompanyName = updatedcustomer.CompanyName;
            customer.ContactName = updatedcustomer.ContactName;
            customer.ContactTitle = updatedcustomer.ContactTitle;
            customer.Country = updatedcustomer.Country;
            customer.Fax = updatedcustomer.Fax;
            customer.Password = updatedcustomer.Password;
            customer.Phone = updatedcustomer.Phone;
            customer.PostalCode = updatedcustomer.PostalCode;
            customer.Region = updatedcustomer.Region;
            CustomerBLL.CustomerUpdate(customer);
            return RedirectToAction("CustomerDetail");
        }
    }
}