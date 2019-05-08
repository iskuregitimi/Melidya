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
    }
}
