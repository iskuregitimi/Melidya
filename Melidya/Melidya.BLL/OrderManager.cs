using Melidya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
    public class OrderManager
    {
        MelidyaContextModel dc = new MelidyaContextModel();
        public List<Order> GetOrders(string customerid)
        {
            return dc.Orders.Where(x => x.CustomerID == customerid).ToList();
        }

        public List<Order_Detail> GetOrderDetails(int orderid)
        {
            return dc.Order_Details.Where(x => x.OrderID == orderid).ToList();
        }
    }
}
