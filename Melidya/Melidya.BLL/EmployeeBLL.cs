using Melidya.DAL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
  public  class EmployeeBLL
    {
        RepositoryPattern<Employees> repo = new RepositoryPattern<Employees>();
        public List<Employees> GetEmployees()
        {
           return repo.List();
        }

        public Employees GetEmployee(string lastname)
        {
            return repo.Find(x => x.LastName == lastname);
        }
    }
}
