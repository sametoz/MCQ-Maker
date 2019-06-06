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
    public class BlockedUserController : ControllerBase
    {
        #region service
        private readonly IGenericService<BlockedUser> blockedUserService;
        public BlockedUserController(IGenericService<BlockedUser> blockeduserservice)
        {
            blockedUserService = blockeduserservice;
        }
        #endregion
        [HttpGet]
        [Route("~/blockedUser/GetAll")]
        public IActionResult GetAll()
        {
            return Ok(JsonConvert.SerializeObject(blockedUserService.GetAll()));
        }
        [HttpGet]
        [Route("~/blockedUser/Get/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(JsonConvert.SerializeObject(blockedUserService.Get(id)));
        }
        [HttpDelete]
        [Route("~/blockedUser/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            BlockedUser blockedUser = blockedUserService.Get(id);
            if (blockedUser == null)
            {
                return new ResultHelper(true, blockedUser.BlockedUserID, ResultHelper.UnSuccessMessage);
            }

            blockedUserService.Delete(blockedUser);
            return new ResultHelper(true, blockedUser.BlockedUserID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/blockedUser/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] BlockedUser blockedUser)
        {
            if (blockedUser == null)
            {
                return new ResultHelper(true, blockedUser.BlockedUserID, ResultHelper.UnSuccessMessage);
            }


            blockedUserService.Set(blockedUser);
            return new ResultHelper(true, blockedUser.BlockedUserID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/blockedUser/Add")]
        public ResultHelper Post([FromBody] BlockedUser blockedUser)
        {
            if (blockedUser == null)
            {
                return new ResultHelper(true, blockedUser.BlockedUserID, ResultHelper.UnSuccessMessage);
            }
            blockedUserService.Create(blockedUser);
            return new ResultHelper(true, blockedUser.BlockedUserID, ResultHelper.SuccessMessage);
        }
    }
}
