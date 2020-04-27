﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EMS.SqlRepository.DbRepository
{
    public interface IEmsRepository<T> where T:class
    {
        Task<T> GetById(int id);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);

        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Remove(T entity);

        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);

        Task<IQueryable<T>> GetByCondition(Expression<Func<T, bool>> predicate);
        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<T, bool>> predicate);
        Task InsertBulk(List<T> entities);
    }
}
