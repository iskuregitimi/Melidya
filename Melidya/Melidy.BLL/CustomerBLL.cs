using Melidya.DAL;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidy.BLL
{
    public class CustomerBLL
    {


        static Datacontext db = new Datacontext();
     
        public Customers GetCustomer(string Id,string pass)
        {
            return db.Customers.FirstOrDefault(x => x.CustomerID == Id && x.Password == pass);
        }

        public Customers GetCustomersID(string CustomerID)
        {
            return db.Customers.FirstOrDefault(x => x.CustomerID == CustomerID);
        }
        public void Update(Customers cust)
        {
             db.SaveChanges();


        }
      

    }
}
