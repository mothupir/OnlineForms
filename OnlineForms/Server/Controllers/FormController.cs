using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineForms.Server.Services;
using OnlineForms.Shared.Models;

namespace OnlineForms.Server.Controllers
{
    [Route("api/form")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IFormService Service;

        public FormController(FormService service)
        {
            Service = service;
        }

        [HttpPost("create")]
        public int Create(Form form)
        {
            return Service.CreateForm(form);
        }

        [HttpDelete("delete")]
        public int Delete(Form form)
        {
            return Service.DeleteForm(form);
        }

        [HttpPut("update")]
        public int Update(Form form)
        {
            return Service.UpdateForm(form);
        }

        [HttpGet("get/{id}")]
        public Form Get(int id)
        {
            return Service.GetForm(id);
        }
    }
}
