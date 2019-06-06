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
    public class SharedPhotoController : ControllerBase
    {
        #region service
        private readonly IGenericService<SharedPhoto> sharedPhotoService;
        public SharedPhotoController(IGenericService<SharedPhoto> sharedPhotoservice)
        {
            sharedPhotoService = sharedPhotoservice;
        }
        #endregion
        [HttpGet]
        [Route("~/SharedPhoto/GetAll")]
        public IActionResult GetAll()
        {
            var result = sharedPhotoService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/SharedPhoto/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = sharedPhotoService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/SharedPhoto/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            SharedPhoto SharedPhoto = sharedPhotoService.Get(id);
            if (SharedPhoto == null)
            {
                return new ResultHelper(true, SharedPhoto.SharedPhotoID, ResultHelper.UnSuccessMessage);
            }

            sharedPhotoService.Delete(SharedPhoto);
            return new ResultHelper(true, SharedPhoto.SharedPhotoID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/SharedPhoto/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] SharedPhoto SharedPhoto)
        {
            if (SharedPhoto == null)
            {
                return new ResultHelper(true, SharedPhoto.SharedPhotoID, ResultHelper.UnSuccessMessage);
            }

            sharedPhotoService.Set( SharedPhoto);
            return new ResultHelper(true, SharedPhoto.SharedPhotoID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/SharedPhoto/Add")]
        public ResultHelper Post([FromBody] SharedPhoto SharedPhoto)
        {
            if (SharedPhoto == null)
            {
                return new ResultHelper(true, SharedPhoto.SharedPhotoID, ResultHelper.UnSuccessMessage);
            }
            sharedPhotoService.Create(SharedPhoto);
            return new ResultHelper(true, SharedPhoto.SharedPhotoID, ResultHelper.SuccessMessage);
        }
    }
}
