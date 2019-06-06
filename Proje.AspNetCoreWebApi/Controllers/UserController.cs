using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje.Business.Logic;
using Proje.DataAccess.Context;
using Proje.Entity.Model;
using Proje.Interface;
using Newtonsoft.Json;
using Proje.Business.Helper;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Caching.Distributed;
using StackExchange.Redis;
using System.Collections;

namespace Proje.AspNetCoreWebApi.Controllers
{

    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        #region Cache Injection
        //private readonly IDistributedCache _distributedCache;
        //public UserController(IDistributedCache distributedCache)
        //{
        //    _distributedCache = distributedCache;
        //}

        #endregion
        #region service
        private readonly IGenericService<Password> passwordService;
        private readonly IGenericService<User> UserService;
        private readonly IGenericService<Role> roleService;
        public UserController(IGenericService<User> userService, IGenericService<Role> roleservice, IGenericService<Password> passwordservice)
        {

            passwordService = passwordservice;
            UserService = userService;
            roleService = roleservice;
        }
        #endregion
        [HttpGet]
        [Route("~/User/GetAll")]
        public IActionResult GetAll()
        {

            const string cacheKey = "users";
            var cachedItem = RedisCache.Instance.Retrieve(cacheKey);
            if (!string.IsNullOrEmpty(cachedItem))
            {
                var json = JsonConvert.SerializeObject(cachedItem);
                return Ok(json);
            }
            else
            {
                var result = (from u in UserService.GetAll()
                              join r in roleService.GetAll()
                              on u.UserID equals r.UserID
                              join p in passwordService.GetAll()
                              on u.UserID equals p.UserID
                              select new
                              {
                                  id = u.UserID,
                                  name = u.Name,
                                  surname = u.Surname,
                                  token = u.Token,
                                  gender = u.Gender,
                                  roleid = r.RoleID,
                                  roletext = r.RoleText,
                                  password = p.Pass
                              }).ToList();
                RedisCache.Instance.Add(cacheKey, JsonConvert.SerializeObject(result));
                var json = JsonConvert.SerializeObject(result);
                return Ok(json);
            }
        }
        [HttpGet]
        [Route("~/User/Get/{id}")]
        public IActionResult Get(int id)
        {
            var item = UserService.Get(id);
            var result = (from u in UserService.GetAll()
                          join r in roleService.GetAll()
                          on item.UserID equals r.UserID
                          join p in passwordService.GetAll()
                          on item.UserID equals p.UserID
                          select new
                          {
                              id = item.UserID,
                              name = item.Name,
                              surname = item.Surname,
                              token = item.Token,
                              gender = item.Gender,
                              roleid = r.RoleID,
                              roletext = r.RoleText,
                              password = p.Pass
                          }).ToList().FirstOrDefault();

            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/User/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            User user = UserService.Get(id);
            if (user == null)
            {
                return new ResultHelper(true, user.UserID, ResultHelper.UnSuccessMessage);
            }

            UserService.Delete(user);
            return new ResultHelper(true, user.UserID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/User/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] User user)
        {
            if (user == null)
            {
                return new ResultHelper(true, user.UserID, ResultHelper.UnSuccessMessage);
            }

            UserService.Set(user);
            return new ResultHelper(true, user.UserID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/User/Add")]
        public ResultHelper Post([FromBody] User user)
        {
            if (user == null)
            {
                return new ResultHelper(true, user.UserID, ResultHelper.UnSuccessMessage);
            }

            RedisCache.Instance.Add("users", JsonConvert.SerializeObject(user));
            UserService.Create(user);
            return new ResultHelper(true, user.UserID, ResultHelper.SuccessMessage);


        }

    }
}