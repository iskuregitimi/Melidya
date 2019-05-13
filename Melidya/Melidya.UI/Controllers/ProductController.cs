using Melidya.BusinessLayer;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.UI.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager();

        public ActionResult Products()
        {
            List<Products> products = productManager.GetProducts();
            return View(products);
        }
    }
}