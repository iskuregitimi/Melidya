using BugunNeYesem.DataAccessLayer.EntityFramework;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BusinessLayer
{
    public class OrderManager
    {
        Repository<Orders> repo = new Repository<Orders>();

        public List<Orders> GetOrders(string id)
        {
            return repo.List(x => x.CustomerID == id).ToList();
        }

        public int AddOrder(Orders order)
        {
            repo.Insert(order);
            return order.OrderID;
        }

        public Orders GetOrder(int id)
        {
            return repo.Find(x => x.OrderID == id);
        }

        public void Update(Orders order)
        {
            repo.Update(order);
        }
    }
}
