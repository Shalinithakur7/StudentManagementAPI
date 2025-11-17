using MediatR;
using StudentManagementApi.Data;

namespace StudentManagementApi.Commands.DeleteStudent
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, bool>
    {
        public Task<bool> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var s = StudentInfo.Students.FirstOrDefault(x => x.Id == request.Id);
            if (s == null) return Task.FromResult(false);

            StudentInfo.Students.Remove(s);
            return Task.FromResult(true);
        }
    }
}
