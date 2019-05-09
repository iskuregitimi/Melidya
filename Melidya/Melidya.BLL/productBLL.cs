using Melidya.DAL;
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
        public static Products ListeyeEkle(int productİD)
        {
            return dataContext.Products.Where(x => x.ProductID == productİD).FirstOrDefault();

        }


    }
}
