using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;

namespace Data_Access_Layer.Repository
{
    public class ProfileRepository : IRepository<Profile>
    {
        private AppContext db;
        public ProfileRepository()
        {
            db = new AppContext();
        }

        public void Create(Profile item)
        {
            db.Profiles.Add(item);
        }

        public void Delete(int id)
        {
            Profile profile = db.Profiles.Find(id);
            if(profile != null)
            {
                db.Profiles.Remove(profile);
            }
        }

        public IEnumerable<Profile> GetAll()
        {
            return db.Profiles;
        }

        public IEnumerable<Profile> GetAll(Expression<Func<Profile, bool>> pred)
        {
            return db.Profiles.AsNoTracking().Where(pred).AsEnumerable();
        }

        public Profile Read(int id)
        {
            return db.Profiles.Find(id);
        }

        public void Update(Profile item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
