using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public InMemoryCategoryDal()
        {
            _categories = new List<Category> {
            new Category{CategoryName="Elektronik",CatogoryId=2},
            new Category{CategoryName="Yiyecek-İçecek",CatogoryId=4}
            };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete;
            categoryToDelete = _categories.SingleOrDefault(p=>p.CatogoryId==category.CatogoryId);
            _categories.Remove(categoryToDelete);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public List<Category> GetAllByCategories(int categoryId)
        {
            return _categories.Where(p => p.CatogoryId == categoryId).ToList();
        }

        public void Update(Category category)
        {
            Category categoryToUpdate;
            categoryToUpdate = _categories.SingleOrDefault(p=>p.CatogoryId==category.CatogoryId);
            categoryToUpdate.CategoryName = category.CategoryName;
        }
    }
}
