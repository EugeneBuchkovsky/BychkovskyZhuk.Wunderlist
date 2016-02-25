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
    public class UserRepository : IRepository<User>
    {
        private WunderlistContext db;

        public UserRepository(WunderlistContext context)
        {
            this.db = context;
        }

        public void Create(User item) => db.Users.Add(item);

        public void Delete(int id)
        {
            var user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);
        }

        public User Get(int id) => db.Users.Find(id);

        public IEnumerable<User> GetAll(int id) => db.Users.Where(u => u.Id == id);

        public void Update(User item)
        {
            var updateUser = db.Users.FirstOrDefault(u => u.Id == item.Id);
            updateUser.Name = item.Name;
            updateUser.Email = item.Email;
            updateUser.Password = item.Password;
            updateUser.PhotoPath = item.PhotoPath;
            updateUser.BackgroundImagePath = item.BackgroundImagePath;
            db.Entry(updateUser).State = EntityState.Modified;
        }
    }
}
