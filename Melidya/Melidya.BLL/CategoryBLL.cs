using Melidya.DAL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Melidya.BLL
{
   public class CategoryBLL
    {
        RepositoryPattern<Categories> repo = new RepositoryPattern<Categories>();
        DataContext db = new DataContext();
        public List<Categories> GetCategories()
        {
            return repo.List();
        }

        public void AddCategory(Categories category)
        {
            Categories cate = new Categories();
            cate.CategoryID = category.CategoryID;
            cate.CategoryName = category.CategoryName;
            cate.Description = category.Description;         
            db.Categories.Add(cate);
            db.SaveChanges();
        
        }

        public void Delete(int id)
        {
            List<Products> product = db.Products.Where(x => x.CategoryID == id).ToList();
            foreach (Products item in product)
            {
                db.Products.Remove(item);
            }
           Categories category = db.Categories.Where(x => x.CategoryID == id).FirstOrDefault();      
            db.Categories.Remove(category);
            db.SaveChanges();
        }

        public Categories GetCategory(int id)
        {
            return db.Categories.FirstOrDefault(x => x.CategoryID == id);
        }
    }
}
