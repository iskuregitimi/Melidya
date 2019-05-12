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
        static DataContext datacontext = new DataContext();
        public static int orderID = datacontext.Orders.Max(x => x.OrderID);

        public static Orders getOrders(int orderID)
        {
            return datacontext.Orders.FirstOrDefault(x => x.OrderID == orderID);
        }
        public static List<Orders> getorder(string customerID)
        {
            return datacontext.Orders.Where(x => x.CustomerID == customerID).ToList();
        }
        public static List<Order_Details> orderdetail(int id)
        {
            return datacontext.Order_Details.Where(x => x.OrderID == id).ToList();

        }
        public static void insertOrder(Orders order)
        {
            datacontext.Orders.Add(order);
            datacontext.SaveChanges();
        }

        public static void insertOrderdetail(Order_Details detail)
        {
            datacontext.Order_Details.Add(detail);
            datacontext.SaveChanges();
        }
        public static void updateOrder(Orders orders)
        {
            datacontext.SaveChanges();
        }
    

        public static IQueryable <SiparisDetailModel> getdetail()
        {

            //var detail =  from o in datacontext.Orders
            //              join c in datacontext.Customers on o.CustomerID equals c.CustomerID
            //              join od in datacontext.Order_Details 
            //              on o.OrderID equals od.OrderID
            //              select new SiparisDetailModel
            //              {

            //                   OrderID= od.OrderID,
            //                  ContactName= c.ContactName,
            //                  OrderDate= o.OrderDate,
            //                  ShipAddress= o.ShipAddress,


            //                  TotalAmount +=(od.UnitPrice*od.Quantity)
            //              };

            var detail = from cust in datacontext.Customers
                         join order in datacontext.Orders on cust.CustomerID equals order.CustomerID
                         join od in datacontext.Order_Details on order.OrderID equals od.OrderID
                         group od by new { cust.ContactName, order.OrderID, order.OrderDate, order.ShipAddress, order.Status } into g
                         select new SiparisDetailModel
                         {
                             ContactName=g.Key.ContactName,
                             OrderID=g.Key.OrderID,
                             OrderDate=g.Key.OrderDate,
                             ShipAddress=g.Key.ShipAddress,
                             TotalAmount=g.Sum(x=>x.UnitPrice * x.Quantity),
                             Status=g.Key.Status
                         };

            return detail;
          

        }

    }
}
