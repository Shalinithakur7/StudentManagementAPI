using StudentManagementApi.Commands.AddStudent;
using MediatR;
using StudentManagementApi.Data;
using StudentManagementApi.Models;

namespace Application.Commands.AddStudent;

public class AddStudentHandler : IRequestHandler<AddStudentCommand, Student>
{
    public Task<Student> Handle(AddStudentCommand request, CancellationToken cancellationToken)
    {
        var s = new Student
        {
            Id = StudentInfo.Students.Count + 1,
            Name = request.Name,
            Age = request.Age,
            Email = request.Email,
            Department = request.Department
        };

        StudentInfo.Students.Add(s);
        return Task.FromResult(s);
    }
}

