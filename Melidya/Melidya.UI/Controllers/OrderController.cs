using Melidya.BusinessLayer;
using Melidya.Entity;
using Melidya.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.UI.Controllers
{
    public class OrderController : Controller
    {
        OrderDetailManager orderDetailManager = new OrderDetailManager();
        OrderManager orderManager = new OrderManager();

        public ActionResult Index()
        {
            if (Session["Login"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            Customers customer = Session["Login"] as Customers;
            List<Orders> orders = orderManager.GetOrders(customer.CustomerID);

            return View(orders);
        }

        public ActionResult OrderDetail(int id)
        {
            List<Order_Details> order_Details = orderDetailManager.GetOrderDetails(id);

            return View(order_Details);
        }

        public ActionResult AddOrder()
        {
            List<SepetModel> sepet = Session["Sepet"] as List<SepetModel>;
            Customers customer = Session["Login"] as Customers;
            Orders order = new Orders
            {
                CustomerID = customer.CustomerID,
                OrderDate = DateTime.Now,
                Freight = (decimal)6.90,
                EmployeeID = 1
            };

            int OrderID = orderManager.AddOrder(order);

            foreach (SepetModel item in sepet)
            {
                Order_Details orderDetails = new Order_Details
                {
                    Quantity=(short)item.Quantity,
                    ProductID=item.ProductID,
                    UnitPrice=(decimal)item.UnitPrice,
                    OrderID=OrderID
                };
                orderDetailManager.AddOrderDetail(orderDetails);
            }

            return RedirectToAction("Index");
        }
    }
}