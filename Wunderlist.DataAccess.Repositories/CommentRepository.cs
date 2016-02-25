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
    public class CommentRepository : IRepository<Comment>
    {
        private WunderlistContext db;

        public CommentRepository(WunderlistContext context)
        {
            this.db = context;
        }

        public void Create(Comment item) => db.Comments.Add(item);

        public void Delete(int id)
        {
            var comment = db.Comments.Find(id);
            if(comment!=null)
                db.Comments.Remove(comment);
        }

        public Comment Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetAll(int id) => db.Comments.Where(c => c.TodoItemId == id);

        public void Update(Comment item)
        {
            throw new NotImplementedException();
        }
    }
}
