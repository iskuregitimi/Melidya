using Melidya.BusinessLayer;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.UI.Admin.Controllers
{
    public class ProductController : Controller
    {
        CategoryManager categoryManager = new CategoryManager();
        SupplierManager supplierManager = new SupplierManager();
        ProductManager productManager = new ProductManager();
        EmployeeManager employeeManager = new EmployeeManager();

        public ActionResult Index()
        {
            if (Session["Login"] != null)
            {
                Employees emp = Session["Login"] as Employees;
                if (employeeManager.Control(emp, "Admin"))
                {
                    List<SelectListItem> categories = new List<SelectListItem>();
                    foreach (Categories item2 in categoryManager.GetCategories())
                    {
                        categories.Add(new SelectListItem { Text = item2.CategoryName, Value = item2.CategoryID.ToString() });
                    }
                    ViewBag.Categories = categories;
                    List<SelectListItem> supplier = new List<SelectListItem>();
                    foreach (Suppliers supp in supplierManager.GetSuppliers())
                    {
                        supplier.Add(new SelectListItem { Text = supp.CompanyName, Value = supp.SupplierID.ToString() });
                    }
                    ViewBag.Suppliers = supplier;
                    return View();
                }

                return RedirectToAction("AdminHata", "Hata");
            }
            return RedirectToAction("Login", "Login");
        }

        [HttpPost]
        public ActionResult AddProduct(Products product)
        {
            productManager.AddProduct(product);
            return RedirectToAction("Index");
        }

        public ActionResult AllProduct()
        {
            if (Session["Login"] != null)
            {
                Employees emp = Session["Login"] as Employees;
                if (employeeManager.Control(emp, "Admin"))
                {
                    List<Products> products = productManager.GetProducts();
                    List<Categories> categories = categoryManager.GetCategories();
                    ViewBag.Categories = categories;
                    return View(products);
                }
                return RedirectToAction("AdminHata", "Hata");
            }

            return RedirectToAction("Login", "Login");
        }

        public ActionResult Product(int id)
        {
            if (Session["Login"] != null)
            {
                Employees emp = Session["Login"] as Employees;
                if (employeeManager.Control(emp, "Admin"))
                {
                    List<Products> products = productManager.GetProducts(id);
                    List<Categories> categories = categoryManager.GetCategories();
                    ViewBag.Categories = categories;

                    return View(products);
                }
                return RedirectToAction("AdminHata", "Hata");
            }
            return RedirectToAction("Login", "Login");
        }
    }
}