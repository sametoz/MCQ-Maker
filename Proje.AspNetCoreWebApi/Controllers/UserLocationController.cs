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
    public class UserLocationController : ControllerBase
    {
        #region service
        private readonly IGenericService<UserLocation> userLocationService;
        public UserLocationController(IGenericService<UserLocation> userLocationservice)
        {
            userLocationService = userLocationservice;
        }
        #endregion
        [HttpGet]
        [Route("~/UserLocation/GetAll")]
        public IActionResult GetAll()
        {
            var result = userLocationService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/UserLocation/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = userLocationService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/UserLocation/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            UserLocation UserLocation = userLocationService.Get(id);
            if (UserLocation == null)
            {
                return new ResultHelper(true, UserLocation.UserLocationId, ResultHelper.UnSuccessMessage);
            }
            userLocationService.Delete(UserLocation);
            return new ResultHelper(true, UserLocation.UserLocationId, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/UserLocation/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] UserLocation UserLocation)
        {
            if (UserLocation == null)
            {
                return new ResultHelper(true, UserLocation.UserLocationId, ResultHelper.UnSuccessMessage);
            }


            userLocationService.Set( UserLocation);
            return new ResultHelper(true, UserLocation.UserLocationId, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/UserLocation/Add")]
        public ResultHelper Post([FromBody] UserLocation UserLocation)
        {
            if (UserLocation == null)
            {
                return new ResultHelper(true, UserLocation.UserLocationId, ResultHelper.UnSuccessMessage);
            }
            userLocationService.Create(UserLocation);
            return new ResultHelper(true, UserLocation.UserLocationId, ResultHelper.SuccessMessage);
        }
    }
}
