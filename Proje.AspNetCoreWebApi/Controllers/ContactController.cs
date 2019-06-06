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
    public class ContactController : ControllerBase
    {
        #region service
        private readonly IGenericService<Contact> contactService;
        public ContactController(IGenericService<Contact> contactservice)
        {
            contactService = contactservice;
        }
        #endregion
        [HttpGet]
        [Route("~/Contact/GetAll")]
        public IActionResult GetAll()
        {
            var result = contactService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/Contact/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = contactService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/Contact/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            Contact Contact = contactService.Get(id);
            if (Contact == null)
            {
                return new ResultHelper(true, Contact.ContactID, ResultHelper.UnSuccessMessage);
            }

            contactService.Delete(Contact);
            return new ResultHelper(true, Contact.ContactID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/Contact/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] Contact Contact)
        {
            if (Contact == null)
            {
                return new ResultHelper(true, Contact.ContactID, ResultHelper.UnSuccessMessage);
            }

            contactService.Set( Contact);
            return new ResultHelper(true, Contact.ContactID, ResultHelper.UnSuccessMessage);

        }
        [HttpPost]
        [Route("~/Contact/Add")]
        public ResultHelper Post([FromBody] Contact Contact)
        {
            if (Contact == null)
            {
                return new ResultHelper(true, Contact.ContactID, ResultHelper.UnSuccessMessage);
            }
            contactService.Create(Contact);
            return new ResultHelper(true, Contact.ContactID, ResultHelper.UnSuccessMessage);
        }
    }
}
