using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
    public static class ProductBLL
    {
        static NorthwindModel context = new NorthwindModel();
        public static List<Product> GetProducts()
        {
            return context.Products.ToList();
        }
    }
}
