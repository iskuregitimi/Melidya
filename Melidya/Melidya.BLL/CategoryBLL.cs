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
        static NorthwindModel context = new NorthwindModel();
        public static List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        public static void addCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }
    }
}
