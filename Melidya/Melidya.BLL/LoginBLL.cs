using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
    public static class LoginBLL
    {
        static DataContext datacontext = new DataContext();
        public static Customers LoginCustomers(string CustomerId)
        {
            return datacontext.Customers.Where(x => x.CustomerID == CustomerId).FirstOrDefault();


        }






    }
}
