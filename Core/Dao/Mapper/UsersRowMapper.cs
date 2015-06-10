using Core.Models;
using Spring.Data.Generic;
using System.Data;

namespace Core.Dao.Mapper
{
    class UsersRowMapper : IRowMapper<Users>
    {
        public Users MapRow(IDataReader dataReader, int rowNum)
        {
            Users target = new Users();

            target.ID = dataReader.GetString(dataReader.GetOrdinal("ID"));
            target.Name = dataReader.GetString(dataReader.GetOrdinal("Name"));
            target.NickName = dataReader.GetString(dataReader.GetOrdinal("NickName"));
            target.Birthday = dataReader.GetDateTime(dataReader.GetOrdinal("Birthday"));
            target.Gender = dataReader.GetString(dataReader.GetOrdinal("Gender"));
            target.Phone = dataReader.GetString(dataReader.GetOrdinal("Phone"));
            target.Address = dataReader.GetString(dataReader.GetOrdinal("Address"));
            target.Height = dataReader.GetString(dataReader.GetOrdinal("Height"));
            target.Weight = dataReader.GetString(dataReader.GetOrdinal("Weight"));

            return target;
        }

    }
}
