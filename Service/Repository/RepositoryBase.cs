using DAO;
using Service.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T: class
    {
        protected NotFakeContext context;
        public RepositoryBase(NotFakeContext notFakeContext)
        {
            context = notFakeContext;
        }
        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }
        public IList<T> ListAll()
        {
            return context.Set<T>().ToList();
        }
        public int Update(T entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return context.SaveChanges();
        }

        public int Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            return context.SaveChanges();
        }
    }
}
