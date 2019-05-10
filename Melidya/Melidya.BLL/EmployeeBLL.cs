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
        static NorthwindModel context = new NorthwindModel();
        public static Employee getEmployee(object username, object password)
        {
            return context.Employees.FirstOrDefault(x => x.FirstName == username.ToString() && x.Password == password.ToString());
        }

        public static void updateEmployee(Employee emp)
        {
            context.SaveChanges();
        }
    }
}

