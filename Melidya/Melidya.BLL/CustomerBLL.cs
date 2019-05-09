
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

        RepositoryPattern<Customer> repo = new RepositoryPattern<Customer>();
        public List<Customer> GetCustomers()
        {
            return repo.List();
        }

        public Customer GetCustomer(string id,string pass)
        {
            return repo.Find(x => x.CustomerID == id && x.Password==pass);
        }

		public Customer GetCustomerId(string id)
		{
			return repo.Find(x => x.CustomerID == id);
		}

        public void UpdateCustomer(Customer cust)
        {

            repo.Update(cust);


        }







	}
}
