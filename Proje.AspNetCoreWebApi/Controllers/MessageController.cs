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
    public class MessageController : ControllerBase
    {
        #region service
        private readonly IGenericService<Message> messageService;
        public MessageController(IGenericService<Message> messageservice)
        {
            messageService = messageservice;
        }
        #endregion
        [HttpGet]
        [Route("~/Message/GetAll")]
        public IActionResult GetAll()
        {
            var result = messageService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/Message/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = messageService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/Message/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            Message Message = messageService.Get(id);
            if (Message == null)
            {
                return new ResultHelper(true, Message.MessageID, ResultHelper.UnSuccessMessage);
            }

            messageService.Delete(Message);
            return new ResultHelper(true, Message.MessageID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/Message/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] Message Message)
        {
            if (Message == null)
            {
                return new ResultHelper(true, Message.MessageID, ResultHelper.UnSuccessMessage);
            }

  

            messageService.Set( Message);
            return new ResultHelper(true, Message.MessageID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/Message/Add")]
        public ResultHelper Post([FromBody] Message Message)
        {
            if (Message == null)
            {
                return new ResultHelper(true, Message.MessageID, ResultHelper.UnSuccessMessage);
            }
            messageService.Create(Message);
            return new ResultHelper(true, Message.MessageID, ResultHelper.SuccessMessage);
        }
    }
}
