using _2ndWeek_3rdHomework.DataAccess.Abstract;
using _2ndWeek_3rdHomework.Entities.Concrete;
using System.Collections.Generic;


namespace _2ndWeek_3rdHomework.DataAccess.Concrete.InMemory
{
    public class ImCategoryDal
    {
        List<Category> _categories = new List<Category>();
        public ImCategoryDal()
        {
            _categories = new List<Category>();
        }
        public void Add(Category entity)
        {
            _categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            var found = _categories.FirstOrDefault(c => c.Id == entity.Id);
            if (found != null)
            {
                _categories.Remove(found);
            }
        }

        public List<Category> Get(Func<Category, bool> filter = null)
        {
            if (filter == null)
            {
                return _categories;
            }
            else
            {
                return _categories.Where(filter).ToList();
            }
        }

        public List<Category> GetList(Func<Category, bool> filter)
        {
            return _categories.Where(filter).ToList();
        }

        public void Update(Category entity)
        {
            var category = _categories.FirstOrDefault(c => c.Id == entity.Id);
            if (category != null)
            {
                category.CategoryName = entity.CategoryName;
            }
        }
    }
}
