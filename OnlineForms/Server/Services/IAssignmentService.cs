using OnlineForms.Shared.Models;

namespace OnlineForms.Server.Services
{
    public interface IAssignmentService
    {
        int CreateAssignment(FormAssignment assignment);
        int UpdateAssignment(FormAssignment assignment);
        int DeleteAssignment(FormAssignment assignment);
        FormAssignment GetAssignment(int id);
    }
}
