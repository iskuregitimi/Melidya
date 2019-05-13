using BugunNeYesem.DataAccessLayer.EntityFramework;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BusinessLayer
{
    public class ProductManager
    {
        Repository<Products> repo = new Repository<Products>();

        public List<Products> GetProducts()
        {
            return repo.List();
        }

        public List<Products> GetProducts(int id)
        {
            return repo.List(x => x.CategoryID == id);
        }

        public Products GetProduct(int id)
        {
            return repo.Find(x => x.ProductID == id);
        }

        public void AddProduct(Products proc)
        {
            repo.Insert(proc);
        }
    }
}
