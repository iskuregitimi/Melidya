using Melidya.BLL;
using Melidya.ENTITY;
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
        OrderBLL orderBLL = new OrderBLL();
        ProductBLL productbll = new ProductBLL();
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

        public ActionResult AddOrder()
        {
            Customers customer = Session["Login"] as Customers;
            int orderID = orderBLL.AddOrder(customer);
            List<SepetModel> model = Session["Sepet"] as List<SepetModel>;
            foreach (SepetModel item in model)
            {
                Products product = productbll.GetProduct(item.ProductID);
                orderBLL.AddOrderDetail(product,item.Quantity,orderID);
            }
            return RedirectToAction("Index");
        }
    }
}