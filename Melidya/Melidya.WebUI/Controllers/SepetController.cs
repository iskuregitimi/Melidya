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
    public class SepetController : Controller
    {
        // GET: Sepet
        public ActionResult Index()
        {
            if (Session["Login"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            return View();
        }
        public ActionResult sepetgoster()
        {
            decimal? sepetTutar = 0;
            decimal? toplamTutar = 0;
            List<SepetModel> products = Session["Sepet"] as List<SepetModel>;
            foreach (SepetModel item in products)
            {

                sepetTutar += (item.Quantity * item.UnitPrice);
                
              
            }
            toplamTutar = sepetTutar + (decimal)6.90;
            Session["SepetTutar"] = sepetTutar;
            Session["ToplamTutar"] = toplamTutar;
            Session["Count"] = products.Count();
            return View(products);

        }
        public ActionResult sepetekle(int id)
        {
            Products pro = productBLL.ListeyeEkle(id);

            SepetModel model = new SepetModel
            {
                ProductID = pro.ProductID,
                ProductName = pro.ProductName,
                Quantity = 1,
                UnitPrice = pro.UnitPrice
            };

            if (Session["Sepet"] == null)
            {
                List<SepetModel> products = new List<SepetModel>();
                Session["Sepet"] = products;
            }

            List<SepetModel> prod = Session["Sepet"] as List<SepetModel>;

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

            return RedirectToAction("GetProduct", "Product");
        }
        public ActionResult Sil(int id)
        {
            List<SepetModel> model = Session["Sepet"] as List<SepetModel>;

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

            return RedirectToAction("sepetgoster");
        }
    }
}