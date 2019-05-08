using Melidya.BLL;
using Melidya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Controllers
{
    public class OrderController : Controller
    {
        OrderManager order = new OrderManager();
        // GET: Order
        [HttpGet]
        public ActionResult Orders()
        {
            var customer =(Customer) Session["Login"];
           var orderlist= order.GetOrders(customer.CustomerID);
            return View(orderlist);   
        }
        [HttpGet]
        public ActionResult OrderDetails(int id)
        {
            var orderdetails=order.GetOrderDetails(id);
            return View(orderdetails);
        }
      
    }
}