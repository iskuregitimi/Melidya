using Melidya.BLL;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Controllers
{
    public class OrderController : Controller
    {
        OrderBLL orderBLL = new OrderBLL();
        // GET: Order
        public ActionResult OrderIndex()
        {
            Customers customer = Session["Login"] as Customers;
            List<Orders> orders = orderBLL.GetOrders(customer.CustomerID);
            return View(orders);
        }
        public ActionResult OrderDetailsIndex(int orderId)
        {
            List<Order_Details> details = orderBLL.GetOrder_Details(orderId);
            return View(details);
        }
    }
}