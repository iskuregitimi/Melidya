using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Admin.Controllers
{
    public class LoginController : Controller
    {
        EmployeeBLL employeeBLL = new EmployeeBLL();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session["Admin"] = null;
            return RedirectToAction("Login");
        }

        [HttpPost]
        public ActionResult Login(Employees emp)
        {
            Employees employee = employeeBLL.GetEmployee(emp.LastName);

            if (employee!=null)
            {
                if (employee.Password==emp.Password)
                {
                    Session["Admin"] = employee;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();   
                }

            }
            else
            {
                return View(); ;

            }
        }
    }
}