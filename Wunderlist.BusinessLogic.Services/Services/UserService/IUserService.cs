using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wunderlist.BusinessLogic.Services.DTO;

namespace Wunderlist.BusinessLogic.Services.Services.UserService
{
    public interface IUserService
    {
        void Create(UserDTO user);
        UserDTO Get(int id);
        IEnumerable<UserDTO> GetAll(int id);
        void Update(UserDTO user);
        void Delete(int id);
    }
}
