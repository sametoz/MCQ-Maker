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
    public class EmailController : ControllerBase
    {
        #region service
        private readonly IGenericService<Email> emailService;
        public EmailController(IGenericService<Email> emailservice)
        {
            emailService = emailservice;
        }
        #endregion
        [HttpGet]
        [Route("~/Email/GetAll")]
        public IActionResult GetAll()
        {
            var result = emailService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/Email/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = emailService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/Email/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            Email Email = emailService.Get(id);
            if (Email == null)
            {
                return new ResultHelper(true, Email.EmailID, ResultHelper.UnSuccessMessage);
            }

            emailService.Delete(Email);
            return new ResultHelper(true, Email.EmailID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/Email/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] Email Email)
        {
            if (Email == null)
            {
                return new ResultHelper(true, Email.EmailID, ResultHelper.UnSuccessMessage);
            }



            emailService.Set( Email);
            return new ResultHelper(true, Email.EmailID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/Email/Add")]
        public ResultHelper Post([FromBody] Email Email)
        {
            if (Email == null)
            {
                return new ResultHelper(true, Email.EmailID, ResultHelper.UnSuccessMessage);
            }
            emailService.Create(Email);
            return new ResultHelper(true, Email.EmailID, ResultHelper.SuccessMessage);
        }
    }
}
