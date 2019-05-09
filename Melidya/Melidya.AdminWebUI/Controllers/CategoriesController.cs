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
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult categories()
        {
            List<Categories> category = CategoryBLL.getCategories();
            Session["Categories"] = category;
            return View(category);
        }

        public ActionResult addcategories()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addcategories(KayitModel model)
        {
            Categories categories = new Categories();
            categories.CategoryName = model.CategoryName;
            categories.Description = model.Description;
            CategoryBLL.InsertCategories(categories);
            return RedirectToAction("categories");
        }
    }
}