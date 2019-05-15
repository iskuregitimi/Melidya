using Melidya.DAL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
   public  class SupplierBLL
    {
        RepositoryPattern<Suppliers> repo = new RepositoryPattern<Suppliers>();

        public List<Suppliers> GetSuppliers()
        {
            return repo.List();

        }

    }
}
