using Melidya.BLL;
using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult GetProduct()
        {
            List<Products> products = productBLL.GetProducts();




            return View(products);

            //List<Product> productList = new List<Product>(); 
            //     if (HttpContext.Current.Session["BasketProducts"] == null) 
            //     { 
            //         return productList; 
            //     } 
            //     else 
            //     { 
            //         productList = (List<Product>) HttpContext.Current.Session["BasketProducts"]; 
            //         return productList; 
            //     } 

        }

        public  ActionResult sepetekle(int id)
        {
            List<Products> products = new List<Products>();

            Session["Sepet"] = productBLL.ListeyeEkle(id);
            return RedirectToAction("sepetgoster", "Sepet");
        }
        
    }
}