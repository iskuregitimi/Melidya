using Melidya.BLL;
using Melidya.DAL;
using Melidya.WebUI.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login(LoginModel model)
        {
            Employee employee = EmployeeBLL.GetEmployee(model.username, model.password);
            if (employee != null)
            {
                Session["Login"] = employee;
                if ((employee.Password.Trim() == model.password.Trim()) && (employee.Role == "A"))
                {
                    Session["AdminLogin"] = employee;
                    return RedirectToAction("getOrders", "Order");
                }
                else if ((employee.Password.Trim() == model.password.Trim()) && (employee.Role == "O"))
                {
                    Session["ApproverLogin"] = employee;
                    return RedirectToAction("getOrders", "Order");
                }
                else if ((employee.Password.Trim() == model.password.Trim()) && (employee.Role == "K"))
                {
                    Session["ShipperLogin"] = employee;
                    return RedirectToAction("getOrders", "Order");
                }
            }

            return RedirectToAction("getOrders", "Order");
        }


        public ActionResult logout()
        {
            Session["Login"] = null;
            Session["AdminLogin"] = null;
            Session["ApproverLogin"] = null;
            Session["ShipperLogin"] = null;
            return RedirectToAction("Index");
        }
    }
}