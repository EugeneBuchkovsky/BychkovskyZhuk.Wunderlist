using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wunderlist.BusinessLogic.Services.DTO;
using Wunderlist.DataAccess.Interfaces.Entities;
using Wunderlist.DataAccess.Interfaces.Interfaces;
using Wunderlist.DataAccess.Repositories;

namespace Wunderlist.BusinessLogic.Services.Services.UserService
{
    public class UserService : IUserService
    {
        public void Create(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public UserDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
