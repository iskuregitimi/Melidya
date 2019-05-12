using Melidya_Reloaded.BLL;
using Melidya_Reloaded.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya_Reloaded.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetProducts()
        {
            return View(ProductBLL.getproducts());
        }
    }
}