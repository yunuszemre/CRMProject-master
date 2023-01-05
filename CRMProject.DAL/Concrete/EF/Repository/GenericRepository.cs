using CRMProject.DAL.Abstract;
using CRMProject.DAL.Concrete.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.DAL.Concrete.EF.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private CRMContext _dbContext;
        private DbSet<T> _dbSet;

        public GenericRepository(CRMContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> Select(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null )
            {
               return _dbSet.Where(predicate);
               
            }
            else
            {
                return _dbSet;
            }
                
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
