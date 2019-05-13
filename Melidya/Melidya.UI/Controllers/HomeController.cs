using Melidya.BusinessLayer;
using Melidya.Entity;
using Melidya.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.UI.Controllers
{
    public class HomeController : Controller
    {
        CustomerManager customerManager = new CustomerManager();
        ProductManager productManager = new ProductManager();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Customers customer)
        {
            Customers Login = customerManager.GetCustomer(customer.CustomerID);
            if (Login.Password == customer.Password)
            {
                Session["Login"] = Login;
                return RedirectToAction("Index", "Order");
            }
            return RedirectToAction("LoginHata");
        }

        public ActionResult Basket()
        {
            if (Session["Login"] == null)
            {
                return RedirectToAction("LoginHata");
            }
            List<SepetModel> products = Session["Sepet"] as List<SepetModel>;
            decimal? toplam = 0;
            decimal? sepetToplam = 0;
            foreach (SepetModel item in products)
            {
                toplam += item.Quantity * item.UnitPrice;
            }
            sepetToplam = toplam + (decimal)6.90;
            Session["Toplam"] = toplam;
            Session["SepetToplam"] = sepetToplam;
            Session["Count"] = products.Count();
            return View(products);
        }

        public ActionResult AddBasket(int id)
        {
            if (Session["Login"] == null)
            {
                return RedirectToAction("LoginHata");
            }
            if (Session["Sepet"] == null)
            {
                List<SepetModel> newProducts = new List<SepetModel>();
                Session["Sepet"] = newProducts;
            }
            Products pro = productManager.GetProduct(id);
            SepetModel model = new SepetModel
            {
                ProductID = pro.ProductID,
                ProductName = pro.ProductName,
                Quantity = 1,
                UnitPrice = pro.UnitPrice
            };
            List<SepetModel> products = Session["Sepet"] as List<SepetModel>;

            SepetModel mevcutUrun = products.Find(x => x.ProductID == model.ProductID);
            if (mevcutUrun != null)
            {
                mevcutUrun.Quantity = mevcutUrun.Quantity + 1;
            }
            else
            {
                products.Add(model);
            }
            Session["Count"] = products.Count();
            return RedirectToAction("Products", "Product");
        }

        public ActionResult RemoveBasket(int id)
        {
            List<SepetModel> products = Session["Sepet"] as List<SepetModel>;

            SepetModel mevcutUrun = products.Find(x => x.ProductID == id);

            if (mevcutUrun.Quantity > 1)
            {
                mevcutUrun.Quantity = mevcutUrun.Quantity - 1;
            }
            else
            {
                products.Remove(mevcutUrun);
            }
            return RedirectToAction("Basket");
        }

        public ActionResult LoginHata()
        {
            return View();
        }

        public ActionResult Exit()
        {
            Session["Login"] = null;
            Session["Sepet"] = null;
            return RedirectToAction("Index", "Order");
        }
    }
}