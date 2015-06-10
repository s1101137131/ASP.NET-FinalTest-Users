using Core.Models;
using System;
using System.Collections.Generic;

namespace Core.Dao
{
    public interface IUsersDao
    {

        void AddUsers(Users users);

        void UpdateUsers(Users users);

        void DeleteUsers(Users users);

        IList<Users> GetAllUserss();

        Users GetUsersById(string id);

    }
}
