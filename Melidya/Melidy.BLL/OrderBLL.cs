using Melidya.DAL;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidy.BLL
{
    public class OrderBLL
    {

        static Datacontext db = new Datacontext();
        public List<Orders> GetOrders(string Id)
        {
            return db.Orders.Where(x => x.CustomerID == Id).ToList();
        }
        public List<Order_Details> Getorderdetails(int OrderID)
        {
            return db.Order_Details.Where(x => x.OrderID == OrderID).ToList();
        }

        
    }
}
