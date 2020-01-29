using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected eWaiterTestContext eWaiterTestContext { get; set; }

        public RepositoryBase(eWaiterTestContext repositoryContext)
        {
            this.eWaiterTestContext = repositoryContext;
        }
        public void Create(T entity)
        {
            this.eWaiterTestContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            this.eWaiterTestContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return this.eWaiterTestContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.eWaiterTestContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            this.eWaiterTestContext.Set<T>().Update(entity);
        }
    }
}
