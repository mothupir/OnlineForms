using OnlineForms.Shared.Models;

namespace OnlineForms.Server.Services
{
    public class FormService : IFormService
    {
        public readonly DataContext Db;

        public FormService(DataContext db)
        {
            Db = db;
        }

        public int CreateForm(Form form)
        {
            throw new NotImplementedException();
        }

        public int DeleteForm(Form form)
        {
            throw new NotImplementedException();
        }

        public Form GetForm(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateForm(Form form)
        {
            throw new NotImplementedException();
        }
    }
}
