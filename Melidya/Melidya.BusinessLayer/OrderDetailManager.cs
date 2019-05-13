using BugunNeYesem.DataAccessLayer.EntityFramework;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BusinessLayer
{
    public class OrderDetailManager
    {
        Repository<Order_Details> repo = new Repository<Order_Details>();

        public List<Order_Details> GetOrderDetails(int id)
        {
            return repo.List(x => x.OrderID == id);
        }

        public void AddOrderDetail(Order_Details order_Details)
        {
            repo.Insert(order_Details);
        }
    }
}
