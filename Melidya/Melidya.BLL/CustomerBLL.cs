using Melidya.DAL;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
    public class CustomerBLL
    {
        Repository<Customers> repo = new Repository<Customers>();

        public List<Customers> GetCustomers()
        {
            return repo.List();
        }

        public Customers GetCustomer(string id,string password)
        {
            return repo.Find(x => x.CustomerID == id && x.Password==password);
        }
    }
}
