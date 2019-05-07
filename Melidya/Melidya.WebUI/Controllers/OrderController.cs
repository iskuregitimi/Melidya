using Melidya_BLL;
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
        public ActionResult Order()
        {
            string ıd = Session["User"].ToString();
            var orders = GetOrder.OrderGet(ıd);
            return View(orders);
        }
        public ActionResult OrderDetail(int id)
        {
            var orderdetail = GetOrder.OrderDetailGet(id);
            return View(orderdetail);
        }

    }
}