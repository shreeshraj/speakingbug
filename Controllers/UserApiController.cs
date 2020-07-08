using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreProject.Models;

namespace CoreProject.Controllers
{
    
    [Route("api/UserApi")]
    [ApiController]
    public class UserApiController : ControllerBase
    {
        private readonly ILogger<AdminController> _logger;

        public UserApiController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        [HttpPost("Registration")]
        public void UserRegistration(UserEntity userEntity)
        {
        LearningDbContext context=new LearningDbContext();
        context.userEntities.Add(userEntity);
        context.SaveChanges();
        // HttpContext.Session.SetString("username",userEntity.Name);

        }

         [HttpGet("UsersList")]
        public IActionResult UsersList(int limit)
        {
            int displaySize = 9;
         LearningDbContext context=new LearningDbContext();
         var data=context.userEntities.OrderByDescending(x => x.Id).Skip(limit*displaySize).Take(displaySize).ToList();
            
            return new JsonResult(data);

        }
        [HttpPost("Feedback")]
        public void SubmitFeedback(ContactEntity contactEntity)
        {
           
            LearningDbContext context=new LearningDbContext();
            context.contactEntities.Add(contactEntity);
            context.SaveChanges();
            

        }

        [HttpGet("AllWords")]
        public IActionResult GetAllWords(int limit)
        {
            int displaySize = 9;
            LearningDbContext context = new LearningDbContext();
            var data= context.wordEntities.OrderByDescending(x => x.Id).Skip(limit * displaySize).Take(displaySize).ToList().ToList();
        return new JsonResult(data);
        }

        [HttpGet("AllBlogs")]
        public IActionResult GetAllBlogs(int limit)
        {
             int displaySize = 9;
              LearningDbContext context = new LearningDbContext();
             var data= context.postEntities.OrderByDescending(x => x.Id).Skip(limit * displaySize).Take(displaySize).ToList().ToList();
             return new JsonResult(data);

        }

        [HttpGet("Blog")]
        public IActionResult GetBlog(int Id)
        {
            LearningDbContext context = new LearningDbContext();
             var data= context.postEntities.Where(x=>x.Id==Id).FirstOrDefault();
             return new JsonResult(data);

        }
      
      
    }   
    
}
