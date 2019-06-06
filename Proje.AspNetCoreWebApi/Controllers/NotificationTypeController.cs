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
    public class NotificationTypeController : ControllerBase
    {
        #region service
        private readonly IGenericService<NotificationType> notificationTypeService;
        public NotificationTypeController(IGenericService<NotificationType> notificationtypeservice)
        {
            notificationTypeService = notificationtypeservice;
        }
        #endregion
        [HttpGet]
        [Route("~/NotificationType/GetAll")]
        public IActionResult GetAll()
        {
            var result = notificationTypeService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/NotificationType/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = notificationTypeService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/NotificationType/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            NotificationType notificationType = notificationTypeService.Get(id);
            if (notificationType == null)
            {
                return new ResultHelper(true, notificationType.NotificationTypeID, ResultHelper.UnSuccessMessage);
            }

            notificationTypeService.Delete(notificationType);
            return new ResultHelper(true, notificationType.NotificationTypeID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/NotificationType/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] NotificationType notificationType)
        {
            if (notificationType == null)
            {
                return new ResultHelper(true, notificationType.NotificationTypeID, ResultHelper.UnSuccessMessage);
            }
            notificationTypeService.Set(notificationType);
            return new ResultHelper(true, notificationType.NotificationTypeID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/NotificationType/Add")]
        public ResultHelper Post([FromBody] NotificationType notificationType)
        {
            if (notificationType == null)
            {
                return new ResultHelper(true, notificationType.NotificationTypeID, ResultHelper.UnSuccessMessage);
            }
            notificationTypeService.Create(notificationType);
            return new ResultHelper(true, notificationType.NotificationTypeID, ResultHelper.SuccessMessage);
        }
    }
}
