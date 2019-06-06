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
    public class AdvertController : ControllerBase
    {
        #region service
        private readonly IGenericService<Advert> advertService;
        public AdvertController(IGenericService<Advert> advertservice)
        {
            advertService = advertservice;
        }
        #endregion
        [HttpGet]
        [Route("~/advert/GetAllAdvert")]
        public IActionResult GetAll()
        {
            return Ok(JsonConvert.SerializeObject(advertService.GetAll()));
        }
        [HttpGet]
        [Route("~/advert/GetAdvert/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(JsonConvert.SerializeObject(advertService.Get(id)));
        }
        [HttpDelete]
        [Route("~/advert/DeleteAdvert/{id}")]
        public ResultHelper Delete(int id)
        {
            Advert advert = advertService.Get(id);
            if (advert == null)
            {
                return new ResultHelper(true, advert.AdvertID, ResultHelper.UnSuccessMessage);
            }

            advertService.Delete(advert);
            return new ResultHelper(true, advert.AdvertID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/advert/UpdateAdvert/{id}")]
        public ResultHelper Put(int id, [FromBody] Advert advert)
        {
            if (advert == null)
            {
                return new ResultHelper(true, advert.AdvertID, ResultHelper.UnSuccessMessage);
            }


            advertService.Set( advert);
            return new ResultHelper(true, advert.AdvertID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/advert/AddAdvert")]
        public ResultHelper Post([FromBody] Advert advert)
        {
            if (advert == null)
            {
                return new ResultHelper(true, advert.AdvertID, ResultHelper.UnSuccessMessage);
            }
            advertService.Create(advert);
            return new ResultHelper(true, advert.AdvertID, ResultHelper.SuccessMessage);
        }
    }
}
