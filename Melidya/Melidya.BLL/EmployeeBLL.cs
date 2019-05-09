using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
   public static class EmployeeBLL
    {

        static DataContext dataContext = new DataContext();
        public static Employees GetEmployees(string firstName)
        {
            return dataContext.Employees.Where(x => x.FirstName == firstName).FirstOrDefault();


        }
    }
}
