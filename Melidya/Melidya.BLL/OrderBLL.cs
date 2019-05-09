using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melidya.DAL;
using Melidya.ENTITY;


namespace Melidya.BLL
{
    public class OrderBLL
    {
        RepositoryPattern<Orders> repo = new RepositoryPattern<Orders>();
        RepositoryPattern<Order_Details> repo1 = new RepositoryPattern<Order_Details>();
        DataContext db = new DataContext();
        public List<Orders> GetOrders(string CustomerId)
        {
            return repo.List(x => x.CustomerID == CustomerId);
        }

        public List<Order_Details> GetDetails(int OrderId)
        {
            return repo1.List(x => x.OrderID == OrderId);
        }

        public Orders GetOrder(int OrderId)
        {
            return repo.Find(x => x.OrderID == OrderId);
        }

        public int AddOrder(Customers Customer)
        {
            Orders order = new Orders();
            order.CustomerID = Customer.CustomerID;
            order.EmployeeID = 8;
            order.OrderDate = DateTime.Now;
            order.Freight = (decimal)6.90;
            db.Orders.Add(order);
            db.SaveChanges();
            return order.OrderID;
        }

        public void AddOrderDetail(Products product,int quantity,int orderID)
        {
            Order_Details orderdetail = new Order_Details();
            orderdetail.OrderID = orderID;
            orderdetail.ProductID = product.ProductID;
            orderdetail.UnitPrice = (decimal)product.UnitPrice;
            orderdetail.Quantity = Convert.ToInt16(quantity);
            orderdetail.Discount = 0;
            db.Order_Details.Add(orderdetail);
            db.SaveChanges();
        }
    }
}
