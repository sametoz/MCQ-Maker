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
    public class RoleController : ControllerBase
    {
        #region service
        private readonly IGenericService<Role> roleService;
        public RoleController( IGenericService<Role> roleservice)
        {
            roleService = roleservice;
        }
        #endregion
        [HttpGet]
        [Route("~/Role/GetAll")]
        public IActionResult GetAll()
        {
            var result = roleService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/Role/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = roleService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/Role/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            Role role = roleService.Get(id);
            if (role == null)
            {
                return new ResultHelper(true, role.RoleID, ResultHelper.UnSuccessMessage);
            }

            roleService.Delete(role);
            return new ResultHelper(true, role.RoleID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/Role/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] Role role)
        {
            if (role == null)
            {
                return new ResultHelper(true, role.RoleID, ResultHelper.UnSuccessMessage);
            }
            roleService.Set( role);
            return new ResultHelper(true, role.RoleID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/Role/Add")]
        public ResultHelper Post([FromBody] Role role)
        {
            if (role == null)
            {
                return new ResultHelper(true, role.RoleID, ResultHelper.UnSuccessMessage);
            }
            roleService.Create(role);
            return new ResultHelper(true, role.RoleID, ResultHelper.SuccessMessage);
        }
    }
}
