using BugunNeYesem.DataAccessLayer.EntityFramework;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BusinessLayer
{
    public class EmployeeManager
    {
        Repository<Employees> repo = new Repository<Employees>();

        public Employees GetEmployee(string postalcode)
        {
            return repo.Find(x => x.PostalCode == postalcode);
        }

        public bool Control(Employees emp,string type)
        {
            foreach (EmpRole item in emp.EmpRole)
            {
                if (item.Roles.Type == type)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
