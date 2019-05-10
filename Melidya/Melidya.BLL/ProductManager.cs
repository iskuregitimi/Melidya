using Melidya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
   public class ProductManager
    {
        MelidyaContextModel dc = new MelidyaContextModel();
        public List<Product> GetProducts()
        {
           return  dc.Products.ToList();
        }
    }
}
