using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
    public static class CustomerBLL
    {
        public static Customers GetCustomers(string customerid)
        {
            DataContext db = new DataContext();

            return db.Customers.Where(x => x.CustomerID == customerid).FirstOrDefault();
        }


    }
}
