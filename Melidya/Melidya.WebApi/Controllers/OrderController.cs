using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Melidya.WebApi.Controllers
{
    public class OrderController:ApiController
    {
        OrderBLL orderbll = new OrderBLL();
        [HttpGet]
        public List<Order> GetOrders()
        {
          
            return orderbll.GetOrders();
        }

        [HttpGet]
        public List<Order_Detail> GetOrdersDetail(int Id)
        {
            Order order = orderbll.GetOrder(Id);       
            return orderbll.GetOrdersDetail(order.OrderID);
        }
    }
}