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
    [Route("api/AdminApi")]
    [ApiController]
    public class AdminApiController : ControllerBase
    {
        private readonly ILogger<AdminController> _logger;

        public AdminApiController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        [HttpPost("Word")]
        public string SubmitWord(WordEntity wordEntity)
        {
            if (ModelState.IsValid)
            {
            LearningDbContext context = new LearningDbContext();
            context.Add(wordEntity);
            context.SaveChanges();
           
            }
             return "Word Inserted Successfully!";
        }

        [HttpPost("Blog")]
        public string SubmitBlog(PostEntity blogEntity)
        {
            if (ModelState.IsValid)
            {
            LearningDbContext context = new LearningDbContext();
            context.postEntities.Add(blogEntity);
            context.SaveChanges();
            
            }
             return "Word Inserted Successfully!";
        }
        [HttpPost("LogIn")]
        public  bool AdminLogin(LoginEntity loginEntity)
        {
            bool isTrue = false;
            if (ModelState.IsValid)
            {
                LoginEntity logEntity = new LoginEntity();
                LearningDbContext context = new LearningDbContext();
                logEntity=context.loginEntities.Where(x=>x.UserName==loginEntity.UserName && x.Password==loginEntity.Password).FirstOrDefault();
                if(logEntity!=null){
                   isTrue=true; 
                }
            }
            return isTrue;
        }


        
    }
}
