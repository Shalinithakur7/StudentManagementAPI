using MediatR;
using StudentManagementApi.Models;
using StudentManagementApi.Data;
namespace StudentManagementApi.Commands.UpdateStudent
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, Student>
    {
        public Task<Student> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var s = StudentInfo.Students.FirstOrDefault(x => x.Id == request.Id);
            if (s == null) return Task.FromResult<Student>(null);

            s.Name = request.Name;
            s.Age = request.Age;
            s.Email = request.Email;
            s.Department = request.Department;

            return Task.FromResult(s);
        }
    }
}
