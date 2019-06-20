using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace Melidya.WebApi.Controllers
{
    public class OrderController : ApiController
    {
        [HttpGet]
        public List<Order> GetOrder()
        {
            OrderBLL orderBLL = new OrderBLL();
            /// <summary>
            /// Orderları listeler
            /// </summary>
            return orderBLL.GetOrder();
        }
    }
    
}