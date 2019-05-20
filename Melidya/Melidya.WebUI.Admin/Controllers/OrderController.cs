using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Admin.Controllers
{
    public class OrderController : Controller
    {
        OrderBLL orderBLL = new OrderBLL();
        EmployeeBLL employeeBLL = new EmployeeBLL();

        public ActionResult Index()
        {
            
            var order = orderBLL.GetModel();
            Employees emp = Session["Admin"] as Employees;
            foreach (EmployeeRol item in emp.EmployeeRol)
            {
                if (item.Rols.AuthorityName=="Admin")
                {
                    ViewBag.Onay = "visible";
                    ViewBag.Kargo = "visible";
                }
                else if (item.Rols.AuthorityName=="Kargocu")
                {
                    ViewBag.Onay = "hidden";
                    ViewBag.Kargo = "visible";
                }
                else
                {
                    ViewBag.Kargo = "hidden";
                    ViewBag.Onay = "visible";
                }
            }            
            return View(order);
        }

      

        public ActionResult Kargo(int id)
        {
            Employees emp = Session["Admin"] as Employees;
            Orders order = orderBLL.GetOrder(id);
            if (Session["Admin"] != null)
            {
                if (order.Status == "Kargoya Verildi")
                {
                    return RedirectToAction("Index");
                }
                else if (order.Status == "Onaylandı")
                {
                    order.Status = "Kargoya Verildi";
                }
                else
                {
                    return RedirectToAction("Index");
                }
                orderBLL.Update(order);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login", "Login");
        }

        
        public ActionResult Onay(int id)
        {
            Employees emp = Session["Admin"] as Employees;
            Orders order = orderBLL.GetOrder(id);
            if (Session["Admin"] != null)
            {
                if (order.Status == "Onaylandı")
                {
                    return RedirectToAction("Index");
                }
                else if (order.Status == "Kargoya Verildi")
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    order.Status = "Onaylandı";
                }
                orderBLL.Update(order);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login", "Login");
        }
    }
}