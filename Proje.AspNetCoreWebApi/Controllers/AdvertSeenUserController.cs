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
    public class AdvertSeenUserController : ControllerBase
    {
        #region service
        private readonly IGenericService<AdvertSeenUser> advertseenuserservice;
        public AdvertSeenUserController(IGenericService<AdvertSeenUser> advertSeenUserService)
        {
            advertseenuserservice = advertSeenUserService;
        }
        #endregion
        [HttpGet]
        [Route("~/advertSeenUser/GetAll")]
        public IActionResult GetAll()
        {
            return Ok(JsonConvert.SerializeObject(advertseenuserservice.GetAll()));
        }
        [HttpGet]
        [Route("~/advertSeenUser/Get/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(JsonConvert.SerializeObject(advertseenuserservice.Get(id)));
        }
        [HttpDelete]
        [Route("~/advertSeenUser/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            AdvertSeenUser advert = advertseenuserservice.Get(id);
            if (advert == null)
            {
                return new ResultHelper(true, advert.AdvertSeenUserID, ResultHelper.UnSuccessMessage);
            }

            advertseenuserservice.Delete(advert);
            return new ResultHelper(true, advert.AdvertSeenUserID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/advertSeenUser/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] AdvertSeenUser advertSeenUser)
        {
            if (advertSeenUser == null)
            {
                return new ResultHelper(true, advertSeenUser.AdvertSeenUserID, ResultHelper.UnSuccessMessage);
            }


            advertseenuserservice.Set(advertSeenUser);
            return new ResultHelper(true, advertSeenUser.AdvertSeenUserID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/advertSeenUser/Add")]
        public ResultHelper Post([FromBody] AdvertSeenUser advertSeenUser)
        {
            if (advertSeenUser == null)
            {
                return new ResultHelper(true, advertSeenUser.AdvertSeenUserID, ResultHelper.UnSuccessMessage);
            }
            advertseenuserservice.Create(advertSeenUser);
            return new ResultHelper(true, advertSeenUser.AdvertSeenUserID, ResultHelper.SuccessMessage);
        }
    }
}
