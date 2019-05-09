using Melidya.BLL;
using Melidya.ENTITY;
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
        ProductBLL productbll = new ProductBLL();
        CategoryBLL categoryBLL = new CategoryBLL();

        public ActionResult Index()
        {
            List<Products> products = productbll.GetProducts();
            return View(products);
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Products product,int id)
        {
            Categories cate = categoryBLL.GetCategory(id);
            productbll.AddProduct(product,cate.CategoryID);
            return RedirectToAction("Index");
        }
    }
}