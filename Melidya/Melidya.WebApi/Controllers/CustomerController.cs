using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Melidya.WebApi.Controllers
{
    public class CustomerController : ApiController
    {
        CustomerBLL customerbll = new CustomerBLL();
        /// <summary>
        /// Müşterileri Listeler.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Customer> GetCustomers()
        {                      
            return customerbll.GetCustomers();
        }

        /// <summary>
        /// Müşteri Detayı Getirir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public Customer _GetCustomerDetail(string id)
        {          
            Customer customer = customerbll.GetCustomer1(id);
            return customer;
        }

        /// <summary>
        /// Müşteri Günceller.
        /// </summary>
        /// <param name="cust"></param>
        /// <returns></returns>
        [HttpPost]
        public void UpdateCustomer(Customer cust)
        {
     
            Customer customer = customerbll.GetCustomer1(cust.CustomerID);
            customer.ContactName = cust.ContactName;
                customer.CompanyName = cust.CompanyName;
                customer.ContactTitle = cust.ContactTitle;
                customer.City = cust.City;
                customer.ContactName = cust.ContactName;
                customer.Address = cust.Address;
                customer.Country = cust.Country;
                customer.Fax = cust.Fax;
                customer.Password = cust.Password;
                customer.Phone = cust.Phone;
                customer.PostalCode = cust.PostalCode;
                customer.Region = cust.Region;
                 customerbll.UpdateCustomer(customer);
        }

        //public IHttpActionResult Put(Customer cust)
        //{
        //    CustomerBLL customerbll = new CustomerBLL();
        //    Customer customer = customerbll.GetCustomer1(cust.CustomerID);
        //    if (customer != null)
        //    {
        //        customer.ContactName = cust.ContactName;
        //        customerbll.UpdateCustomer(customer);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //    return Ok();
        //}

            /// <summary>
            /// Müşteri Ekler
            /// </summary>
            /// <param name="cust"></param>
            /// <returns></returns>
       [HttpPost]
        public void AddCustomer(Customer cust)
        {
            Customer customer = new Customer
            {
                CustomerID = cust.ContactName.Substring(0, 5).ToUpper(),
                CompanyName = cust.CompanyName,
                ContactTitle = cust.ContactTitle,
                City = cust.City,
                ContactName = cust.ContactName,
                Address = cust.Address,
                Country = cust.Country,
                Fax = cust.Fax,
                Password = cust.Password,
                Phone = cust.Phone,
                PostalCode = cust.PostalCode,
                Region = cust.Region
            };
            customerbll.AddCustomer(customer);
        }

    }
}