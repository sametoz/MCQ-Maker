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
    public class FavAdvertController : ControllerBase
    {
        #region service
        private readonly IGenericService<FavAdvert> favAdvertService;
        public FavAdvertController(IGenericService<FavAdvert> favadvertservice)
        {
            favAdvertService = favadvertservice;
        }
        #endregion
        [HttpGet]
        [Route("~/favAdvert/GetAll")]
        public IActionResult GetAll()
        {
            var result = favAdvertService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/favAdvert/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = favAdvertService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/favAdvert/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            FavAdvert favAdvert = favAdvertService.Get(id);
            if (favAdvert == null)
            {
                return new ResultHelper(true, favAdvert.FavAdvertID, ResultHelper.UnSuccessMessage);
            }

            favAdvertService.Delete(favAdvert);
            return new ResultHelper(true, favAdvert.FavAdvertID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/favAdvert/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] FavAdvert favAdvert)
        {
            if (favAdvert == null)
            {
                return new ResultHelper(true, favAdvert.FavAdvertID, ResultHelper.UnSuccessMessage);
            }

            favAdvertService.Set(favAdvert);
            return new ResultHelper(true, favAdvert.FavAdvertID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/favAdvert/Add")]
        public ResultHelper Post([FromBody] FavAdvert favAdvert)
        {
            if (favAdvert == null)
            {
                return new ResultHelper(true, favAdvert.FavAdvertID, ResultHelper.UnSuccessMessage);
            }
            favAdvertService.Create(favAdvert);
            return new ResultHelper(true, favAdvert.FavAdvertID, ResultHelper.UnSuccessMessage);
        }
    }
}
