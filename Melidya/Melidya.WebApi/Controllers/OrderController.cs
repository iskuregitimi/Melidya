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
		public List<Order> GetOrderList()
		{
			OrderBLL orderbll = new OrderBLL();
			return orderbll.GetAllOrders();

		}

		[HttpGet]
		public List<Order> GetOrders(string id)
		{
			OrderBLL orderbll = new OrderBLL();
			return orderbll.GetOrders(id);

		}

		public List<Order_Detail> GetOrder_Details(int id)
		{
			OrderBLL orderbll = new OrderBLL();
			 return orderbll.GetOrder_Detail(id);
			

		}
	}
}
