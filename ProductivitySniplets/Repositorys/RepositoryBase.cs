using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repositorys
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public DataContext DataContext { get; set; }

        public RepositoryBase(DataContext context)
        {
            DataContext = context;
        }

        public void Create(T entity)
        {
            DataContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            DataContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return DataContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return DataContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            DataContext.Set<T>().Update(entity);
        }
    }
}
