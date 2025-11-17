using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentManagementApi.Commands.AddStudent;
using StudentManagementApi.Commands.DeleteStudent;
using StudentManagementApi.Commands.UpdateStudent;
using StudentManagementApi.Models;
using StudentManagementApi.Queries.GetAllStudents;

namespace StudentManagementApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentsController(IMediator mediator) => _mediator = mediator;

        [HttpPost]
        public async Task<ActionResult<Student>> Add(AddStudentCommand cmd)
        {
            return await _mediator.Send(cmd);
        }

        [HttpPut]
        public async Task<ActionResult<Student>> Update(UpdateStudentCommand cmd)
        {
            var result = await _mediator.Send(cmd);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var res = await _mediator.Send(new DeleteStudentCommand(id));
            return res ? NoContent() : NotFound();
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAll()
        {
            return await _mediator.Send(new GetAllStudentsQuery());
        }
    }
}
