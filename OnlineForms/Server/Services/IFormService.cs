using OnlineForms.Shared.Models;

namespace OnlineForms.Server.Services
{
    public interface IFormService
    {
        int CreateForm(Form form);
        int UpdateForm(Form form);
        int DeleteForm(Form form);
        Form GetForm(int id);
    }
}
