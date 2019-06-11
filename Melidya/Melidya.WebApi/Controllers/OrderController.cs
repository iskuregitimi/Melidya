using Melidya.BLL;
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
        [HttpGet]
        public List<Order> GetOrders()
        {
            OrderBLL x = new OrderBLL();
            return x.ListOrder();

        }
        
    }
}
