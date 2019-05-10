using Melidya.BLL;
using Melidya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Controllers
{
    public class ProductController : Controller
    {
        ProductManager product = new ProductManager();
        // GET: Product
        [HttpGet]
        public ActionResult Products()
        {
           var products= product.GetProducts();
            return View(products);
        }
        [HttpPost]
        public ActionResult Products(Product product)
        {

            return View();
        }
    }
}