using Melidya_Reloaded.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya_Reloaded.BLL
{
    public class ProductBLL
    {
        public static Melidya_ReloadedDbContext db = new Melidya_ReloadedDbContext();
        public static List<Product> getproducts()
        {
            return(db.Products.ToList());
        }
    }
}
