using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Melidya.WebApi.Controllers
{
    public class CustomerController:ApiController
    {     [HttpGet]
        public List<Customer> GetCustomers()
        {
            CustomerBLL customerBLL = new CustomerBLL();
            return customerBLL.GetCustomers();
        }
      
        [HttpGet]
        public Customer GetCustomerDetail(string Customerid)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            Customer customr = customerBLL.GetCustomerId(Customerid);
            return customr;
        }
        [HttpPost]
        public string AddCustomer(Customer cus)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            //substring girdiğimiz contactname ismiminin ilk 5 değerini alarak id haline getiriyo
            cus.CustomerID = cus.ContactName.Substring(5, 0);
            customerBLL.AddCustomer(cus);
           
            return "eklendi";
        }

    }
}