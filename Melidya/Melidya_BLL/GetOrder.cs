using Entiys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya_BLL
{
    public static class GetOrder
    {
        static NorthwindDb db = new NorthwindDb();

        public static List<Order> OrderGet(string CustomerID)
        {
           return db.Orders.Where(x => x.CustomerID == CustomerID).ToList();
        }

        public static List<Order_Detail> OrderDetailGet(int id)
        {
           return db.Order_Details.Where(x => x.OrderID == id).ToList();
        }
    }
}
