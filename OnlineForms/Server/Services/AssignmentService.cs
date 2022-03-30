using OnlineForms.Shared.Models;

namespace OnlineForms.Server.Services
{
    public class AssignmentService : IAssignmentService
    {
        public readonly DataContext Db;

        public AssignmentService(DataContext db)
        {
            Db = db;
        }

        public int CreateAssignment(FormAssignment assignment)
        {
            throw new NotImplementedException();
        }

        public int DeleteAssignment(FormAssignment assignment)
        {
            throw new NotImplementedException();
        }

        public FormAssignment GetAssignment(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateAssignment(FormAssignment assignment)
        {
            throw new NotImplementedException();
        }
    }
}
