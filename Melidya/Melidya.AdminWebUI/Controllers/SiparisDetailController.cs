using Melidya.BLL;
using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.AdminWebUI.Controllers
{
    public class SiparisDetailController : Controller
    {
        // GET: SiparisDetail
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detay()
        {
            var detaiil = OrderBLL.getdetail();

            return View(detaiil);
        }
       
        public ActionResult Onayla(int id)
        {
            Orders orders = OrderBLL.getOrders(id);
            orders.Status = "Onaylandı";
            OrderBLL.updateOrder(orders);


            return RedirectToAction("Detay");


        }
        public ActionResult kargola(int id)
        {
            Orders orders = OrderBLL.getOrders(id);

            if (orders.Status.Trim()== "Onaylandı".Trim())
            {
                orders.Status = "Kargolandı";
                OrderBLL.updateOrder(orders);

            }
            //else
            //{
            //    throw new DivideByZeroException("Kargolanamadı");

            //}
            return RedirectToAction("Detay");

        }
       
    }
}