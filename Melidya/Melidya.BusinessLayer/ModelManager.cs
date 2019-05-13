using BugunNeYesem.DataAccessLayer.EntityFramework;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BusinessLayer
{
    public class ModelManager
    {
        Repository<Orders> repo_order = new Repository<Orders>();
        Repository<Order_Details> repo_detail = new Repository<Order_Details>();
        Repository<Customers> repo_cust = new Repository<Customers>();

        public IQueryable<OrderModel> GetOrderModels()
        {
            var orderModel = from cust in repo_cust.GetAll()
                    join order in repo_order.GetAll() on cust.CustomerID equals order.CustomerID
                    join detail in repo_detail.GetAll() on order.OrderID equals detail.OrderID
                    group detail by new { cust.ContactName, order.OrderID, order.OrderDate, order.ShipAddress, order.Status } into g
                    select new OrderModel
                    {
                        ContactName = g.Key.ContactName,
                        OrderID = g.Key.OrderID,
                        OrderDate = g.Key.OrderDate,
                        ShipAddress = g.Key.ShipAddress,
                        TotalAmount = g.Sum(x => x.UnitPrice * x.Quantity),
                        Status = g.Key.Status
                    };
            return orderModel;
        }
    }
}
