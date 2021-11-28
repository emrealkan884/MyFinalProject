using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public InMemoryCategoryDal()
        {
            _categories = new List<Category> {
            new Category{CategoryName="Elektronik",CategoryId=2},
            new Category{CategoryName="Yiyecek-İçecek",CategoryId=4}
            };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete;
            categoryToDelete = _categories.SingleOrDefault(p=>p.CategoryId==category.CategoryId);
            _categories.Remove(categoryToDelete);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllByCategories(int categoryId)
        {
            return _categories.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Category category)
        {
            Category categoryToUpdate;
            categoryToUpdate = _categories.SingleOrDefault(p=>p.CategoryId==category.CategoryId);
            categoryToUpdate.CategoryName = category.CategoryName;
        }
    }
}
