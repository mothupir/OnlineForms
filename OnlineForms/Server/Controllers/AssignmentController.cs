using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineForms.Server.Services;
using OnlineForms.Shared.Models;

namespace OnlineForms.Server.Controllers
{
    [Route("api/assignment")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService Service;

        public AssignmentController(AssignmentService service)
        {
            Service = service;
        }

        [HttpPost("create")]
        public int Create(FormAssignment assignment)
        {
            return Service.CreateAssignment(assignment);
        }

        [HttpDelete("delete")]
        public int Delete(FormAssignment assignment)
        {
            return Service.DeleteAssignment(assignment);
        }

        [HttpPut("update")]
        public int Update(FormAssignment assignment)
        {
            return Service.UpdateAssignment(assignment);
        }

        [HttpGet("get/{id}")]
        public FormAssignment Get(int id)
        {
            return Service.GetAssignment(id);
        }
    }
}
