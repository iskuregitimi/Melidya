using BugunNeYesem.DataAccessLayer.EntityFramework;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BusinessLayer
{
    public class SupplierManager
    {
        Repository<Suppliers> repo = new Repository<Suppliers>();

        public List<Suppliers> GetSuppliers()
        {
            return repo.List();
        }
    }
}
