using Melidya.BusinessLayer;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.UI.Admin.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager();
        EmployeeManager employeeManager = new EmployeeManager();

        public ActionResult Index()
        {
            if (Session["Login"] != null)
            {
                Employees emp = Session["Login"] as Employees;
                
                if (employeeManager.Control(emp, "Admin"))
                {
                    List<Categories> categories = categoryManager.GetCategories();

                    return View(categories);
                }
                else
                {
                    return RedirectToAction("AdminHata", "Hata");
                }
            }
            return RedirectToAction("Login", "Login");
        }

        public ActionResult AddCategory()
        {
            if (Session["Login"] != null)
            {
                Employees emp = Session["Login"] as Employees;
                if (employeeManager.Control(emp, "Admin"))
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("AdminHata", "Hata");
                }
            }
            return RedirectToAction("Login", "Login");
        }

        [HttpPost]
        public ActionResult AddCategory(Categories category)
        {
            categoryManager.AddCategory(category);

            return RedirectToAction("Index");
        }
    }
}