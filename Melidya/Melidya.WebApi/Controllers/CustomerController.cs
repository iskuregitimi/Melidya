using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;


namespace Melidya.WebApi.Controllers
{
	public class CustomerController : ApiController
	{
		     ///<summary>
			///orderları listeler
			///</summary>
			///
		[HttpGet]
		public List<Customer> GetCustomers()
		{
			CustomerBLL customerbll = new CustomerBLL();
			return customerbll.GetCustomers();
		}
		[HttpGet]
		public Customer UpdateCustomer(string id)
		{
			CustomerBLL customerbll = new CustomerBLL();
			Customer customer = customerbll.GetCustomerId(id);
			return customer;
		}

		[HttpPut]
		public IHttpActionResult UpdateCustomer(Customer cus)
		{
			CustomerBLL customerBLL = new CustomerBLL();
			Customer customer = customerBLL.GetCustomerId(cus.CustomerID);
			if (cus.CustomerID != null)
			{
				customer.ContactName = cus.ContactName;
				customerBLL.UpdateCustomer(customer);
			}
			else
			{
				return NotFound();
			}
			return Ok();
		}
		
		[HttpPost]
		public string AddCustomer(Customer cus)
		{		
			CustomerBLL customerbll = new CustomerBLL();
			cus.CustomerID = cus.ContactTitle.Substring(5,0);
			customerbll.AddCustomer(cus);
			return "eklendi";
		}

		[HttpGet]
		public Customer GetCustomerDetail(string Customerid)
		{
			CustomerBLL customerbll = new CustomerBLL();
			Customer customr = customerbll.GetCustomerId(Customerid);
			return customr;
		}

		
	}
}