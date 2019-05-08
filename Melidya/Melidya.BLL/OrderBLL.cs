using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
   public class OrderBLL
    {
        static DataContext db = new DataContext();

        public static List<Orders> GetOrders (string id)
        {
            return db.Orders.Where(x => x.CustomerID == id).ToList();
        }

        public static List<Order_Details> GetOrder_Details(int orderID)
        {
            return db.Order_Details.Where(x => x.OrderID == orderID).ToList();
        }
    }
}
