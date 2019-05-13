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

            List<SepetModel> productt = Session["Sepet"] as List<SepetModel>;
            List<Products> product = productbll.GetProduct();

            return View(product);
        }
        public ActionResult SepeteEkle(int id)
        {
            Products prod = productbll.ProductsEkle(id);
            SepetModel model = new SepetModel
            {
                ProductID = prod.ProductID,
                ProductName = prod.ProductName,
                Quantity = 1,
                UnitPrice = prod.UnitPrice
            };

            if (Session["Sepet"] == null)
            {
                List<SepetModel> models = new List<SepetModel>();
                Session["Sepet"] = models;
            }


            List<SepetModel> sepet = Session["Sepet"] as List<SepetModel>;
            if (sepet.Find(x => x.ProductID == model.ProductID) != null)
            {
                SepetModel mod = sepet.Find(x => x.ProductID == model.ProductID);
                mod.Quantity += 1;
            }
            else
            {
                sepet.Add(model);

            }

            Session["Sepet"] = sepet;
            Session["Count"] = sepet.Count();

            return RedirectToAction("ProductList");
        }

        public ActionResult SepetGöster()
        {
            decimal? SepetTutar = 0;
            decimal? ToplamTutar = 0;

            List<SepetModel> sepet = Session["Sepet"] as List<SepetModel>;
            foreach (SepetModel item in sepet)
            {
                SepetTutar += (item.Quantity * item.UnitPrice);
            }
            ToplamTutar = SepetTutar + (decimal)6.90;
            Session["SepetTutar"] = SepetTutar;
            Session["ToplamTutar"] = ToplamTutar;
            Session["Count"] = sepet.Count();
            return View(sepet);
        }

        public ActionResult Sil(int id)
        {

            List<SepetModel> sepet = Session["Sepet"] as List<SepetModel>;
            SepetModel model = sepet.Find(x => x.ProductID == id);
            if (model.Quantity > 1)
            {
                model.Quantity -= 1;

            }
            else
            {
                sepet.Remove(model);

            }

            return RedirectToAction("SepetGöster");
        }
    }
}






