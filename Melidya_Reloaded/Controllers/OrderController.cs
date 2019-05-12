using Melidya_Reloaded.BLL;
using Melidya_Reloaded.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya_Reloaded.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GellAllOrdersFromID()
        {
            Customer customerid = Session["Customer"] as Customer;

            var orderlist = OrderBLL.getallorders(customerid.CustomerID);

            return View(orderlist);
        }

        public ActionResult GetOrderDetails(int OrderID)
        {
            var orderdetails = OrderBLL.getorderdetails(OrderID);
            return View(orderdetails);
        }
    }
}