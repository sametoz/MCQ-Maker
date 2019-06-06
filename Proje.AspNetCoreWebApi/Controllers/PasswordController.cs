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
    public class PasswordController : ControllerBase
    {
        #region service
        private readonly IGenericService<Password> passwordService;
        public PasswordController( IGenericService<Password> passwordservice)
        {
            passwordService = passwordservice;
        }
        #endregion
        [HttpGet]
        [Route("~/user/GetUser/{id}")]
        public IActionResult Get(int id)
        {
            var result = passwordService.Get(id);

            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpPut]
        [Route("~/user/UpdateUser/{id}")]
        public ResultHelper Put(int id, [FromBody] Password password)
        {
            if (password == null)
            {
                return new ResultHelper(true, password.PasswordId, ResultHelper.UnSuccessMessage);
            }


            passwordService.Set( password);
            return new ResultHelper(true, password.PasswordId, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/user/AddUser")]
        public ResultHelper Post([FromBody] Password password)
        {
            if (password == null)
            {
                return new ResultHelper(true, password.PasswordId, ResultHelper.UnSuccessMessage);
            }
            passwordService.Create(password);
            return new ResultHelper(true, password.PasswordId, ResultHelper.SuccessMessage);
        }
    }
}
