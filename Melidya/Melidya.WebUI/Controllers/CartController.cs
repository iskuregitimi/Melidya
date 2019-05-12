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
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult showCart()
        {
            decimal? price = 0;
            decimal? totalPrice = 0;
            List<SepetModel> products = Session["Cart"] as List<SepetModel>;
            foreach (SepetModel item in products)
            {
                price += (item.Quantity * item.UnitPrice);
            }
            totalPrice = price + (decimal)6.90;
            Session["Price"] = price;
            Session["TotalPrice"] = totalPrice;
            Session["Count"] = products.Count();
            return View(products);
        }

        public ActionResult addToCart(int id)
        {
            Product pro = ProductBLL.GetProduct(id);

            SepetModel model = new SepetModel
            {
                ProductID = pro.ProductID,
                ProductName = pro.ProductName,
                Quantity = 1,
                UnitPrice = pro.UnitPrice
            };

            if (Session["Cart"] == null)
            {
                List<SepetModel> products = new List<SepetModel>();
                Session["Cart"] = products;
            }
            List<SepetModel> prod = Session["Cart"] as List<SepetModel>;

            if (prod.Find(x => x.ProductID == model.ProductID) != null)
            {
                SepetModel mod = prod.Find(x => x.ProductID == model.ProductID);
                mod.Quantity += 1;
            }
            else
            {
                prod.Add(model);
            }

            Session["Count"] = prod.Count();
            return RedirectToAction("getProducts", "Product");
        }

        public ActionResult delete(int id)
        {
            List<SepetModel> model = Session["Cart"] as List<SepetModel>;

            if (model.Find(x => x.ProductID == id) != null)
            {
                SepetModel mod = model.Find(x => x.ProductID == id);
                if (mod.Quantity > 1)
                {
                    mod.Quantity -= 1;
                }
                else
                {
                    model.Remove(mod);
                }
            }

            if(model.Count==0)
            {
                Session["Cart"] = null;
                return RedirectToAction("getProducts", "Product");
            }

            return RedirectToAction("showCart");
        }

        public ActionResult addOrder()
        {
            Customer customer = Session["Login"] as Customer;
            int orderID = OrderBLL.addOrder(customer);


            List<SepetModel> products = Session["Cart"] as List<SepetModel>;
            foreach(var prod in products)
            {
                OrderBLL.addOrderDetail(orderID, prod.ProductID, prod.UnitPrice, prod.Quantity);
            }

            Session["Cart"] = null;
            return RedirectToAction("getProducts", "Product");
        }
    }
}