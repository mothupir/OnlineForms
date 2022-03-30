using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineForms.Server.Services;
using OnlineForms.Shared.Models;

namespace OnlineForms.Server.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService Service;

        public AccountController(IAccountService service)
        {
            Service = service;
        }

        [HttpPost("create")]
        public int Create(User user)
        {
            return Service.CreateUser(user);
        }

        [HttpDelete("delete")]
        public int Delete(User user) 
        { 
            return Service.DeleteUser(user); 
        }

        [HttpPut("update")]
        public int Update(User user) 
        { 
            return Service.UpdateUser(user); 
        }

        [HttpGet("get/{id}")]
        public User Get(int id)
        {
            var user = Service.GetUser(id);
            if(user == null)
            {
                user = new User()
                {
                    Id = id,
                    Email = new UserEmail()
                    {
                        Id = id,
                        Email = "mothupir@bbd.co.za"
                    },
                    Password = "mypassword"
                };
            }
            return user;
        }
    }
}
