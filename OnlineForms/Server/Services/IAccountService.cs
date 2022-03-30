using OnlineForms.Shared.Models;

namespace OnlineForms.Server.Services
{
    public interface IAccountService
    {
        int CreateUser(User user);
        int UpdateUser(User user);
        int DeleteUser(User user);
        User GetUser(int id);
    }
}
