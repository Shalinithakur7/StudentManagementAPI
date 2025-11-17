using MediatR;
using StudentManagementApi.Models;

namespace StudentManagementApi.Queries.GetAllStudents
{
    public record GetAllStudentsQuery() : IRequest<List<Student>>;
}
