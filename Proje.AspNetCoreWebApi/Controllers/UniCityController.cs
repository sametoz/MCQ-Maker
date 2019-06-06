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
    public class UniCityController : ControllerBase
    {
        #region service
        private readonly IGenericService<UniCity> uniCityService;
        public UniCityController(IGenericService<UniCity> uniCityservice)
        {
            uniCityService = uniCityservice;
        }
        #endregion
        [HttpGet]
        [Route("~/UniCity/GetAll")]
        public IActionResult GetAll()
        {
            var result = uniCityService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/UniCity/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = uniCityService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/UniCity/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            UniCity UniCity = uniCityService.Get(id);
            if (UniCity == null)
            {
                return new ResultHelper(true, (int)UniCity.UniCityID, ResultHelper.UnSuccessMessage);
            }

            uniCityService.Delete(UniCity);
            return new ResultHelper(true, (int)UniCity.UniCityID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/UniCity/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] UniCity UniCity)
        {
            if (UniCity == null)
            {
                return new ResultHelper(true, (int)UniCity.UniCityID, ResultHelper.UnSuccessMessage);
            }

  

            uniCityService.Set( UniCity);
            return new ResultHelper(true, (int)UniCity.UniCityID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/UniCity/Add")]
        public ResultHelper Post([FromBody] UniCity UniCity)
        {
            if (UniCity == null)
            {
                return new ResultHelper(true, (int)UniCity.UniCityID, ResultHelper.UnSuccessMessage);
            }
            uniCityService.Create(UniCity);
            return new ResultHelper(true, (int)UniCity.UniCityID, ResultHelper.SuccessMessage);
        }
    }
}
