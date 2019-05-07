using Melidya.BLL;
using Melidya.ENTITY;
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
        public ActionResult Index()
        {
            List<Orders> orders = new List<Orders>();
            if (Session["Login"] != null)
            {
                Customers customer = Session["Login"] as Customers;
                orders = orderBLL.GetOrders(customer.CustomerID);
            }

            return View(orders);
        }

        public ActionResult GetDetails(int id)
        {
            List<Order_Details> orderdetails = orderBLL.GetDetails(id);
            return View(orderdetails);
        }
   
    }
}