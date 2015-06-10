using Core.Dao.Mapper;
using Core.Models;
using Core.Dao.Base;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace Core.Dao.Impl
{
    public class UsersDao : GenericDao<Users>, IUsersDao
    {

        override protected IRowMapper<Users> GetRowMapper()
        {
            return new UsersRowMapper();
        }

        public void AddUsers(Users users)
        {
            string command = @"INSERT INTO Users (ID, Name, NickName, Birthday, Gender, Phone, Address, Height, Weight) VALUES (@ID, @Name, @NickName, @Birthday, @Gender, @Phone, @Address, @Height, @Weight);";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("ID", DbType.String).Value = users.ID;
            parameters.Add("Name", DbType.String).Value = users.Name;
            parameters.Add("NickName", DbType.String).Value = users.NickName;
            parameters.Add("Birthday", DbType.DateTime).Value = users.Birthday;
            parameters.Add("Gender", DbType.String).Value = users.Gender;
            parameters.Add("Phone", DbType.String).Value = users.Phone;
            parameters.Add("Address", DbType.String).Value = users.Address;
            parameters.Add("Height", DbType.String).Value = users.Height;
            parameters.Add("Weight", DbType.String).Value = users.Weight;
            

            ExecuteNonQuery(command, parameters);
        }

        public void UpdateUsers(Users users)
        {
            string command = @"UPDATE Users SET Name = @Name, NickName = @NickName, Birthday = @Birthday, Gender = @Gender, Phone = @Phone, Address = @Address, Height = @Height, Weight = @Weight WHERE ID = @ID;";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("ID", DbType.String).Value = users.ID;
            parameters.Add("Name", DbType.String).Value = users.Name;
            parameters.Add("NickName", DbType.String).Value = users.NickName;
            parameters.Add("Birthday", DbType.DateTime).Value = users.Birthday;
            parameters.Add("Gender", DbType.String).Value = users.Gender;
            parameters.Add("Phone", DbType.String).Value = users.Phone;
            parameters.Add("Address", DbType.String).Value = users.Address;
            parameters.Add("Height", DbType.String).Value = users.Height;
            parameters.Add("Weight", DbType.String).Value = users.Weight;

            ExecuteNonQuery(command, parameters);
        }

        public void DeleteUsers(Users users)
        {
            string command = @"DELETE FROM Users WHERE ID = @ID";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("ID", DbType.String).Value = users.ID;

            ExecuteNonQuery(command, parameters);
        }

        public IList<Users> GetAllUserss()
        {
            string command = @"SELECT * FROM Users ORDER BY ID ASC";
            IList<Users> userss = ExecuteQueryWithRowMapper(command);
            return userss;
        }

        public Users GetUsersById(string id)
        {
            string command = @"SELECT * FROM Users WHERE ID = @ID";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("ID", DbType.String).Value = id;

            IList<Users> userss = ExecuteQueryWithRowMapper(command, parameters);
            if (userss.Count > 0)
            {
                return userss[0];
            }

            return null;
        }

    }
}
