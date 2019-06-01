using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Interfaces
{
    public interface IRepository<T> where T:class
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> pred);
        T Find(int id);
        void Remove(T entity);
        void Edit(T entity);
    } 
}
