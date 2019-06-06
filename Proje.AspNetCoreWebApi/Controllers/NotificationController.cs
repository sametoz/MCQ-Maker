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
//using StackExchange.Redis;

namespace Proje.AspNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {


        #region service
        private readonly IGenericService<Notification> notificationService;
        public NotificationController(IGenericService<Notification> notificationservice)
        {
            notificationService = notificationservice;
        }
        #endregion
        [HttpGet]
        [Route("~/Notification/GetAll")]
        public IActionResult GetAll()
        {
            
            var result = notificationService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/Notification/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = notificationService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/Notification/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            Notification notification = notificationService.Get(id);
            if (notification == null)
            {
                return new ResultHelper(true, notification.NotificationID, ResultHelper.UnSuccessMessage);
            }

            notificationService.Delete(notification);
            return new ResultHelper(true, notification.NotificationID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/Notification/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] Notification notification)
        {
            if (notification == null)
            {
                return new ResultHelper(true, notification.NotificationID, ResultHelper.UnSuccessMessage);
            }
            notificationService.Set(notification);
            return new ResultHelper(true, notification.NotificationID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/Notification/Add")]
        public ResultHelper Post([FromBody] Notification notification)
        {
            if (notification == null)
            {
                return new ResultHelper(true, notification.NotificationID, ResultHelper.UnSuccessMessage);
            }
            notificationService.Create(notification);
            return new ResultHelper(true, notification.NotificationID, ResultHelper.SuccessMessage);
        }
    }
}
