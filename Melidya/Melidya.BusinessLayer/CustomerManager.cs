using BugunNeYesem.DataAccessLayer.EntityFramework;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BusinessLayer
{
    public class CustomerManager
    {
        Repository<Customers> repo = new Repository<Customers>();

        public Customers GetCustomer(string id)
        {
            return repo.Find(x => x.CustomerID == id);
        }
    }
}
