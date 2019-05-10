using Melidya.DAL;
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
        Repository<Orders> repo = new Repository<Orders>();
        Repository<Order_Details> repos = new Repository<Order_Details>();

        public List<Orders> GetOrders()
        {
            return repo.List();
        }

        public List<Orders> GetOrders(string id)
        {
            return repo.List(x => x.CustomerID == id);
        }

        public List<Order_Details> GetOrder_Details(int id)
        {
            return repos.List(x => x.OrderID == id);
        }

    }
}
