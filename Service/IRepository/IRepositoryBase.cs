using System;
using System.Collections.Generic;
using System.Text;

namespace Service.IRepository
{
    public interface IRepositoryBase<T>
    {
        T Get(int id);
        IList<T> ListAll();
        int Update(T entity);
        int Delete(T entity);
        T Add(T entity);
    }
}
