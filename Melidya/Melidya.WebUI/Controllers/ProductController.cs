using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Controllers
{
    public class ProductController : Controller
    {
        ProductBLL productbll = new ProductBLL();
        // GET: Product
        public ActionResult Index()
        {
            List<Products> products = productbll.GetProducts(); 
            return View(products);
        }

        public ActionResult Sepet()
        {
            return View();
        }
    }
}