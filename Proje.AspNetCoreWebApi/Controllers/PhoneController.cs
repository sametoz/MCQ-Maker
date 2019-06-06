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
    public class PhoneController : ControllerBase
    {
        #region service
        private readonly IGenericService<Phone> phoneService;
        public PhoneController(IGenericService<Phone> phoneservice)
        {
            phoneService = phoneservice;
        }
        #endregion
        [HttpGet]
        [Route("~/Phone/GetAll")]
        public IActionResult GetAll()
        {
            var result = phoneService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/Phone/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = phoneService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/Phone/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            Phone Phone = phoneService.Get(id);
            if (Phone == null)
            {
                return new ResultHelper(true, Phone.PhoneID, ResultHelper.UnSuccessMessage);
            }

            phoneService.Delete(Phone);
            return new ResultHelper(true, Phone.PhoneID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/Phone/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] Phone Phone)
        {
            if (Phone == null)
            {
                return new ResultHelper(true, Phone.PhoneID, ResultHelper.UnSuccessMessage);
            }


            phoneService.Set( Phone);
            return new ResultHelper(true, Phone.PhoneID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/Phone/Add")]
        public ResultHelper Post([FromBody] Phone Phone)
        {
            if (Phone == null)
            {
                return new ResultHelper(true, Phone.PhoneID, ResultHelper.UnSuccessMessage);
            }
            phoneService.Create(Phone);
            return new ResultHelper(true, Phone.PhoneID, ResultHelper.SuccessMessage);
        }
    }
}
