using Core.Models;
using Core.Services;
using Core.Services.User;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using FinalHomework.Controllers;

namespace FinalHomework.Controllers
{
    public class UsersController : ApiController
    {
        public IUsersService UsersService { get; set; }

        [HttpPost]
        public Users AddUsers(Users users)
        {
            CheckUsersIsNotNullThrowException(users);

            try
            {
                UsersService.AddUsers(users);
                return UsersService.GetUsersById(users.ID);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [HttpPut]
        public Users UpdateUsers(Users users)
        {
            CheckUsersIsNullThrowException(users);

            try
            {
                UsersService.UpdateUsers(users);
                return UsersService.GetUsersById(users.ID);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [HttpDelete]
        public void DeleteUsers(Users users)
        {
            try
            {
                UsersService.DeleteUsers(users);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        public IList<Users> GetAllUserss()
        {
            return UsersService.GetAllUserss();
        }

        [HttpGet]
        [ActionName("byId")]
        public Users GetUsersById(string id)
        {
            var users = UsersService.GetUsersById(id);

            if (users == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return users;
        }

        /// <summary>
        ///     檢查員工資料是否存在，如果不存在則拋出錯誤.
        /// </summary>
        /// <param name="users">
        ///     員工資料.
        /// </param>
        private void CheckUsersIsNullThrowException(Users users)
        {
            Users dbUsers = UsersService.GetUsersById(users.ID);

            if (dbUsers == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        ///     檢查員工資料是否存在，如果存在則拋出錯誤.
        /// </summary>
        /// <param name="users">
        ///     員工資料.
        /// </param>
        private void CheckUsersIsNotNullThrowException(Users users)
        {
            Users dbUsers = UsersService.GetUsersById(users.ID);

            if (dbUsers != null)
            {
                throw new HttpResponseException(HttpStatusCode.Conflict);
            }
        }
    }
}
