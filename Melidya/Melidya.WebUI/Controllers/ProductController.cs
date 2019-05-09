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
    }
}