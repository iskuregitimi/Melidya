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
            Customer customer = null;
            if (Session["Login"] != null)
            {
                customer = Session["Login"] as Customer;
            }
            List<Order> orderList = OrderBLL.getOrders(customer.CustomerID);
            return View(orderList);
        }

        public ActionResult orderDetails(int id)
        {
            List<Order_Detail> orderDetailsList = OrderBLL.GetProducts(id);
            return View(orderDetailsList);
        }
    }
}

