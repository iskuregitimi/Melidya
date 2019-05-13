using BugunNeYesem.DataAccessLayer.EntityFramework;
using Melidya.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.BusinessLayer
{
    public class CategoryManager
    {
        Repository<Categories> repo = new Repository<Categories>();

        public List<Categories> GetCategories()
        {
            return repo.List();
        }

        public void AddCategory(Categories category)
        {
            repo.Insert(category);
        }
    }
}
