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
        DataContext dataContext = new DataContext();
        
        public List<Customers> GetCustomers()
        {
            return dataContext.Customers.ToList();
        }
    }
}
