using Melidya.BLL;
using Melidya.DAL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Melidya.WebApi.Controllers
{
    public class OrderController : ApiController
    {
        OrderBLL orderBll = new OrderBLL();


        [HttpGet]
        public List<Order> GetOrders(string id)
        {
            return orderBll.GetOrderswithcustomer(id);
        }


        [HttpGet]
        public Order_Detail GetOrder_Detail(int orderid)
        {
            return orderBll.GetOrder_Detail(orderid);

        }


      
        public List<Order> _GetOrders()
        {
            return orderBll.GetOrders();

        }
    }
}