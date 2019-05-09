using Melidya.BLL;
using Melidya.DAL;
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
            return View();
        }
        public ActionResult sepetgoster()
        {

            Products products = Session["Sepet"] as Products;
            var goster = productBLL.ListeyeEkle(products.ProductID);
            return View(goster);

        }

    }
}