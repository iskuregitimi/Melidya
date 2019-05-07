using Melidya.BLL;
using Melidya.DAL;
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
        public ActionResult Order()
        {
            Customers customer=Session["Login"] as Customers;
            List<Orders> getOrder = OrderBLL.getorder(customer.CustomerID);
            return View(getOrder);
        }
        public ActionResult Orderdetail(int id)
        {
            List<Order_Details> getOrder = OrderBLL.orderdetail(id);
            return View(getOrder);
        }


    }
}