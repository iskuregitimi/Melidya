using Melidya.BLL;
using Melidya.DAL;
using Melidya.WebUI.Models;
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

        public ActionResult getOrders()
        {
            string customerID = Session["username"].ToString();
            List<Order> orderList = OrderBLL.getOrders(customerID);
            return View(orderList);
        }

        public ActionResult orderDetails(int id)
        {
            List<Order_Detail> orderDetailsList = OrderBLL.GetProducts(id);
            return View(orderDetailsList);
        }
    }
}

