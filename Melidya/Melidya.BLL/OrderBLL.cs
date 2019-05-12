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

        public static int addOrder(Customer customer)
        {
            Order order = new Order();
            order.CustomerID = customer.CustomerID;
            order.EmployeeID = 1;
            order.OrderDate = DateTime.Now;
            order.RequiredDate = DateTime.Now;
            order.ShippedDate = DateTime.Now;
            order.ShipVia = 1;
            order.Freight = 16;
            order.ShipName = "Tolga Kamçı";
            order.ShipAddress = customer.Address;
            order.ShipCity = customer.City;
            order.ShipPostalCode = customer.PostalCode;
            order.ShipCountry = customer.Country;   

            context.Orders.Add(order);
            context.SaveChanges();
            int id = order.OrderID;
            return id;
        }

        public static void addOrderDetail(int orderID, int productID, decimal? unitPrice, short quantity)
        {
            Order_Detail detail = new Order_Detail();
            detail.OrderID = orderID;
            detail.ProductID = productID;
            detail.UnitPrice = Convert.ToDecimal(unitPrice);
            detail.Quantity = quantity;
            detail.Discount = 0;

            context.Order_Details.Add(detail);
            context.SaveChanges();
        }
    }
}
