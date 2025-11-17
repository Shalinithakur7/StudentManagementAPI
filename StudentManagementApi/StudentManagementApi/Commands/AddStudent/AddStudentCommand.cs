using MediatR;
using StudentManagementApi.Models;

namespace StudentManagementApi.Commands.AddStudent
{
    public record AddStudentCommand(string Name, int Age, string Email, string Department) : IRequest<Student>;
}
