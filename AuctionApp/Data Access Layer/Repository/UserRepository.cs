using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer.Models;
using System.Linq.Expressions;

namespace Data_Access_Layer.Repository
{
    public class UserRepository : IRepository<User>
    {
        private AppContext db;
        public UserRepository()
        {
            db = new AppContext();
        }

        public void Create(User item)
        {
            db.Users.Add(item);
        }

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if(user != null)
            {
                db.Users.Remove(user);
            }
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public IEnumerable<User> GetAll(Expression<Func<User, bool>> pred)
        {
            return db.Users.AsNoTracking().Where(pred).AsEnumerable();
        }

        public User Read(int id)
        {
            return db.Users.Find(id);
        }

        public void Update(User item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
