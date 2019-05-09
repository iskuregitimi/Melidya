using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Admin.Controllers
{
    public class CategoryController : Controller
    {
        CategoryBLL categoryBLL = new CategoryBLL();
        // GET: Category
        public ActionResult Index()
        {
            List<Categories> categories = categoryBLL.GetCategories();
            return View(categories);
        }

        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Categories cate)
        {
            categoryBLL.AddCategory(cate);
            return RedirectToAction("Index");
        }

  
        public ActionResult Delete(int id)
        {
           Categories category= categoryBLL.GetCategory(id);
            categoryBLL.Delete(category);
            return RedirectToAction("Index");
        }
    }
}