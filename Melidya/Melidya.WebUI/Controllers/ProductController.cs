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
            
        }

       
        
    }
}