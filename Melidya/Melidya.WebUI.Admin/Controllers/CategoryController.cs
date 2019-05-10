using Melidya.BLL;
using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getCategories()
        {
            List<Category> categoryList = CategoryBLL.GetCategories();
            return View(categoryList);
        }

        public ActionResult addCategory()
        {
            return View();
        }

        public ActionResult saveCategory(Category category)
        {
            CategoryBLL.addCategory(category);
            return RedirectToAction("getCategories");
        }
    }
}