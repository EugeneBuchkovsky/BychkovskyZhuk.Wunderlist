using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wunderlist.DataAccess.Interfaces.EF;
using Wunderlist.DataAccess.Interfaces.Entities;
using Wunderlist.DataAccess.Interfaces.Interfaces;
using System.Data.Entity;

namespace Wunderlist.DataAccess.Repositories
{
    public class SubscriberRepository : IRepository<Subscriber>
    {
        private WunderlistContext db;

        public SubscriberRepository(WunderlistContext context)
        {
            this.db = context;
        }

        public void Create(Subscriber item) => db.Subscribers.Add(item);

        public void Delete(int id)
        {
            var subscriber = db.Subscribers.Find(id);
            if (subscriber != null)
                db.Subscribers.Remove(subscriber);
        }

        public Subscriber Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subscriber> GetAll() => db.Subscribers.ToList();

        public IEnumerable<Subscriber> GetAll(int? id)
        {
            throw new NotImplementedException();
        }

        public void Update(Subscriber item)
        {
            throw new NotImplementedException();
        }
    }
}
