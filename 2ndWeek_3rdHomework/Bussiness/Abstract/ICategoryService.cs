using _2ndWeek_3rdHomework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2ndWeek_3rdHomework.Bussiness.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        List<Category> GetList();
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
