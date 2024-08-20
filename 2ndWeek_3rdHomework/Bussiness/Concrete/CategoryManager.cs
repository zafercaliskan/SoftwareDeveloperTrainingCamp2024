using _2ndWeek_3rdHomework.Bussiness.Abstract;
using _2ndWeek_3rdHomework.DataAccess.Abstract;
using _2ndWeek_3rdHomework.Entities.Concrete;

namespace _2ndWeek_3rdHomework.Bussiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.Id == id);
        }

        public List<Category> GetList()
        {
            return (List<Category>)_categoryDal.GetList();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
