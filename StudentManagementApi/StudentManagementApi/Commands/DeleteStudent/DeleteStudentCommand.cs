using MediatR;

namespace StudentManagementApi.Commands.DeleteStudent
{

    public record DeleteStudentCommand(int Id) : IRequest<bool>;
}
