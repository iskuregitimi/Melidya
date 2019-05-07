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

        public List<Orders> GetOrders(string CustomerId)
        {
            return repo.List(x=>x.CustomerID==CustomerId);
        }

        public List<Order_Details> GetDetails(int OrderId)
        {
            return repo1.List(x => x.OrderID == OrderId);
        }

        public Orders GetOrder(int OrderId)
        {
            return repo.Find(x => x.OrderID == OrderId);
        }

    }  
}
