using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
  public static  class CustommerBLL
    {
        static DataContext datacontext = new DataContext();
        //public static List<Customers> getCustomers()
        //{
        //    return datacontext.Customers.Where

        //}

        public static void updateCustomers(Customers customer)
        {
            datacontext.SaveChanges();
        }

        public static Customers getcustomer(string id)
        {
            return datacontext.Customers.FirstOrDefault(x=>x.CustomerID==id);
        }
    }
}
