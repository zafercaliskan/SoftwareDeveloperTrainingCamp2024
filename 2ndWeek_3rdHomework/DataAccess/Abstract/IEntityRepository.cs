﻿using _2ndWeek_3rdHomework.Entities.Abstract;
using System.Linq.Expressions;


namespace _2ndWeek_3rdHomework.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
