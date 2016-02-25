using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wunderlist.DataAccess.Interfaces.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(int id);

        T Get(int id);

        void Create(T item);

        void Update(T item);

        void Delete(int id);
    }
}
