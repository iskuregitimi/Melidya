using Melidya.BLL;
using Melidya.ENTITY;
using Melidya.WebApi.Models;
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
        [HttpGet]
        public List<Customer> GetCustomers()
        {
            CustomerBLL customerbll = new CustomerBLL();
            return customerbll.GetCustomers();
        }
        [HttpGet]
        [HttpPost]

        public string InsertToCustomer(Customer cust)
        {
            CustomerBLL customerbll = new CustomerBLL();
            Customer custo = new Customer();
            custo.Address = cust.Address;
            custo.City = cust.City;
            custo.CompanyName = cust.CompanyName;
            custo.Password = cust.Password;
            //custo.ContactTitle = cust.ContactTitle;
            //custo.Country = cust.Country;
            //custo.Region = cust.Region;
            //custo.PostalCode = cust.PostalCode;
            //custo.Phone = cust.Phone;
            //custo.Password = cust.Password;
            custo.CustomerID = cust.CustomerID;
            //custo.Fax = cust.Fax;
            //custo.ContactName = cust.ContactName;
            customerbll.AddCustomer(custo);
            return cust.ContactName + "database eklendi";
        }
        [HttpGet]
        [HttpPost]
        public HttpResponseMessage Update(string id, [FromBody]Customer cust)
        {
            //fetching and filter specific member id record   
            CustomerBLL customerbll = new CustomerBLL();
            Customer result = customerbll.GetCustomerId(id);

            //checking fetched or not with the help of NULL or NOT.  
            if (result != null)
            {
                //set received _member object properties with memberdetail  
                result.CustomerID = cust.CustomerID;
                result.CompanyName = cust.CompanyName;
                result.City = cust.City;
                result.Address = cust.Address;
                result.Country = cust.Country;

                //save set allocation.  
                customerbll.UpdateCustomer(result);

                //return response status as successfully updated with member entity  
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                //return response error as NOT FOUND  with message.  
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Code or Member Not Found");
            }


        }
        [HttpPost]
        public HttpResponseMessage Delete(string id)
        {
            CustomerBLL customerbll = new CustomerBLL();
            Customer result = customerbll.GetCustomerId(id);
            if (result != null)
            {

                customerbll.DeleteCustomer(id);


                //return response status as successfully deleted with member id  
                return Request.CreateResponse(HttpStatusCode.OK, id);
            }
            else
            {
                //return response error as Not Found  with exception message.  
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Member Not Found or Invalid " + id.ToString());
            }



        }






        //[HttpGet]
        //public Customer GetCustomerId(string id)
        //{
        //    CustomerBLL customerbll = new CustomerBLL();
        //    Customer result = customerbll.GetCustomerId(id);
        //    CustomerModel model = new CustomerModel()
        //    {
        //        CustomerID = result.CustomerID,
        //        CompanyName = result.CompanyName
        //};


        //    return model;
        //}

        //public void Update(CustomerModel model,string id)
        //{
        //    CustomerBLL customerbll = new CustomerBLL();
        //    Customer result = customerbll.GetCustomerId(id);
        //    result.CustomerID = model.CustomerID;
        //    result.CompanyName = result.CompanyName;
        //    customerbll.UpdateCustomer(result);

        //}
    }
}