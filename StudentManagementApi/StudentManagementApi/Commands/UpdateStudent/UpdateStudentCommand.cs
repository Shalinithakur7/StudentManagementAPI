using MediatR;
using StudentManagementApi.Models;

namespace StudentManagementApi.Commands.UpdateStudent
{
    public record UpdateStudentCommand(int Id, string Name, int Age, string Email, string Department) : IRequest<Student>;
}
