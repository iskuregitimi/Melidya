using Melidya.DAL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{   
    public  class ProductBLL
    {
        RepositoryPattern<Products> repo = new RepositoryPattern<Products>();
        public List<Products> GetProducts()
        {
          return repo.List();
        }
    }
}
