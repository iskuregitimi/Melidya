using Melidya.DAL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
    public class ProductBLL
    {
        RepositoryPattern<Product> repo = new RepositoryPattern<Product>();

        public List<Product> GetProducts()
        {
            return repo.List();
        }

        public Product GetProduct(int id)
        {
            return repo.Find(x=> x.ProductID==id);
        }


       

    }
}
