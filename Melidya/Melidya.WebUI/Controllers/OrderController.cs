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

        OrderBLL orderbll = new OrderBLL();
        // GET: Order
        public ActionResult OrderIndex()
        {
            Customer customer = Session["Login"] as Customer;
            List<Order> orders = orderbll.GetOrders(customer.CustomerID);
            return View(orders);

        }
        public ActionResult OrderDetailIndex(int id)
        {
			Order_Detail orderdetay = orderbll.GetOrder_Detail(id);
            return View(orderdetay);
        }

       
    }
}