using BugunNeYesem.DataAccessLayer.EntityFramework;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BusinessLayer
{
    public class CustomerManager
    {
        Repository<Customers> repo = new Repository<Customers>();

        public Customers GetCustomer(string id)
        {
            return repo.Find(x => x.CustomerID == id);
        }

        public void Update(Customers cust)
        {
            Customers customer = repo.Find(x => x.CustomerID == cust.CustomerID);
            customer.CustomerID = cust.CustomerID;
            customer.ContactName = cust.ContactName;
            customer.CompanyName = cust.CompanyName;
            customer.ContactTitle = cust.ContactTitle;
            customer.Address = cust.Address;
            customer.City = cust.City;
            customer.Country = cust.Country;
            customer.CustomerDemographics = cust.CustomerDemographics;
            customer.Fax = cust.Fax;
            customer.Password = cust.Password;
            customer.Phone = cust.Phone;
            customer.PostalCode = cust.PostalCode;
            customer.Region = cust.Region;

            repo.Update(customer);
        }
    }
}
