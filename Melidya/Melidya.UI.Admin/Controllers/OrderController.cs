using Melidya.BusinessLayer;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.UI.Admin.Controllers
{
    public class OrderController : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager();
        OrderManager orderManager = new OrderManager();
        ModelManager modelManager = new ModelManager();

        public ActionResult Index()
        {
            Employees emp = Session["Login"] as Employees;
            if (employeeManager.Control(emp, "Admin"))
            {
                ViewBag.OnaylaVisibility = "Visible";
                ViewBag.KargolaVisibility = "Visible";
            }
            else if (employeeManager.Control(emp, "Confirmatory"))
            {
                ViewBag.OnaylaVisibility = "Visible";
                ViewBag.KargolaVisibility = "Hidden";
            }
            else
            {
                ViewBag.OnaylaVisibility = "Hidden";
                ViewBag.KargolaVisibility = "Visible";
            }

            var orders = modelManager.GetOrderModels().ToList();

            return View(orders);
        }

        public ActionResult StatusConfirm(int id)
        {
            Employees emp = Session["Login"] as Employees;
            Orders order = orderManager.GetOrder(id);
            if (Session["Login"] != null)
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
                orderManager.Update(order);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login", "Login");
        }

        public ActionResult StatusCargo(int id)
        {
            Employees emp = Session["Login"] as Employees;
            Orders order = orderManager.GetOrder(id);
            if (Session["Login"] != null)
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
                orderManager.Update(order);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login", "Login");
        }
    }
}