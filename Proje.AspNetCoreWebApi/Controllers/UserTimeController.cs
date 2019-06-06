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
    public class UserTimeController : ControllerBase
    {
        #region service
        private readonly IGenericService<UserTime> userTimeService;
        public UserTimeController(IGenericService<UserTime> userTimeservice)
        {
            userTimeService = userTimeservice;
        }
        #endregion
        [HttpGet]
        [Route("~/UserTime/GetAll")]
        public IActionResult GetAll()
        {
            var result = userTimeService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/UserTime/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = userTimeService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/UserTime/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            UserTime UserTime = userTimeService.Get(id);
            if (UserTime == null)
            {
                return new ResultHelper(true, UserTime.UserTimeID, ResultHelper.UnSuccessMessage);
            }

            userTimeService.Delete(UserTime);
            return new ResultHelper(true, UserTime.UserTimeID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/UserTime/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] UserTime UserTime)
        {
            if (UserTime == null)
            {
                return new ResultHelper(true, UserTime.UserTimeID, ResultHelper.UnSuccessMessage);
            }

            userTimeService.Set( UserTime);
            return new ResultHelper(true, UserTime.UserTimeID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/UserTime/Add")]
        public ResultHelper Post([FromBody] UserTime UserTime)
        {
            if (UserTime == null)
            {
                return new ResultHelper(true, UserTime.UserTimeID, ResultHelper.UnSuccessMessage);
            }
            userTimeService.Create(UserTime);
            return new ResultHelper(true, UserTime.UserTimeID, ResultHelper.SuccessMessage);
        }
    }
}
