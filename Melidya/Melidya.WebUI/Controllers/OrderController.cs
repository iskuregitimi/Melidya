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
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        OrderBLL orderBLL = new OrderBLL();
        public ActionResult Orders()
        {
            var user =Session["User"] as Customers;
            var orderList = orderBLL.GetOrders(user.CustomerID);
            return View(orderList);
        }

        public ActionResult OrderDetails()
        {
            orderBLL.GetOrderDetails();

            return View();
        }
    }
}