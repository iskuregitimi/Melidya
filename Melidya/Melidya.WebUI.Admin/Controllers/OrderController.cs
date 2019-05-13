using Melidya.BLL;
using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Admin.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getOrders()
        {
            var orderList = OrderBLL.getAllOrders();
            return View(orderList);
        }

        public ActionResult approveOrder(int id)
        {
            Order order = OrderBLL.getOrder(id);
            if (order.Status.Trim() == "Yeni".Trim())
            {
                order.Status = "Onaylandı";
                OrderBLL.updateOrder(order);
            }
            return RedirectToAction("getOrders");
        }

        public ActionResult shipOrder(int id)
        {
            Order order = OrderBLL.getOrder(id);
            if (order.Status.Trim() == "Onaylandı".Trim())
            {
                order.Status = "Kargolandı";
                OrderBLL.updateOrder(order);
            }
            return RedirectToAction("getOrders");
        }
    }
}