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
    }
}
