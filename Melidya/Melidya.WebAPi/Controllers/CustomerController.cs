using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Melidya.WebAPi.Controllers
{
    public class CustomerController : ApiController
    {
        [HttpGet]
        public List<Customer> GetCustomers()
        {
            CustomerBLL customerBLL = new CustomerBLL();
            return customerBLL.GetCustomers();
        }
    }
}