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
        RepositoryPattern<Products> repo = new RepositoryPattern<Products>();
        DataContext db = new DataContext();
        public List<Products> GetProducts()
        {
            return repo.List();
        }

        public Products GetProduct(int id)
        {
            return repo.Find(x => x.ProductID == id);
        }

        public void AddProduct(Products product, int categoryId)
        {
            Products products = new Products();
            products.CategoryID = categoryId;
            products.ProductID = product.ProductID;
            products.UnitPrice = (decimal)product.UnitPrice;
            products.ProductName = product.ProductName;
            products.QuantityPerUnit = product.QuantityPerUnit;
            products.SupplierID = 2;
            products.Discontinued = false;
            db.Products.Add(products);
            db.SaveChanges();
        }

    }
}

