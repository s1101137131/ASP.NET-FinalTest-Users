using Core.Dao;
using Core.Models;
using System.Collections.Generic;

namespace Core.Services
{

    /// <summary>
    ///     員工資料維護的 Service.
    /// </summary>
    public interface IUsersService
    {

        /// <summary>
        ///     新增員工資料.
        /// </summary>
        /// <param name="users">
        ///     員工資料.
        /// </param>
        void AddUsers(Users users);

        /// <summary>
        ///     修改員工資料.
        /// </summary>
        /// <param name="users">
        ///     員工資料.
        /// </param>
        void UpdateUsers(Users users);

        /// <summary>
        ///     刪除員工資料.
        /// </summary>
        /// <param name="users">
        ///     員工資料.
        /// </param>
        void DeleteUsers(Users users);

        /// <summary>
        ///     取得所有員工資料.
        /// </summary>
        /// <returns>
        ///     所有員工資料.
        /// </returns>
        IList<Users> GetAllUserss();

        /// <summary>
        ///     依據 ID 取得員工資料.
        /// </summary>
        /// <param name="id">
        ///     員工 Id.
        /// </param>
        /// <returns>
        ///     該員工資料.
        /// </returns>
        Users GetUsersById(string id);

    }
}
