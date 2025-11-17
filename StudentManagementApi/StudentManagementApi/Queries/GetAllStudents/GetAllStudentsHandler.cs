using MediatR;
using StudentManagementApi.Models;
using StudentManagementApi.Data;

namespace StudentManagementApi.Queries.GetAllStudents
{
    public class GetAllStudentsHandler : IRequestHandler<GetAllStudentsQuery, List<Student>>
    {
        public Task<List<Student>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(StudentInfo.Students);
        }
    }
}
