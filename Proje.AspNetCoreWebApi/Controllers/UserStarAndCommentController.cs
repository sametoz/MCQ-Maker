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
    public class UserStarAndCommentController : ControllerBase
    {
        #region service
        private readonly IGenericService<UserStarAndComment> userStarAndCommentService;
        public UserStarAndCommentController(IGenericService<UserStarAndComment> userStarAndCommentservice)
        {
            userStarAndCommentService = userStarAndCommentservice;
        }
        #endregion
        [HttpGet]
        [Route("~/UserStarsAndComment/GetAll")]
        public IActionResult GetAll()
        {
            var result = userStarAndCommentService.GetAll();
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpGet]
        [Route("~/UserStarsAndComment/Get/{id}")]
        public IActionResult Get(int id)
        {
            var result = userStarAndCommentService.Get(id);
            var json = JsonConvert.SerializeObject(result);
            return Ok(json);
        }
        [HttpDelete]
        [Route("~/UserStarsAndComment/Delete/{id}")]
        public ResultHelper Delete(int id)
        {
            UserStarAndComment UserStarAndComment = userStarAndCommentService.Get(id);
            if (UserStarAndComment == null)
            {
                return new ResultHelper(true, UserStarAndComment.UserStarAndCommentID, ResultHelper.UnSuccessMessage);
            }

            userStarAndCommentService.Delete(UserStarAndComment);
            return new ResultHelper(true, UserStarAndComment.UserStarAndCommentID, ResultHelper.SuccessMessage);
        }
        [HttpPut]
        [Route("~/UserStarsAndComment/Update/{id}")]
        public ResultHelper Put(int id, [FromBody] UserStarAndComment UserStarAndComment)
        {
            if (UserStarAndComment == null)
            {
                return new ResultHelper(true, UserStarAndComment.UserStarAndCommentID, ResultHelper.UnSuccessMessage);
            }


            userStarAndCommentService.Set( UserStarAndComment);
            return new ResultHelper(true, UserStarAndComment.UserStarAndCommentID, ResultHelper.SuccessMessage);

        }
        [HttpPost]
        [Route("~/UserStarsAndComment/Add")]
        public ResultHelper Post([FromBody] UserStarAndComment UserStarAndComment)
        {
            if (UserStarAndComment == null)
            {
                return new ResultHelper(true, UserStarAndComment.UserStarAndCommentID, ResultHelper.UnSuccessMessage);
            }
            userStarAndCommentService.Create(UserStarAndComment);
            return new ResultHelper(true, UserStarAndComment.UserStarAndCommentID, ResultHelper.SuccessMessage);
        }
    }
}
