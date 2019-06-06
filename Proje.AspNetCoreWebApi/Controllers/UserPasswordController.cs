using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proje.Business.Helper;
using Proje.Entity.Model;
using Proje.Interface;

namespace Proje.AspNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPasswordController : ControllerBase
    {
        #region service
        private readonly IGenericService<UserPassword> userPasswordService;
        public UserPasswordController(IGenericService<UserPassword> userPasswordservice)
        {
            userPasswordService = userPasswordservice;
        }
        #endregion
        [HttpGet]
        [Route("~/UserPassword/GetAll")]
        public IActionResult GetAll()
        {
            var result = userPasswordService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/UserPassword/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = userPasswordService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/UserPassword/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            UserPassword UserPassword = userPasswordService.Get(id);
            if (UserPassword == null)
            {
                return new ResultHelper(true, UserPassword.UserPasswordID, ResultHelper.UnSuccessMessage);
            }

            userPasswordService.Delete(UserPassword);
            return new ResultHelper(true, UserPassword.UserPasswordID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/UserPassword/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] UserPassword UserPassword)
        {
            if (UserPassword == null)
            {
                return new ResultHelper(true, UserPassword.UserPasswordID, ResultHelper.UnSuccessMessage);
            }

            userPasswordService.Set( UserPassword);
            return new ResultHelper(true, UserPassword.UserPasswordID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/UserPassword/Add")]
        public ResultHelper Post([FromBody] UserPassword UserPassword)
        {
            if (UserPassword == null)
            {
                return new ResultHelper(true, UserPassword.UserPasswordID, ResultHelper.UnSuccessMessage);
            }
            userPasswordService.Create(UserPassword);
            return new ResultHelper(true, UserPassword.UserPasswordID, ResultHelper.SuccessMessage);
        }
    }
}
