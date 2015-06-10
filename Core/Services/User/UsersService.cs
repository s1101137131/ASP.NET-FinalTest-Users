using Core.Dao;
using Core.Dao.Impl;
using Core.Models;
using System.Collections.Generic;

namespace Core.Services.User
{
    public class UsersService : IUsersService
    {

        public IUsersDao UsersDao { get; set; }

        public void AddUsers(Users users)
        {
            UsersDao.AddUsers(users);
        }

        public void UpdateUsers(Users users)
        {
            UsersDao.UpdateUsers(users);
        }

        public void DeleteUsers(Users users)
        {
            users = UsersDao.GetUsersById(users.ID);

            if (users != null)
            {
                UsersDao.DeleteUsers(users);
            }
        }

        public IList<Users> GetAllUserss()
        {
            return UsersDao.GetAllUserss();
        }

        public Users GetUsersById(string id)
        {
            return UsersDao.GetUsersById(id);
        }

    }

}
