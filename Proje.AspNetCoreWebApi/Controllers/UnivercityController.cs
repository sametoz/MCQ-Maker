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
    public class UnivercityController : ControllerBase
    {
        #region service
        private readonly IGenericService<Univercity> univercityService;
        public UnivercityController(IGenericService<Univercity> univercityservice)
        {
            univercityService = univercityservice;
        }
        #endregion
        [HttpGet]
        [Route("~/Univercity/GetAll")]
        public IActionResult GetAll()
        {
            var result = univercityService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/Univercity/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = univercityService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/Univercity/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            Univercity Univercity = univercityService.Get(id);
            if (Univercity == null)
            {
                return new ResultHelper(true, Univercity.UnivercityID, ResultHelper.UnSuccessMessage);
            }

            univercityService.Delete(Univercity);
            return new ResultHelper(true, Univercity.UnivercityID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/Univercity/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] Univercity Univercity)
        {
            if (Univercity == null)
            {
                return new ResultHelper(true, Univercity.UnivercityID, ResultHelper.UnSuccessMessage);
            }

            univercityService.Set( Univercity);
            return new ResultHelper(true, Univercity.UnivercityID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/Univercity/Add")]
        public ResultHelper Post([FromBody] Univercity Univercity)
        {
            if (Univercity == null)
            {
                return new ResultHelper(true, Univercity.UnivercityID, ResultHelper.UnSuccessMessage);
            }
            univercityService.Create(Univercity);
            return new ResultHelper(true, Univercity.UnivercityID, ResultHelper.SuccessMessage);
        }
    }
}
