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
    public class AdvertStatusController : ControllerBase
    {
        #region service
        private readonly IGenericService<AdvertStatus> advertStatusService;
        public AdvertStatusController(IGenericService<AdvertStatus> advertstatusservice)
        {
            advertStatusService = advertstatusservice;
        }
        #endregion
        [HttpGet]
        [Route("~/AdvertStatus/GetAll")]
        public IActionResult GetAll()
        {
            var result = advertStatusService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/AdvertStatus/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = advertStatusService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/AdvertStatus/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            AdvertStatus advertStatus = advertStatusService.Get(id);
            if (advertStatus == null)
            {
                return new ResultHelper(true, advertStatus.AdvertStatusID, ResultHelper.UnSuccessMessage);
            }

            advertStatusService.Delete(advertStatus);
            return new ResultHelper(true, advertStatus.AdvertStatusID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/AdvertStatus/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] AdvertStatus AdvertStatus)
        {
            if (AdvertStatus == null)
            {
                return new ResultHelper(true, AdvertStatus.AdvertStatusID, ResultHelper.UnSuccessMessage);
            }


            advertStatusService.Set( AdvertStatus);
            return new ResultHelper(true, AdvertStatus.AdvertStatusID, ResultHelper.SuccessMessage);
        }
        [HttpPost]
        [Route("~/AdvertStatus/AddRole")]
        public ResultHelper Post([FromBody] AdvertStatus advertStatus)
        {
            if (advertStatus == null)
            {
                return new ResultHelper(true, advertStatus.AdvertStatusID, ResultHelper.UnSuccessMessage);
            }
            advertStatusService.Create(advertStatus);
            return new ResultHelper(true, advertStatus.AdvertStatusID, ResultHelper.SuccessMessage);
        }
    }
}
