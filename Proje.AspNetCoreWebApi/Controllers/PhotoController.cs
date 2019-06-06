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
    public class PhotoController : ControllerBase
    {
        #region service
        private readonly IGenericService<Photo> photoService;
        public PhotoController(IGenericService<Photo> photoservice)
        {
            photoService = photoservice;
        }
        #endregion
        [HttpGet]
        [Route("~/Photo/GetAll")]
        public IActionResult GetAll()
        {
            var result = photoService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/Photo/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = photoService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/Photo/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            Photo Photo = photoService.Get(id);
            if (Photo == null)
            {
                return new ResultHelper(true, Photo.PhotoID, ResultHelper.UnSuccessMessage);
            }

            photoService.Delete(Photo);
            return new ResultHelper(true, Photo.PhotoID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/Photo/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] Photo Photo)
        {
            if (Photo == null)
            {
                return new ResultHelper(true, Photo.PhotoID, ResultHelper.UnSuccessMessage);
            }

            photoService.Set( Photo);
            return new ResultHelper(true, Photo.PhotoID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/Photo/Add")]
        public ResultHelper Post([FromBody] Photo Photo)
        {
            if (Photo == null)
            {
                return new ResultHelper(true, Photo.PhotoID, ResultHelper.UnSuccessMessage);
            }
            photoService.Create(Photo);
            return new ResultHelper(true, Photo.PhotoID, ResultHelper.SuccessMessage);
        }
    }
}
