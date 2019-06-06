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
    public class RegisterTempController : ControllerBase
    {
        #region service
        private readonly IGenericService<RegisterTemp> registerTempService;
        public RegisterTempController(IGenericService<RegisterTemp> registerTempservice)
        {
            registerTempService = registerTempservice;
        }
        #endregion
        [HttpGet]
        [Route("~/RegisterTemp/GetAll")]
        public IActionResult GetAll()
        {
            var result = registerTempService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/RegisterTemp/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = registerTempService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/RegisterTemp/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            RegisterTemp RegisterTemp = registerTempService.Get(id);
            if (RegisterTemp == null)
            {
                return new ResultHelper(true, RegisterTemp.RegisterTempID, ResultHelper.UnSuccessMessage);
            }

            registerTempService.Delete(RegisterTemp);
            return new ResultHelper(true, RegisterTemp.RegisterTempID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/RegisterTemp/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] RegisterTemp RegisterTemp)
        {
            if (RegisterTemp == null)
            {
                return new ResultHelper(true, RegisterTemp.RegisterTempID, ResultHelper.UnSuccessMessage);
            }


            registerTempService.Set( RegisterTemp);
            return new ResultHelper(true, RegisterTemp.RegisterTempID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/RegisterTemp/Add")]
        public ResultHelper Post([FromBody] RegisterTemp RegisterTemp)
        {
            if (RegisterTemp == null)
            {
                return new ResultHelper(true, RegisterTemp.RegisterTempID, ResultHelper.UnSuccessMessage);
            }
            registerTempService.Create(RegisterTemp);
            return new ResultHelper(true, RegisterTemp.RegisterTempID, ResultHelper.SuccessMessage);
        }
    }
}
