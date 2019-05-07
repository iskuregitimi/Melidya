using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
    public static class CustomerBLL
    {
        static NorthwindModel context = new NorthwindModel();
        public static Customer getContactName(object username, object password)
        {
            return context.Customers.FirstOrDefault(x => x.CustomerID == username.ToString() && x.Password == password.ToString());
        }
    }
}
