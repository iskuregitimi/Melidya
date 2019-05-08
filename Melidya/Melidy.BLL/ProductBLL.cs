using Melidya.DAL;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidy.BLL
{
    public class ProductBLL
    {
        Datacontext db = new Datacontext();
        
        public List<Products> GetProduct()
        {
            return db.Products.ToList();
        }

    }
}
