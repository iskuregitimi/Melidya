using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
    public static class OrderBLL
    {
        static NorthwindModel context = new NorthwindModel();
        public static List<Order> getOrders(string customerID)
        {
            return context.Orders.Where(x => x.CustomerID == customerID).ToList();
        }

        public static List<Order_Detail> GetProducts(int OrderID)
        {
            return context.Order_Details.Where(x => x.OrderID == OrderID).ToList();
        }
    }
}
