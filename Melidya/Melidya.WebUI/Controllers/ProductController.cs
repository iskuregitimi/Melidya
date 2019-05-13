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
    public class ProductController : Controller
    {

        ProductBLL productBLL = new ProductBLL();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {

            List<Product> product = productBLL.GetProducts();
            return View(product);
        }

        public ActionResult Sepet()
        {
		
			List<SepetModel> models = Session["Sepet"] as List<SepetModel>;	
            decimal toplamfiyat = 0;
            decimal subtotal = 0;
           
            foreach (SepetModel item in models)
            {
                subtotal += Convert.ToDecimal(item.Quantity * item.Price);
                toplamfiyat = subtotal + (decimal)6.90;
            }
            Session["Count"] = models.Count();
            Session["Subtotal"] = subtotal;
            Session["Toplam"] = toplamfiyat;
    
			return View(models);
		}


		public ActionResult Sepet1()
		{

			
			return View();
		}




		public ActionResult AddSepet(int id)
        {
            Product product = productBLL.GetProduct(id);
            if (Session["Sepet"] == null)
            {
                List<SepetModel> newModel = new List<SepetModel>();
                Session["Sepet"] = newModel;
            }
            SepetModel model = new SepetModel
            {
                ProductName = product.ProductName,
                ProductID = product.ProductID,
                Price = product.UnitPrice,
                Quantity = 1

            };
            List<SepetModel> models = Session["Sepet"] as List<SepetModel>;
            if(models != null)
            {
                SepetModel sepet = models.Find(x=> x.ProductID==model.ProductID);
                if (sepet!=null)
                {
                    sepet.Quantity += 1;
                }
                else
                {
                    models.Add(model);
                }
 
            }
            else
            {
                models.Add(model);
            }
            Session["Count"] = models.Count();
            return RedirectToAction("Products");
        }

        public ActionResult DeleteSepet(int id)
        {
            List<SepetModel> models = Session["Sepet"] as List<SepetModel>;
            if (Session["Sepet"] != null)
            {
                SepetModel sepet = models.Find(x=> x.ProductID==id);
                if (sepet.Quantity>1)
                {
                    sepet.Quantity -= 1;
                }
                else
                {
                    models.Remove(sepet);
                }
            }
            return RedirectToAction("Sepet","Product");




        }

    }
}