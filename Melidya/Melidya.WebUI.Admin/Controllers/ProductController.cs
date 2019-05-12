using Melidya.BLL;
using Melidya.DAL;
using Melidya.WebUI.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult saveProduct(ProductModel model)
        {
            Product product = new Product();
            product.ProductName = model.ProductName;
            product.CategoryID = Convert.ToInt32(Session["Category"]);
            product.UnitPrice = model.UnitPrice;
            product.QuantityPerUnit = model.QuantityPerUnit;
            product.UnitsInStock = model.UnitInStock;
            product.UnitsOnOrder = model.UnitsOnOrder;
            product.ReorderLevel = model.ReorderLevel;
            product.Discontinued = model.Discontinued;
            ProductBLL.addProduct(product);
            return RedirectToAction("getCategories","Category");
        }
    }
}