﻿using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
   public static class productBLL
    {
        static DataContext dataContext = new DataContext();

        public static List<Products> GetProducts()
        {
            return dataContext.Products.ToList();
        }
        public static Products ListeyeEkle(int productID)
        {
            return dataContext.Products.FirstOrDefault(x => x.ProductID == productID);

        }

        public static void addProducts(Products products)
        {
            dataContext.Products.Add(products);
            dataContext.SaveChanges();

        }
        public static void deleteProduct(Products products)
        {
            dataContext.Products.Remove(products);
            dataContext.SaveChanges();
        }


    }
}
