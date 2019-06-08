using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer.Models;
using Object = Data_Access_Layer.Models.Object;
using System.Linq.Expressions;

namespace Data_Access_Layer.Repository
{
    public class ObjectRepository : IRepository<Object>
    {
        private AppContext db;
        public ObjectRepository()
        {
            db = new AppContext();
        }

        public void Create(Object item)
        {
            db.Objects.Add(item);
        }

        public void Delete(int id)
        {
            Object @object = db.Objects.Find(id);
            if(@object != null)
            {
                db.Objects.Remove(@object);
            }
        }

        public IEnumerable<Object> GetAll()
        {
            return db.Objects;
        }

        public IEnumerable<Object> GetAll(Expression<Func<Object, bool>> pred)
        {
            return db.Objects.AsNoTracking().Where(pred).AsEnumerable();
        }

        public Object Read(int id)
        {
            return db.Objects.Find(id);
        }

        public void Update(Object item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
