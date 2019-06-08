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
    public class AuctionSlotRepository : IRepository<AuctionLot>
    {
        private AppContext db;
        public AuctionSlotRepository()
        {
            db = new AppContext();
        }

        public void Create(AuctionLot item)
        {
            db.AuctionLots.Add(item);
        }

        public void Delete(int id)
        {
            AuctionLot lot = db.AuctionLots.Find(id);
            if(lot != null)
            {
                db.AuctionLots.Remove(lot);
            }
        }

        public IEnumerable<AuctionLot> GetAll()
        {
            return db.AuctionLots;
        }

        public IEnumerable<AuctionLot> GetAll(Expression<Func<AuctionLot, bool>> pred)
        {
            return db.AuctionLots.AsNoTracking().Where(pred).AsEnumerable();
        }

        public AuctionLot Read(int id)
        {
            return db.AuctionLots.Find(id);
        }

        public void Update(AuctionLot item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
