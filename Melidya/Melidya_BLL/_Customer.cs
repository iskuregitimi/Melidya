using Entiys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya_BLL
{
    public static class _Customer
    {
        static NorthwindDb db = new NorthwindDb();

        public static Customer GetCustomer(string User,string Password)
        {
          return  db.Customers.Where(x => x.CustomerID == User && x.Password == Password).FirstOrDefault();     
        }

        public static void Update( Customer csm)
        {
           var customer= db.Customers.Where(x => x.CustomerID == csm.CustomerID).FirstOrDefault();
            customer.CompanyName = csm.CompanyName;
            customer.ContactName = csm.ContactName;
            customer.PostalCode = csm.PostalCode;
            customer.City = csm.City;
            customer.Address = csm.Address;
            customer.ContactTitle = csm.ContactTitle;
            customer.Password = csm.Password;
            customer.Country = csm.Country;
            customer.Fax = csm.Fax;
            customer.Phone = csm.Phone;

            db.SaveChanges();

        }
    }
}
