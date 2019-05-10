using Melidya.AdminWebUI.Models;
using Melidya.BLL;
using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.AdminWebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductList()
        {
            List<Products> products = productBLL.GetProducts();
            return View(products);
        }

        public ActionResult addProduct()
        {
            ViewBag.categories = new SelectList(CategoryBLL.getCategories(), "CategoryID", "CategoryName");
            return View();

        }
        [HttpPost]

        public ActionResult addProduct(ProductsModel model)
        {
            Products products = new Products();
            products.ProductName = model.ProductName;
            products.UnitPrice = model.UnitPrice;
            products.CategoryID = model.Categories;
            products.QuantityPerUnit = model.QuantityPerUnit;
            productBLL.addProducts(products);
            return RedirectToAction("ProductList");
            
        }
        
    }
}