using Melidya.DAL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
   public class OrderBLL
    {
        RepositoryPattern<Order> repo = new RepositoryPattern<Order>();
        RepositoryPattern<Order_Detail> repos = new RepositoryPattern<Order_Detail>();

        public List<Order> GetOrders(string id)
        {
            return repo.List(x => x.CustomerID == id);
        }

        public List<Order> GetOrders()
        {
            return repo.List();
        }

        public Order GetOrder(int Id)
        {
            return repo.Find(x=>x.OrderID==Id);
        }

        public Order_Detail  GetOrderDetail(int orderid)
        {
            return repos.Find(x => x.OrderID ==orderid);
           
        }

        public List<Order_Detail> GetOrdersDetail(int Id)
        {
            return repos.List(x=>x.OrderID==Id);

        }

    }
}
