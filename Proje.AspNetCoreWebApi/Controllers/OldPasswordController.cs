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
    public class OldPasswordController : ControllerBase
    {
        #region service
        private readonly IGenericService<OldPassword> oldPasswordService;
        public OldPasswordController(IGenericService<OldPassword> oldPasswordservice)
        {
            oldPasswordService = oldPasswordservice;
        }
        #endregion
        [HttpGet]
        [Route("~/OldPassword/GetAll")]
        public IActionResult GetAll()
        {
            var result = oldPasswordService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/OldPassword/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = oldPasswordService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/OldPassword/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            OldPassword OldPassword = oldPasswordService.Get(id);
            if (OldPassword == null)
            {
                return new ResultHelper(true, OldPassword.OldPasswordID, ResultHelper.UnSuccessMessage);
            }

            oldPasswordService.Delete(OldPassword);
            return new ResultHelper(true, OldPassword.OldPasswordID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/OldPassword/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] OldPassword OldPassword)
        {
            if (OldPassword == null)
            {
                return new ResultHelper(true, OldPassword.OldPasswordID, ResultHelper.UnSuccessMessage);
            }

   
            oldPasswordService.Set( OldPassword);
            return new ResultHelper(true, OldPassword.OldPasswordID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/OldPassword/Add")]
        public ResultHelper Post([FromBody] OldPassword OldPassword)
        {
            if (OldPassword == null)
            {
                return new ResultHelper(true, OldPassword.OldPasswordID, ResultHelper.UnSuccessMessage);
            }
            oldPasswordService.Create(OldPassword);
            return new ResultHelper(true, OldPassword.OldPasswordID, ResultHelper.SuccessMessage);
        }
    }
}
