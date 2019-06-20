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
    public class CustomerController : ApiController
    {

        CustomerBLL customerbll = new CustomerBLL();
        /// <summary>
        /// Müşteri Listesi Döner
        /// </summary>
        [HttpGet]
        public List<Customer> GetCustomers()
        {
            return customerbll.GetCustomers();
        }


        /// <summary>
        /// Müsteriyi Günceller
        /// </summary>
        /// <param name="cust">güncellenecek müsteri</param>
        [HttpPost]
        public void UpdateCustomer(Customer cust)
        {
            Customer customer = customerbll.GetCustomerId(cust.CustomerID);
            customer.CustomerID = cust.CustomerID;
            customer.ContactName = cust.ContactName;
            customer.CompanyName = cust.CompanyName;
            customer.ContactTitle = cust.ContactTitle;
            customer.Country = cust.Country;
            customer.City = cust.City;
            customer.Fax = cust.Fax;

            customer.Password = cust.Password;
            customer.Phone = cust.Phone;
            customer.PostalCode = cust.PostalCode;
            customer.Region = cust.Region;
            customerbll.UpdateCustomer(customer);
        }

        /// <summary>
        /// Customer Detayı Gosterir
        /// </summary>
        /// <param name="CustomerId">Musteri IDsi</param>
        /// <returns>Musteri Detay Bilgisi</returns>
        [HttpPost]
        public Customer ACustomerDetail(string CustomerId)
        {
            Customer customer = customerbll.GetCustomerId(CustomerId);
            return customer;
        }
        [HttpPost]
      public void MusteriEkle(Customer customer)
        {
            customerbll.MusteriEkle(customer);
        }




    }
}