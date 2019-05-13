using Melidya.BusinessLayer;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.UI.Admin.Controllers
{
    public class LoginController : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Employees employee)
        {
            Employees emp = employeeManager.GetEmployee(employee.PostalCode);

            if (emp != null)
            {
                if (emp.Password == employee.Password)
                {
                    Session["Login"] = emp;
                    return RedirectToAction("Index", "Order");
                }
            }

            return RedirectToAction("LoginHata","Hata");
        }

        public ActionResult Logout()
        {
            Session["Login"] = null;
            return RedirectToAction("Login");
        }
        
    }
}