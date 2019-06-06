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
    public class ComplaintController : ControllerBase
    {
        #region service
        private readonly IGenericService<Complaint> complaintService;
        public ComplaintController(IGenericService<Complaint> complaintservice)
        {
            complaintService = complaintservice;
        }
        #endregion
        [HttpGet]
        [Route("~/complaint/GetAll")]
        public IActionResult GetAll()
        {
            var result = complaintService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/complaint/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = complaintService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/complaint/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            Complaint complaint = complaintService.Get(id);
            if (complaint == null)
            {
                return new ResultHelper(true, complaint.ComplaintID, ResultHelper.UnSuccessMessage);
            }

            complaintService.Delete(complaint);
            return new ResultHelper(true, complaint.ComplaintID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/complaint/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] Complaint complaint)
        {
            if (complaint == null)
            {
                return new ResultHelper(true, complaint.ComplaintID, ResultHelper.UnSuccessMessage);
            }

            complaintService.Set(complaint);
            return new ResultHelper(true, complaint.ComplaintID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/complaint/Add")]
        public ResultHelper Post([FromBody] Complaint complaint)
        {
            if (complaint == null)
            {
                return new ResultHelper(true, complaint.ComplaintID, ResultHelper.UnSuccessMessage);
            }
            complaintService.Create(complaint);
            return new ResultHelper(true, complaint.ComplaintID, ResultHelper.UnSuccessMessage);
        }
    }
}
