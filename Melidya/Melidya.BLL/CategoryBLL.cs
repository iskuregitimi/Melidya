using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BLL
{
    public static class CategoryBLL
    {
        static DataContext datacontext = new DataContext();

        public static List<Categories> getCategories()
        {
            return datacontext.Categories.ToList();
        }
        public static void InsertCategories(Categories categories)
        {

            datacontext.Categories.Add(categories);
            datacontext.SaveChanges();
        }

    }
}
