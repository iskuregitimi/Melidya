using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
  public static  class OrderBLL
    {
        static DataContext datacontext = new DataContext();

        public static List<Orders>  getorder(string customerID)
        {
            return datacontext.Orders.Where(x => x.CustomerID == customerID).ToList();
        }
        public static List<Order_Details> orderdetail(int id)
        {
            return datacontext.Order_Details.Where(x => x.OrderID == id).ToList();

        }
        public  static void insertOrder(Orders order)
        {
            datacontext.Orders.Add(order);
            datacontext.SaveChanges();
        }
        public static void insertOrderdetail(Order_Details detail)
        {
            datacontext.Order_Details.Add(detail);
            datacontext.SaveChanges();
        }
        public static List<Orders> getdetail()
        {
           var detay=from o in Orders join od in Order_Details
        }

    }
}
