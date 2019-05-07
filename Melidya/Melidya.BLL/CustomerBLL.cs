using Melidya.DAL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
   public class CustomerBLL
    {
        RepositoryPattern<Customers> repo = new RepositoryPattern<Customers>();
        DataContext db = new DataContext();
        public List<Customers> GetCustomers()
        {
            return repo.List();
        }
        public Customers GetCustomer(string customerID)
        {
            return repo.Find(x => x.CustomerID == customerID);
        }
        //public List<Customers> GetCustomerList()
        //{
        //    return db.Customers.ToList();
        //}

        //public  Customers GetCustomer(string Id)
        //{
        //    return db.Customers.Where(x => x.CustomerID == Id).FirstOrDefault();
        //}

        //public  void DeleteCustomer(string Id)
        //{
        //    Customers cust = db.Customers.Where(x => x.CustomerID == Id).FirstOrDefault();
        //    db.Customers.Remove(cust);
        //    db.SaveChanges();
        //}

        public void UpdateCustomer(Customers customer)
        {
            Customers cust = db.Customers.FirstOrDefault(x => x.CustomerID == customer.CustomerID);
            cust.CustomerID = customer.CustomerID;
            cust.Password = customer.Password;
            cust.CompanyName = customer.CompanyName;
            cust.ContactName = customer.ContactName;
            cust.ContactTitle = customer.ContactTitle;
            cust.Address = customer.Address;
            cust.City = customer.City;
            cust.Country = customer.Country;
            cust.Fax = customer.Fax;
            cust.Phone = customer.Phone;
            cust.PostalCode = customer.PostalCode;
            cust.Region = customer.Region;
            db.SaveChanges();
        }
    }
}
