using Melidya.DAL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
   public class CustomerBLL
    {
        RepositoryPattern<Customers> repo = new RepositoryPattern<Customers>();
        public List<Customers> GetCustomers()
        {
            return repo.List();
        }
        public Customers GetCustomer(string customerID)
        {
            return repo.Find(x=>x.CustomerID==customerID);
        }
    }
}
