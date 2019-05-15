using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Admin.Controllers
{
    public class ProductController : Controller
    {
        ProductBLL productbll = new ProductBLL();
        CategoryBLL categoryBLL = new CategoryBLL();
        SupplierBLL supplierBLL = new SupplierBLL();

        public ActionResult Index()
        {
            List<Products> products = productbll.GetProducts();
            return View(products);
        }

        public ActionResult AddProduct()
        {
            List<SelectListItem> categories = new List<SelectListItem>();
            List<SelectListItem> suppliers = new List<SelectListItem>();
            foreach (Categories item in categoryBLL.GetCategories())
            {
                categories.Add(new SelectListItem { Text = item.CategoryName, Value = item.CategoryID.ToString() });
            }

            foreach (Suppliers item in supplierBLL.GetSuppliers())
            {
                suppliers.Add(new SelectListItem { Text = item.CompanyName, Value = item.SupplierID.ToString() });

            }
            ViewBag.Suppliers = suppliers;
            ViewBag.Categories = categories;

            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Products product)
        {
            //Categories cate = categoryBLL.GetCategory(id);
            productbll.AddProduct(product);
            return RedirectToAction("Index");
        }
    }
}