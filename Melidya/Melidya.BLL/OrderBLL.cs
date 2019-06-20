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

        public List<Order> GetOrderswithcustomer(string id)
        {
            return repo.List(x => x.CustomerID == id);
        }

        public Order_Detail  GetOrder_Detail(int orderid)
        {
            return repos.Find(x => x.OrderID ==orderid);
           
        }
        public List<Order> GetOrders()
        {
            return repo.List();
        }

        public void Delete(Order ord)
        {
            repo.Delete(ord);
        }
    }
}
