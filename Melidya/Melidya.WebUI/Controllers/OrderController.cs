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
            List<Orders> model = new List<Orders>();

            if (Session["Login"] != null)
            {
                string customerId = Session["Login"].ToString();

                model = OrderBLL.GetOrders(customerId);
            }

            return View(model);
          
        }
    }
}