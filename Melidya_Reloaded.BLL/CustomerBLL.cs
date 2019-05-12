using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melidya_Reloaded.DAL;

namespace Melidya_Reloaded.BLL
{
    public class CustomerBLL
    {
        public static Melidya_ReloadedDbContext db = new Melidya_ReloadedDbContext();
        public static Customer checkcustomer(string Customerid, string Pass)
        {  
            
            var findcustomer = db.Customers.Where(c => c.CustomerID == Customerid | c.Password == Pass);
            return findcustomer.FirstOrDefault();
        }

        public static Customer GetCustomerDetail(string CustomerID)
        {
            Customer customer = db.Customers.Where(c => c.CustomerID == CustomerID).FirstOrDefault();
            return (customer);
        }

        public static void CustomerUpdate(Customer customerinformation)
        {
            db.Customers.AddOrUpdate(customerinformation);
            db.SaveChanges();
        }

    }
}
