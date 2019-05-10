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
    public class AdminLoginController : Controller
    {
        // GET: AdminLogin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminLogin(AdminLoginModel model)
        {

            Employees employees = EmployeeBLL.GetEmployees(model.FirstName);
            if (employees.Password.Trim()== model.Password.Trim())
            {
                Session["AdminLogin"] = employees;
                return RedirectToAction("categories", "Categories");
            }
            return RedirectToAction("ProductList", "Product");
        }
    }

    
}