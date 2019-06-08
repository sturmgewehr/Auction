using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;

namespace Data_Access_Layer.Repository
{
    public class CreditCardRepository : IRepository<CreditCard>
    {
        private AppContext db;

        public CreditCardRepository()
        {
            db = new AppContext();
        }

        public void Create(CreditCard creditCard)
        {
            db.CreditCards.Add(creditCard);
        }

        public void Delete(int id)
        {
            CreditCard card = db.CreditCards.Find(id);
            if(card != null)
            {
                db.CreditCards.Remove(card);
            }
        }

        public IEnumerable<CreditCard> GetAll()
        {
            return db.CreditCards;
        }

        public IEnumerable<CreditCard> GetAll(Expression<Func<CreditCard, bool>> pred)
        {
            return db.CreditCards.AsNoTracking().Where(pred).AsEnumerable();
        }

        public CreditCard Read(int id)
        {
            return db.CreditCards.Find(id);
        }

        public void Update(CreditCard creditCard)
        {
            db.Entry(creditCard).State = EntityState.Modified;
        }
    }
}
