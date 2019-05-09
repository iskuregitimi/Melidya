using Melidya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
   public static class CustomerManager
    {
        public static Customer GetCustomer(string id)
        {
            MelidyaContextModel dc = new MelidyaContextModel();
            return dc.Customers.FirstOrDefault(x=>x.CustomerID == id);      
        }
        public static void UpdateCustomer(Customer _customers)
        {
            MelidyaContextModel dc = new MelidyaContextModel();
            var customer = dc.Customers.Where(c => c.CustomerID ==_customers.CustomerID).FirstOrDefault();
            customer.ContactName = _customers.ContactName;
            customer.ContactTitle = _customers.ContactTitle;
            customer.CompanyName = _customers.CompanyName;
            customer.Phone = _customers.Phone;
            customer.Fax = _customers.Fax;
            customer.Address = _customers.Address;
            customer.City = _customers.City;
            customer.Country = _customers.Country;
            customer.Region = _customers.Region;
            customer.Password = _customers.Password;
            dc.SaveChanges();
        }
    }
}
