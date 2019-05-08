using Melidy.BLL;
using Melidya.Entity;
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
        OrderBLL orderbll = new OrderBLL();

        // GET: Order
        public ActionResult Order()
        {
            Customers customer = Session["Login"] as Customers;
            List<Orders> orders = orderbll.GetOrders(customer.CustomerID);
            return View(orders);
            
        }
        public ActionResult Details(int id)
        { 
            List<Order_Details> order_Details = orderbll.Getorderdetails(id);
          
            return View(order_Details);


        }
    }
}