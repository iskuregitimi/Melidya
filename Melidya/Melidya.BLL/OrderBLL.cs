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
        DataContext dataContext = new DataContext();

        public List<Orders> GetOrders(string username)
        {
            return dataContext.Orders.Where(x => x.CustomerID == username).ToList();
        }

        public List<Order_Details> GetOrderDetails(int orderId)
        {
            return dataContext.Order_Details.Where(x=> x.OrderID == orderId).ToList();
        }
    }
}
