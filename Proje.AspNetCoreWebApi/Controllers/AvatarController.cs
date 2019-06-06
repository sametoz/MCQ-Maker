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
    public class AvatarController : ControllerBase
    {
        #region service
        private readonly IGenericService<Avatar> avatarService;
        public AvatarController(IGenericService<Avatar> avatarservice)
        {
            avatarService = avatarservice;
        }
        #endregion
        [HttpGet]
        [Route("~/Avatar/GetAll")]
        public IActionResult GetAll()
        {
            var result = avatarService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/Avatar/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = avatarService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/Avatar/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            Avatar Avatar = avatarService.Get(id);
            if (Avatar == null)
            {
                return new ResultHelper(true, Avatar.AvatarID, ResultHelper.UnSuccessMessage);
            }

            avatarService.Delete(Avatar);
            return new ResultHelper(true, Avatar.AvatarID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/Avatar/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] Avatar Avatar)
        {
            if (Avatar == null)
            {
                return new ResultHelper(true, Avatar.AvatarID, ResultHelper.UnSuccessMessage);
            }

            avatarService.Set(Avatar);
            return new ResultHelper(true, Avatar.AvatarID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/Avatar/Add")]
        public ResultHelper Post([FromBody] Avatar Avatar)
        {
            if (Avatar == null)
            {
                return new ResultHelper(true, Avatar.AvatarID, ResultHelper.UnSuccessMessage);
            }
            avatarService.Create(Avatar);
            return new ResultHelper(true, Avatar.AvatarID, ResultHelper.UnSuccessMessage);
        }
    }
}
