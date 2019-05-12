using Melidya_Reloaded.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya_Reloaded.BLL
{
    public class OrderBLL
    {
        public static Melidya_ReloadedDbContext db = new Melidya_ReloadedDbContext();
        public static List<Order> getallorders(string Customerid)
        {
            var orders = db.Orders.Where(o => o.CustomerID == Customerid);
            return orders.ToList();
        }

        public static List<OrderDetail> getorderdetails(int OrderID)
        {
            //var orderdetail = db.OrderDetails.Where(od => od.OrderID == OrderID).ToList();
            var orderdetail = from od in db.OrderDetails.AsEnumerable()
                              join p in db.Products.AsEnumerable() on od.ProductID equals p.ProductID
                              where od.OrderID == OrderID
                              select new OrderDetail
                              {
                                  ProductName = p.ProductName,
                                  ProductID = od.ProductID,
                                  UnitPrice = od.UnitPrice,
                                  Quantity = od.Quantity,
                                  Discount = od.Discount
                              };

            return orderdetail.ToList();
        }
    }
}
