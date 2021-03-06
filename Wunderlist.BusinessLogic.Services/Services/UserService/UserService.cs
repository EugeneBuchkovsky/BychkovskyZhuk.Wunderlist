﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wunderlist.BusinessLogic.Services.DTO;
using Wunderlist.DataAccess.Interfaces.Entities;
using Wunderlist.DataAccess.Interfaces.Interfaces;
using Wunderlist.DataAccess.Repositories;
using AutoMapper;

namespace Wunderlist.BusinessLogic.Services.Services.UserService
{
    public class UserService : IUserService
    {
        IUnitOfWork Database { get; set; }

        public UserService(IUnitOfWork uow)
        {
            this.Database = uow;
        }

        public void Create(UserDTO user)
        {
            if (user == null)
                throw new ArgumentNullException();
            Mapper.CreateMap<UserDTO, User>();
            Database.Users.Create(Mapper.Map<UserDTO, User>(user));
            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Users.Delete(id);
            Database.Save();
        }

        public UserDTO Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException();
            var user = Database.Users.Get(id.Value);
            if (user == null)
                throw new ArgumentNullException();
            Mapper.CreateMap<User, UserDTO>();
            return Mapper.Map<User, UserDTO>(user);
        }

        public IEnumerable<UserDTO> GetAll()
        {
            Mapper.CreateMap<User, UserDTO>();
            return Mapper.Map<IEnumerable<User>, List<UserDTO>>(Database.Users.GetAll());
        }

        public void Update(UserDTO user)
        {
            Mapper.CreateMap<UserDTO, User>();
            Database.Users.Update(Mapper.Map<UserDTO, User>(user));
            Database.Save();
        }

        public UserDTO GetByEmail(string email)
        {
            if (email == null)
                throw new ArgumentNullException();

            var user = Database.Users.GetAll().FirstOrDefault(u => u.Email == email);
            //if (user == null)
            //    throw new ArgumentNullException("No user with such email");
            Mapper.CreateMap<User, UserDTO>();
            return Mapper.Map<User, UserDTO>(user);
        }
    }
}
