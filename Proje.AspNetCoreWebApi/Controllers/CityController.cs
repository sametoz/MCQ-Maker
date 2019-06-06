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
    public class CityController : ControllerBase
    {
        #region service
        private readonly IGenericService<City> cityService;
        public CityController(IGenericService<City> cityservice)
        {
            cityService = cityservice;
        }
        #endregion
        [HttpGet]
        [Route("~/City/GetAll")]
        public IActionResult GetAll()
        {
            var result = cityService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/City/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = cityService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/City/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            City City = cityService.Get(id);
            if (City == null)
            {
                return new ResultHelper(true, City.CityID, ResultHelper.UnSuccessMessage);
            }

            cityService.Delete(City);
            return new ResultHelper(true, City.CityID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/City/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] City City)
        {
            if (City == null)
            {
                return new ResultHelper(true, City.CityID, ResultHelper.UnSuccessMessage);
            }

            cityService.Set( City);
            return new ResultHelper(true, City.CityID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/City/Add")]
        public ResultHelper Post([FromBody] City City)
        {
            if (City == null)
            {
                return new ResultHelper(true, City.CityID, ResultHelper.UnSuccessMessage);
            }
            cityService.Create(City);
            return new ResultHelper(true, City.CityID, ResultHelper.SuccessMessage);
        }
    }
}
